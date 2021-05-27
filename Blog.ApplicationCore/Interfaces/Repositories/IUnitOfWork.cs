using Blog.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Repositories
{
	public interface IUnitOfWork : IDisposable
	{
		public IRepository<ApplicationUser> Users { get; }
		public IArticleRepository Articles { get; }
		public IRepository<Category> Categories { get; }
		public IRepository<Comment> Comments { get; }
		Task<int> Complete();
	}
}
