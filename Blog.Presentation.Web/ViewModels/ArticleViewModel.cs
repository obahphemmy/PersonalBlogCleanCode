using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Blog.Presentation.Web.ViewModels
{
	public class ArticleViewModel
	{
		public ArticleDTO Article { get; set; }
		public int? Previous { get; set; }
		public int? Next { get; set; }
		public IEnumerable<ArticleDTO> RelatedArticles { get; set; } = new List<ArticleDTO>();
		public CommentViewModel Comment { get; set; }
	}
}
