using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Interfaces.Services;
using Blog.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleBlog.Areas.Admin.ViewModels;
using System.Threading.Tasks;

namespace Blog.UI.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		public async Task<IActionResult> Index()
		{
			var vm = new CategoryIndexViewModel
			{
				Categories = await _categoryService.GetAll()
			};	
			return View(vm);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View(new AddCategoryViewModel());
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Add(AddCategoryViewModel vm)
		{
			if (!ModelState.IsValid)
				return View(vm);

			var result = await _categoryService.Add(new CategoryDTO { CategoryName = vm.Name, Description = vm.Description});

			if (result)
			{
				TempData["StatusMessage"] = "New category added successfully!";
				return RedirectToAction(nameof(Add));
			}

			ModelState.AddModelError("", $"{vm.Name} category has already been added");

			return View(vm);
		}
	}
}
