using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ApplicationCore.Entities
{
	public class Comment : AuditableEntity
	{
		public string ArticleComment { get; set; }
		public Article Article { get; set; }
		public int ArticleId { get; set; }
		public ApplicationUser CommentAuthor { get; set; }
		public string CommentAuthorId { get; set; }
	}
}
