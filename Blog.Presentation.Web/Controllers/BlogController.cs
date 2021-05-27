using Blog.ApplicationCore.Interfaces.Services;
using Blog.Presentation.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Presentation.Web.Controllers
{
	public class BlogController : Controller
    {
		protected readonly IArticleService _articleService;
		private readonly ICategoryService _categoryService;
		private readonly IUserService _userService;

		public BlogController(IArticleService articleService, ICategoryService categoryService, IUserService userService)
        {
			_articleService = articleService;
			_categoryService = categoryService;
			_userService = userService;
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

            // var user = await _userService.GetCurrentUser(User);

            //var comment = new CommentViewModel
            //{
            //    CommentAuthor = $"{user.Firstname} {user.Lastname}",
            //    CommentAuthorEmail = user.Email,
            //    CommentAuthorId = user.Id,
            //    ArticleId = article.Id
            //};

            var article = await _articleService.GetArticleById(id);

            var vm = new ArticleViewModel
            {
                Article = article,
                Previous = await _articleService.GetPreviousArticleId(article.Id),
                Next = await _articleService.GetNextArticleId(article.Id),
                RelatedArticles = _articleService.GetRelatedArticles(article.Category),
                Comment = new CommentViewModel()
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
