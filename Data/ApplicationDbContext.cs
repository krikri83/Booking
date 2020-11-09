using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking2.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
			
		}
		
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Room> Rooms { get; set; }
		


	}
}
