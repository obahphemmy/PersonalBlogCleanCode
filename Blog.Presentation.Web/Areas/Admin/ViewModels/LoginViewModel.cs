using System.ComponentModel.DataAnnotations;

namespace Blog.Presentation.Web.Areas.Admin.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Please enter your email address")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address")]
		[Display(Name = "Email address")]
		public string Email { get; set; }


		[Required(ErrorMessage = "Please enter your password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
