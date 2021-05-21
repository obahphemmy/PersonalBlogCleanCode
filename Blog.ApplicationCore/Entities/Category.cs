using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Entities
{
	public class Category : AuditableEntity
	{
		public string CategoryName { get; set; }
		public string Description { get; set; }
		public string CategoryImageUrl { get; set; }
		public ICollection<Article> Articles { get; set; }
	}
}
