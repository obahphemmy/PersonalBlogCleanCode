using Blog.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Repositories
{
	public interface IArticleRepository : IRepository<Article>
	{
		ICollection<Article> GetArticlesByCategoryName(string catName);
		Task<IEnumerable<Article>> GetArticlesWithAuthorCategory(int count);
		Task<Article> FindArticleWithAuthorCategory(int? id);
		Task<int?> GetNextArticleId(int? currentId);
		Task<int?> GetPreviousArticleId(int? currentId);

	}
}