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

namespace Booking2.Controllers
{
    public class HomeBaseController : Controller
    {

		private readonly ApplicationDbContext _context;
		
		public HomeBaseController( ApplicationDbContext context)
		{
			
			_context = context;
		}
		[Authorize(Roles = "Admin, User")]
		public async Task<IActionResult> Index()
		{

			IQueryable<Data.Booking> query = _context.Bookings.Include(b=> b.Room);//.Where(b=> b.EndDate < DateTime.Now);
			if (!HttpContext.User.IsInRole("Admin"))
			{
				query = query.Where(b => b.UserName == ControllerContext.HttpContext.User.Identity.Name);
			}


			var bookings = await query.ToListAsync();
			var model = new BookAroom(bookings);

			return View(model);
		}

		

	}
}