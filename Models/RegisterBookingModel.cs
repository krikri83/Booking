using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class RegisterBookingModel
	{
		[Required]
		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime StartTime { set; get; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime EndTime { set; get; }
		/*[Required]
		public string Minutes { set; get; }*/
		[Required]
		public Guid roomId { set; get; }

	}
}
