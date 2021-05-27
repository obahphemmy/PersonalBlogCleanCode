using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Services
{
	public interface IArticleService
	{
		Task<IEnumerable<ArticleDTO>> GetArticles(int count = 20);
		Task<ArticleDTO> GetArticleById(int? id);
		Task<int> Add(AddArticleDTO entity);
		Task Remove(int id);
		IEnumerable<ArticleDTO> GetRelatedArticles(string cat, int count = 2);
		IEnumerable<ArticleDTO> GetArticlesByCategoryName(string cat, int count = 20);
		Task<int?> GetNextArticleId(int? currentId);
		Task<int?> GetPreviousArticleId(int? currentId); 
	}
}
