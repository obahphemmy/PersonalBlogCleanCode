using Blog.ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL.Context
{
	public class BlogDbContext : IdentityDbContext<ApplicationUser>
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
		{}

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }
	}
}
