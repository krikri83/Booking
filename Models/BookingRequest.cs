using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class BookingRequest
	{
		[DataMember]
		public Guid roomId { get; set; }
		[DataMember]
		public int minutes { get; set; }

		public BookingRequest()
		{

		}
	}
}
