using Booking2.Data;
using Booking2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Booking2.Controllers
{
	public class AccountController : Controller
	{

		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _context;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_roleManager = roleManager;
			_context = context;

		}

		[HttpGet]
		public IActionResult Login()
		{
			return View("Login");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel model)
		{

			if (ModelState.IsValid)
			{
				var userName = model.Email;
				if (userName.IndexOf('@') > -1)
				{
					var user = await _userManager.FindByEmailAsync(model.Email);
					if (user == null)
					{
						ModelState.AddModelError(string.Empty, "Inloggning är ogiltig.");
						return View(model);
					}
					else
					{
						userName = user.UserName;
						var result = await _signInManager.PasswordSignInAsync(userName, model.Password, model.RememberMe, lockoutOnFailure: false);
						return RedirectToAction("Index", "HomeBase");
					}
				}
			}
			return View("Login");
		}

		[ValidateAntiForgeryToken]
		[HttpPost]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		[Authorize(Roles = "Admin")]
		public IActionResult Register()
		{
			return View("Register");
		}
		[HttpPost]
		[Authorize(Roles = "Admin")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = new ApplicationUser { UserName = model.UserName, Email = model.Email };
				var result = await _userManager.CreateAsync(user, model.Password);

				if (result.Succeeded)
				{
					await _userManager.AddToRoleAsync(user, model.Roll);
					
					return RedirectToAction( "Index", "HomeBase");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}
			//S'il y a default, en faire une retour.

			return View(model);
		}
		public IActionResult AccessDenied()
		{
			return View();
		}
		[HttpGet]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> ListOfUser()
		{
			var allUsers = await _userManager.Users.ToListAsync();
			UserAndRoleViewModel UserAndRoleViewModel = new UserAndRoleViewModel();

			List<UserAndRoleViewModel> AllUsersAndRoles = new List<UserAndRoleViewModel>();

			foreach (var usr in allUsers)
			{
				var model = new UserAndRoleViewModel
				{
					UserName = usr.UserName,
					Email = usr.Email,
					Id = usr.Id,
					Roles = await _userManager.GetRolesAsync(usr)
				};

				AllUsersAndRoles.Add(model);
			}

			UserAndRoleViewModel.UserAndRole = AllUsersAndRoles;

			return View(UserAndRoleViewModel);
		}

		// GET: User/Delete
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> Delete(string id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var us = await _userManager.FindByIdAsync(id);
			
			UserAndRoleViewModel model = new UserAndRoleViewModel();
			if (us == null)
			{
				return NotFound();
			}

			us.Id = model.Id;
			us.UserName = model.UserName;
			us.Email = model.Email;
			
			return View(model);
		}

		[HttpPost, ActionName("Delete")]
		[Authorize(Roles = "Admin")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirm(string id)
		{
			//get User Data from id
			var user = await _userManager.FindByIdAsync(id);
			

			//Delete User
			var roles = await _userManager.GetRolesAsync(user);

			await _userManager.RemoveFromRolesAsync(user, roles);
			await _userManager.DeleteAsync(user);

			TempData["Message"] = "User Deleted Successfully. ";
			TempData["MessageValue"] = "1";
			//transaction.commit();


			return RedirectToAction("ListOfUser", new { area = "", });
		}
		//JsonResult/Create
		public ActionResult CreateBooking([FromBody] BookingRequest request)
		{
			var a = Data.Booking.FastBooking(request.roomId, request.minutes);

			_context.Add(a);
			_context.SaveChanges();

			return Json(JsonConvert.SerializeObject(request.roomId));

		}
	}
}