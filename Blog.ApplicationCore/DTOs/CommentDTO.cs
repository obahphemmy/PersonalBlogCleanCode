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
	}
}
