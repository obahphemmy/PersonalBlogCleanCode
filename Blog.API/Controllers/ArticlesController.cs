using Blog.API.DTOs;
using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.API.Controllers
{
	[ApiController]
	[Route("api/articles")]
	public class ArticlesController : ControllerBase
	{
		private readonly IArticleService _articleService;

		public ArticlesController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		[HttpGet]
		[Route("")]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await _articleService.GetArticles());
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			if (id == 0)
				return NotFound("Invalid id parameter!");
			
			var article = await _articleService.GetArticleById(id);

			if (article.Id == 0)
				return NotFound("Article not found!");

			return Ok(article);
		}

		[HttpGet]
		[Route("{category}")]
		public IActionResult GetByCategoryName(string category)
		{
			if (category == string.Empty)
				return NotFound("Invalid parameter!");

			var articles = _articleService.GetRelatedArticles(category, 20);

			if (articles == null)
				return NotFound("Article not found!");

			return Ok(articles);
		}

		[HttpPost]
		[Route("/articles")]
		public async Task<IActionResult> Create([FromBody] AddArticleVM item)
		{
			if (item == null || !ModelState.IsValid)
			{
				return BadRequest();
			}

			var articleDto = new AddArticleDTO
			{
				Title = item.Title,
				Body = item.Body,
				ArticleImageUrl = item.PostImageUrl,
				AuthorId = item.AuthorId,
				CategoryId = item.CategoryId
			};

			int articleId = await _articleService.Add(articleDto);

			return CreatedAtAction(nameof(GetById), new { Id = articleId }, item);
		}
	}
}
