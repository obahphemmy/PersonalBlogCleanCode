using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.ApplicationCore.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Services
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitOfWork _unitOfWork;

		public ArticleService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<int> Add(AddArticleDTO vm)
		{
			var article = new Article
			{
				Title = vm.Title,
				Body = vm.Body,
				CategoryId = vm.CategoryId,
				AuthorId = vm.AuthorId,
				ArticleImageUrl = vm.ArticleImageUrl
			};

			await _unitOfWork.Articles.Add(article);
			await _unitOfWork.Complete();

			return article.Id;
		}

		public async Task<ArticleDTO> GetArticleById(int? id)
		{
			return Map(await _unitOfWork.Articles.FindArticleWithAuthorCategory(id));
		}

		public async Task<IEnumerable<ArticleDTO>> GetArticles(int count = 20)
		{
			var articles = await _unitOfWork.Articles.GetArticlesWithAuthorCategory(count);
			return articles.Select(a => Map(a)).ToList();
		}

		public async Task<int?> GetNextArticleId(int? currentId)
		{
			return await _unitOfWork.Articles.GetNextArticleId(currentId);
		}

		public async Task<int?> GetPreviousArticleId(int? currentId)
		{
			return await _unitOfWork.Articles.GetPreviousArticleId(currentId);
		}

		public IEnumerable<ArticleDTO> GetRelatedArticles(string cat, int count = 2)
		{
			var articles = _unitOfWork.Articles.GetArticlesByCategoryName(cat);
			return articles.Select(a => new ArticleDTO { Id = a.Id, Title = a.Title, ArticleImageUrl = a.ArticleImageUrl }).Take(count).ToList();
		}

		public IEnumerable<ArticleDTO> GetArticlesByCategoryName(string cat, int count = 20)
		{
			var articles = _unitOfWork.Articles.GetArticlesByCategoryName(cat);
			return articles.Select(a => Map(a)).Take(count).ToList();
		}

		public async Task Remove(int id)
		{
			await _unitOfWork.Articles.Remove(id);
			await _unitOfWork.Complete();

		}

		private static ArticleDTO Map(Article article)
		{
			if (article == null)
				return new ArticleDTO();

			return new ArticleDTO
			{
				Id = article.Id,
				Title = article.Title,
				Body = article.Body,
				Category = article.Category.CategoryName,
				Author = $"{article.Author.Firstname} {article.Author.Lastname}",
				ArthorImageUrl = article.Author.ProfilePhotoUrl,
				ArticleImageUrl = article.ArticleImageUrl,
				ArticleDate = article.CreatedDate.ToString("dddd, dd MMMM, yyyy")
			};
		}
	}
}
