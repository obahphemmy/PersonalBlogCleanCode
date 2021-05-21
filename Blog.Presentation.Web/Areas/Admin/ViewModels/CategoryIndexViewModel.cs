using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.Presentation.Web.Areas.Admin.ViewModels
{
	public class CategoryIndexViewModel
	{
		public IEnumerable<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
	}
}
