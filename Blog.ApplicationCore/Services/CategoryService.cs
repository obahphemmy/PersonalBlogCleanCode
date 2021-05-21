using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly static Random random = new Random();

		public CategoryService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<bool> Add(CategoryDTO entity)
		{
			var category = new Category 
			{
				CategoryName = entity.CategoryName,
				Description = entity.Description,
				CategoryImageUrl = GetImageUrl()
			};
			await _unitOfWork.Categories.Add(category);
			await _unitOfWork.Complete();

			return true;
		}

		public async Task<CategoryDTO> Find(int id)
		{
			var result = await _unitOfWork.Categories.Get(a => a.Id == id);
			return new CategoryDTO
			{
				CategoryName = result.CategoryName,
				Description = result.Description
			};
		}

		public async Task<IEnumerable<CategoryDTO>> GetAll(int num = 20)
		{
			var categories = await _unitOfWork.Categories.GetAll(num);
			return categories.Select(c => new CategoryDTO
			{
				Id = c.Id,
				CategoryName = c.CategoryName,
				Description = c.Description,
				NumberOfArticles = GetNumArticlesAsync(c.CategoryName),
				CategoryImageUrl = c.CategoryImageUrl
			}).ToList();
		}

		public async Task Remove(int id)
		{
			await _unitOfWork.Categories.Remove(id);
			await _unitOfWork.Complete();
		}

		private int GetNumArticlesAsync(string category)
		{
			var articles = _unitOfWork.Articles.GetArticlesByCategoryName(category);
			int numOfArticles = articles.Count;
			return numOfArticles;
		}

		private static string GetImageUrl()
		{
			int randomNumber = random.Next(30, 100);
			return $"https://loremflickr.com/320/320?lock={randomNumber}";
		}
	}
}
