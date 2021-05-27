using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.DAL.Context;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly BlogDbContext _dbContext;
		public IArticleRepository Articles { get; private set;  }
		public IRepository<Category> Categories { get; private set; }
		public IRepository<ApplicationUser> Users { get; private set; }
		public IRepository<Comment> Comments { get; private set; }

		public UnitOfWork(BlogDbContext dbContext, IArticleRepository articleRepository, IRepository<Category> categoryRepository, IRepository<ApplicationUser> userRepository, IRepository<Comment> commentRepository)
		{
			_dbContext = dbContext;
			Articles = articleRepository;
			Categories = categoryRepository;
			Users = userRepository;
			Comments = commentRepository;
		}

		public async Task<int> Complete()
		{
			return await _dbContext.SaveChangesAsync();
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}

	}
}
