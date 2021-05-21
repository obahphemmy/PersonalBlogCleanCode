using System;
using System.Collections.Generic;

namespace Blog.ApplicationCore.Entities
{
	public class Article :AuditableEntity
	{
		public string Title { get; set; }
		public string Body { get; set; }
		public string ArticleImageUrl { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public string AuthorId { get; set; }
		public ApplicationUser Author { get; set; }
		public ICollection<Comment> Comments { get; set; }
	}
}
