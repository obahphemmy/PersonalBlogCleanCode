using Blog.ApplicationCore.Interfaces.Services;
using Blog.UI.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.UI.Web.Controllers
{
	public class BlogController : Controller
    {
		private readonly IArticleService _articleService;
		private readonly ICategoryService _categoryService;

		public BlogController(IArticleService articleService, ICategoryService categoryService)
        {
			_articleService = articleService;
			_categoryService = categoryService;
		}

        public async Task<IActionResult> IndexAsync()
        {
            var articles = await _articleService.GetArticles(15);
            var categories = await _categoryService.GetAll();

            var vm = new IndexViewModel
            {
                SliderArticles = articles.Take(3),
                BodyArticles = articles.Take(9).Skip(3),
                Categories = categories
            };

            return View(vm);
        }

        // GET: /blog/article/{id}
        public async Task<IActionResult> ArticleAsync(int? id)        
        {
            if (id == null)
                return NotFound();

            var article = await _articleService.GetArticleById(id);
            var vm = new ArticleViewModel
            {
                Article = article,
                Previous = await _articleService.GetPreviousArticleId(article.Id),
                Next = await _articleService.GetNextArticleId(article.Id),
                RelatedArticles = await _articleService.GetRelatedArticles(article.Category)
            };

            return View(vm);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Photo()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
 
    }
}
