using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class UserRoleSeed
	{
		//Att skapa roler i databasen
		//Créer les roles dans le base de données. RoleManager gére les rôles et peut créer un identité pour les rôles
		private readonly RoleManager<IdentityRole> _roleManager;

		public UserRoleSeed(RoleManager<IdentityRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task Seed()
		{
			if(await _roleManager.FindByNameAsync("Admin") == null)
			{
				await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
			}
			if (await _roleManager.FindByNameAsync("User") == null)
			{
				await _roleManager.CreateAsync(new IdentityRole { Name = "User" });
			}

		}
	}
}
