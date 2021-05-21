using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Blog.ApplicationCore.Entities
{
	public class ApplicationUser : IdentityUser
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string ProfilePhotoUrl { get; set; }
		public ICollection<Article> Articles { get; set; }
		public ICollection<Comment> Comments { get; set; }
		public DateTimeOffset? CreatedDate { get; set; } = DateTimeOffset.Now;
		public DateTimeOffset? LastModifiedDate { get; set; } = DateTimeOffset.Now;
		
	}
}
