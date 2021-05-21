using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.UI.Web.Areas.Admin.ViewModels
{
	public class AddUserViewModel
	{
		private static Random random = new Random();
		[Required(ErrorMessage ="Please enter your firstname")]
		public string Firstname { get; set; }

		[Required(ErrorMessage = "Please enter your lastname")]
		public string Lastname { get; set; }

		[Required(ErrorMessage = "Please enter your email address")]
		[DataType(DataType.EmailAddress, ErrorMessage ="Please enter a valid email address")]
		[Display(Name ="Email address")]
		public string Email { get; set; }

		[RegularExpression(@"https?.+", ErrorMessage ="Please enter a valid profile image URL")]
		public string UserImageUrl { get; set; } = GetImageUrl();

		[Required(ErrorMessage = "Please enter your password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please confirm your password")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage ="Passwords mis-matched")]
		public string ConfirmPassword { get; set; }


		private static string GetImageUrl()
		{
			int randomNumber = random.Next(30, 100);
			return $"https://randomuser.me/api/portraits/men/{randomNumber}.jpg";
		}

	}
}
