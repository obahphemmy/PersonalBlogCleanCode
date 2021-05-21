using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.UI.Web.ViewModels
{
	public class IndexViewModel
	{
		public IEnumerable<ArticleDTO> SliderArticles { get; set; } = new List<ArticleDTO>();
		public IEnumerable<ArticleDTO> BodyArticles { get; set; } = new List<ArticleDTO>();
		public IEnumerable<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>();
	}
}
