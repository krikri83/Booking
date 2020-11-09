using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class BookAroom
	{
		public Guid RoomId { get; set; }
		public Data.Booking CurrentBooking { get; set; }

		public string Name { get; set; }

		public List<Data.Booking> Bookings { get; set; }
		public Data.Booking NextBooking { get; set; }
		[DataType(DataType.Date)]
		public DateTime Datum { get; set; }
		
	
		public BookAroom(List<Data.Booking> bookings)
		{
			Bookings = bookings;
			
		}
			public BookAroom(Guid roomId,Data.Booking currentBooking, string name, List<Data.Booking> bookings, Data.Booking nextBooking)
		{
			this.RoomId = roomId;
			this.Name = name;
			this.Bookings = bookings;
			this.CurrentBooking = currentBooking;
			this.NextBooking = nextBooking;
			this.IsBusy = GetIsBusy();
			this.FreeMinutesLeft = GetFreeMinutesLeft();
			this.StartDate = GetStartDate();
			this.EndDate = GetEndDate();
			this.MeetingOftoDay = GetMeetingOftoDay();
			


		}
		public string EndTime { get; set; }
		public string StartTime { get; set; }
		public string StartDate { get; set; }
		public string GetStartDate()
		{
			string start = "";
			if (CurrentBooking != null)
			{
				DateTime str = CurrentBooking.StartDate;
				start = String.Format("{0:d/M/yyyy HH:mm:ss}", str);
			}
			return start;
		}
		public string EndDate { get; set; }
		public string GetEndDate()
		{
			string start = "";
			if (CurrentBooking != null)
			{
				DateTime str = CurrentBooking.EndDate;
				start = String.Format("{0:d/M/yyyy HH:mm:ss}", str);
			}
			return start;
		}

		//Går det att boka? 
		public bool IsBusy { get; set; }
		public bool GetIsBusy()
		{
			return this.CurrentBooking != null;
		}
		public int? FreeMinutesLeft { get; set; }
		public int? GetFreeMinutesLeft()
		{
			int? result = 0;

			if (!GetIsBusy())
			{
				if (NextBooking != null)
				{
					result = Convert.ToInt32((NextBooking.StartDate - DateTime.Now).TotalMinutes);
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		//Dagens möten
		public List<Data.Booking> MeetingOftoDay { get; set; }

		public List<Data.Booking> GetMeetingOftoDay()
		{
			List<Data.Booking> l = new List<Data.Booking>();
			foreach (Data.Booking a in this.Bookings)
			{
				if (a.StartDate >= DateTime.Now)
					l.Add(a);
			}
			return l;
		}
		public List<Data.Booking> GetMeetings(DateTime det)
		{
			List<Data.Booking> l = new List<Data.Booking>();
			foreach (Data.Booking a in this.Bookings)
			{
				if (a.StartDate != det)
					l.Add(a);
			}
			return l;
		}
		
		public List<Data.Booking> GetMeetingsOfUser(string us)
		{
			int res = 0;
			List<Data.Booking> l = new List<Data.Booking>();
			foreach (Data.Booking a in this.Bookings)
			{
			
				if (a.UserName == us)
					l.Add(a);
					res++;
			}
			return l;
		}
		
		
		
	}


}

	
