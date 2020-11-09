using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class UserAndRoleViewModel
	{
		public string Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public IList<string> Roles { get; set; }
		public List<UserAndRoleViewModel> UserAndRole { get; set; }

	}
}
