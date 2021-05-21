using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ApplicationCore.DTOs
{
	public class AddApplicationUserDTO : ApplicationUserDTO
	{
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
}
