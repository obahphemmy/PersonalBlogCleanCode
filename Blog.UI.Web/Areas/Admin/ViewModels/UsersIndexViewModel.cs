using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.UI.Web.Areas.Admin.ViewModels
{
	public class UsersIndexViewModel
	{
		public IEnumerable<ApplicationUserDTO> Users { get; set; } = new List<ApplicationUserDTO>();
	}
}
