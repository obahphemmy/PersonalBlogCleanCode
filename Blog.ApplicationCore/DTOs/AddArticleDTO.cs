using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ApplicationCore.DTOs
{
	public class AddArticleDTO : ArticleDTO
	{
		public int CategoryId { get; set; }
		public string AuthorId { get; set; }
	}
}
