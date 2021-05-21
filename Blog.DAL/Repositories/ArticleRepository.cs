using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class ArticleRepository : Repository<Article>, IArticleRepository
	{
		public ArticleRepository(BlogDbContext context) : base(context)
		{

		}

		public ICollection<Article> GetArticlesByCategoryName(string cat)
		{
			return _dbContext.Articles.Where(a => a.Category.CategoryName == cat).ToList();
		}

		public async Task<IEnumerable<Article>> GetArticlesWithAuthorCategory(int count)
		{
			return await _dbContext.Articles.Include(a => a.Author).Include(a => a.Category).OrderByDescending(a => a.CreatedDate).Take(count).ToListAsync();
		}

		public async Task<int?> GetNextArticleId(int? currentId)
		{
			if (currentId == null)
				return null;

			var article = await _dbContext.Articles.FirstOrDefaultAsync(a => a.Id > currentId);

			if (article == null)
				return null;

			return article.Id;
		}

		public async Task<int?> GetPreviousArticleId(int? currentId)
		{
			if (currentId == null)
				return null;

			var article = await _dbContext.Articles.Where(a => a.Id < currentId).OrderByDescending(a => a.Id).FirstOrDefaultAsync();

			if (article == null)
				return null;

			return article.Id;
		}

		public async Task<Article> FindArticleWithAuthorCategory(int? id)
		{
			return await _dbContext.Articles.Include(a => a.Author).Include(a => a.Category).FirstOrDefaultAsync(a => a.Id == id);
		}
	}
}
