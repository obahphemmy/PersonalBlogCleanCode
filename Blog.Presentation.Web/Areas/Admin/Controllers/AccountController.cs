using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Interfaces.Services;
using Blog.Presentation.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Presentation.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AccountController : Controller
	{
		private readonly IUserService _userService;

		public AccountController(IUserService userService)
		{
			_userService = userService;
		}
		[HttpGet]
		public IActionResult Index(string ReturnUrl = null)
		{
			ViewData["ReturnUrl"] = ReturnUrl;
			return View(new LoginViewModel());
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Index(LoginViewModel model, string ReturnUrl)
		{
			if (!ModelState.IsValid)
				return View(model);

			var result = await _userService.Login(new AddApplicationUserDTO { Email = model.Email, Password = model.Password, RememberMe = model.RememberMe });

			if (result == true)
			{
				if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
					return Redirect(ReturnUrl);
				else
					return RedirectToAction("index", "dashboard", new { area = "admin" });
			}

			ModelState.AddModelError("", "Invalid login details");
			return View(model);
		}

		public async Task<IActionResult> LogoutAsync()
		{
			await _userService.Logout();
			return RedirectToAction("index", "account", new { area = "admin" });
		}
	}
}
