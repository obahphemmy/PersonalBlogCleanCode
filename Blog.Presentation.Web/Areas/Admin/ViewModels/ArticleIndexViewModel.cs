using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.Presentation.Web.Areas.Admin.ViewModels
{
	public class ArticleIndexViewModel
	{
		public IEnumerable<ArticleDTO> Articles { get; set; } = new List<ArticleDTO>();
	}
}
