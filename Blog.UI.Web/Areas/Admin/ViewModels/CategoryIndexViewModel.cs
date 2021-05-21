using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.UI.Web.Areas.Admin.ViewModels
{
	public class CategoryIndexViewModel
	{
		public IEnumerable<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
	}
}
