using Blog.API.DTOs;
using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.API.Controllers
{
	[Route("api/[controller]")]
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		[Route("")]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await _categoryService.GetAll());
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetByIdAsync(int id)
		{
			if (id == 0)
				return BadRequest();

			return Ok(await _categoryService.Find(id));
		}

		[HttpPost]
		[Route("")]
		public async Task<IActionResult> Add(AddCategoryDTO vm)
		{
			if (!ModelState.IsValid)
				return BadRequest(vm);

			var result = await _categoryService.Add(new CategoryDTO { CategoryName = vm.Name, Description = vm.Description});

			if (result)
			{
				return CreatedAtAction(nameof(Add), vm);
			}

			return BadRequest($"{vm.Name} category has already been added");
		}
	}
}
