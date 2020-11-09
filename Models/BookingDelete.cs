using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Booking2.Models
{
	public class BookingDelete
	{
		[DataMember]
		public Guid id { get; set; }
		[DataMember]
		public Guid roomId { get; set; }

		public BookingDelete()
		{

		}
	}
}
