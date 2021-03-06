using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ApplicationCore.DTOs
{
	public class CommentDTO
	{
		public string Comment { get; set; }
		public string CommentAuthor { get; set; }
		public string CommentAuthorImageUrl { get; set; }
		public string CommentDate { get; set; }
		public string CommentAuthorEmail { get; set; }
		public string CommentAuthorId { get; set; }
		public int ArticleId { get; set; }
	}
}
