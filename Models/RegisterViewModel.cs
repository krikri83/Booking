using Booking2.Data;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking2.Models
{
	public class RegisterViewModel
	{
		[Required, MaxLength(50), Display(Name = "Användarnamn")]
		public string UserName { get; set; }

		[Required, EmailAddress, MaxLength(256), Display(Name = "Email Address")]
		public string Email { get; set; }

		[Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name ="Lösenord")]
		public string Password { get; set; }

		[Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Bekräfta lösenord")]
		[Compare("Password", ErrorMessage ="Lösenorden är ej korrect.")]
		public string ConfirmPassword { get; set; }
		
		public string Roll { get; set; }

		
	}
}
