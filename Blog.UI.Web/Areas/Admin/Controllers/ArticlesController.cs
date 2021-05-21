using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.ApplicationCore.Interfaces.Services;
using Blog.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleBlog.Areas.Admin.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class ArticlesController : Controller
	{
		private readonly IUserService _userService;
		private readonly IArticleService _articleService;
		private readonly IRepository<Category> _categoryRepository;

		public ArticlesController(IUserService userService, IArticleService articleService, IRepository<Category> repository)
		{
			_userService = userService;
			_articleService = articleService;
			_categoryRepository = repository;
		}
		public async Task<IActionResult> IndexAsync()
		{
			var vm = new ArticleIndexViewModel
			{
				Articles = await _articleService.GetArticles()
			};
			return View(vm);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var vm = new AddArticleViewModel
			{
				Categories = await GetUICategories(),
				AuthorId = await _userService.GetCurrentUserId(User)
			};
			return View(vm);
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddArticleViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				viewModel.Categories = await GetUICategories();
				return View(viewModel);
			}

			var articleDto = new ArticleDTO 
			{
				Title = viewModel.Title,
				Body = viewModel.Body,
				ArticleImageUrl = viewModel.PostImageUrl,
				AuthorId = viewModel.AuthorId,
				CategoryId = viewModel.CategoryId
			};
			await _articleService.Add(articleDto);

			TempData["StatusMessage"] = "New article added successfully!";

			return RedirectToAction(nameof(Add));
		}

		[NonAction]
		public async Task<IEnumerable<SelectListItem>> GetUICategories()
		{
			var categories = await _categoryRepository.GetAll();
			return categories.Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.CategoryName });
		}
	}
}
