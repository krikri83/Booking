using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Data
{
	public class Booking
	{
		public Guid Id { get; set; }
		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }
		public Guid RoomId { get; set; }
		public virtual Room Room { get; set; }
		public string UserName { get; set; }

		public string GetStartTimeString
		{
			get
			{
				string result = StartDate.Hour.ToString();
				if (StartDate.Minute > 0)
					result += ":" + StartDate.Minute.ToString().PadLeft(2, '0');
				return result;
			}
		}

		public string GetEndTimeString
		{
			get
			{
				string result = EndDate.Hour.ToString();
				if (EndDate.Minute > 0)
					result += ":" + EndDate.Minute.ToString().PadLeft(2, '0');
				return result;
		
			}
		}

		public Booking()
		{

			this.Id = Id; this.StartDate = DateTime.Now; this.EndDate = DateTime.Now; this.RoomId = RoomId; this.Room = Room; this.UserName = UserName;

		}
		public Booking(DateTime start, DateTime end, Guid roomId)
		{

			this.StartDate = start; this.EndDate = end; this.RoomId = roomId;
		}
		public Booking(DateTime start, DateTime end, Guid roomId, string user)
		{

			this.StartDate = start; this.EndDate = end; this.RoomId = roomId; this.UserName = user;
		}
		////Skapa en bokning

		public static Booking FastBooking(Guid roomId, int nb)
		{
			DateTime timeEnd = DateTime.Now;
			timeEnd = timeEnd.AddMinutes(nb);

			return new Data.Booking(DateTime.Now, timeEnd, roomId);

		}
		public static Booking MakeAbooking(DateTime start, DateTime end, Guid room, string user)
		{
			
			Booking l = new Data.Booking(start, end, room, user);
			return l;
		}
		
	}
}
