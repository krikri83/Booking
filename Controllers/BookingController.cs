using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking2.Data;
using Booking2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Booking2.Controllers
{
	public class BookingController : Controller
	{
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly ApplicationDbContext _context;
		private readonly UserManager<ApplicationUser> _userManager;
		public BookingController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
		{
			_context = context;
			_userManager = userManager;
			_signInManager = signInManager;
		}
		[AllowAnonymous]
		public async Task<ActionResult> Booking(Guid id)
		{
			var model = await GetBookARoomAsync(id);

			return View(model);
		}

		[Authorize(Roles = "Admin, User")]
		public async Task<ActionResult> BookingUser(Guid id)
		{
			var model = await GetBookARoomAsync(id);
			
			return View(model);
		}

		[AllowAnonymous]
		public ActionResult BookingJS(Guid id)
		{

			ViewBag.RoomId = id;
			return View();
		}

		public async Task<JsonResult> GetBookARoomJson(Guid id)
		{
			var model = await GetBookARoomAsync(id);
			return Json(JsonConvert.SerializeObject(model));
		}

		
		
		private async Task<BookAroom> GetBookARoomAsync(Guid id)
		{
			var room = await _context.Rooms.FindAsync(id);
			var bookings = await _context.Bookings.Where(b => b.RoomId == id && b.StartDate >= DateTime.Now.Date && b.StartDate < DateTime.Now.Date.AddDays(1)).ToListAsync();
			var next = await _context.Bookings.OrderBy(b => b.StartDate).Where(b => b.StartDate >= DateTime.Now).FirstOrDefaultAsync();
			return new BookAroom(room.Id, bookings.FirstOrDefault(b => b.StartDate <= DateTime.Now && b.EndDate >= DateTime.Now),
				room.Name, bookings, next);
		}

		public async Task<JsonResult> GetBookingsForDateJson(Guid roomId)
		{
			var bookings = await _context.Bookings.Where(b => b.RoomId == roomId && b.StartDate >= DateTime.Now.Date && b.StartDate < DateTime.Now.Date.AddDays(1)).ToListAsync();
			
			return Json(JsonConvert.SerializeObject(bookings));
		}

		public ActionResult SpeedBook(Guid roomId, SpeedbookingChoices minutes)
		{ 

			var a = Data.Booking.FastBooking(roomId, Convert.ToInt32(minutes));
			_context.Add(a);
			_context.SaveChanges();
			return RedirectToAction("Booking", "Booking2", new { id = roomId });
		}

		[HttpPost]
		public ActionResult CreateBooking(RegisterBookingModel model)
		{
			var user = ControllerContext.HttpContext.User.Identity.Name;
			var sDate = model.StartDate.AddHours(model.StartTime.Hour);
			
			var eDate = model.EndDate.AddHours(model.EndTime.Hour);
			
			var a = Data.Booking.MakeAbooking(sDate, eDate, model.roomId, user);
			
				_context.Add(a);
				_context.SaveChanges();
				return RedirectToAction("Index", "HomeBase");
		}

		// POST: Booking /Delete
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(Guid id, Guid roomId)
		{
			var theBooking = await _context.Bookings.FindAsync(id);
			_context.Bookings.Remove(theBooking);
			await _context.SaveChangesAsync();

			return RedirectToAction(nameof(Booking), new { id = roomId });

		}
		[HttpPost, ActionName("DeleteBooking")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirm(Guid id, Guid roomId)
		{
			var theBooking = await _context.Bookings.FindAsync(id);
			_context.Bookings.Remove(theBooking);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index", "HomeBase");

		}
		//JsonResult/Create
		public ActionResult CreateSpeedBook([FromBody] BookingRequest request)
		{
			var a = Data.Booking.FastBooking(request.roomId, request.minutes);

			_context.Add(a);
			_context.SaveChanges();

			return Json(JsonConvert.SerializeObject(request.roomId));

		}

		//JsonResult/Delete

		public ActionResult DeleteBooking([FromBody] BookingDelete request)
		{
			var theBooking = _context.Bookings.Find(request.id);
			_context.Bookings.Remove(theBooking);
			_context.SaveChanges();
			return Json(JsonConvert.SerializeObject(request.roomId));
		}



	}

}