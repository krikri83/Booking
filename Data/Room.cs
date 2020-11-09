using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Data
{
	public class Room
	{ 
		public Guid Id { set; get; }
		[Required]
		public string Name { get; set; }

	}
}
