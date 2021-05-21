using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Interfaces.Services;
using Blog.UI.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.UI.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize]
	public class UsersController : Controller
	{
		private readonly IUserService _userRepository;

		public UsersController(IUserService userRepository)
		{
			_userRepository = userRepository;
		}
		public async Task<IActionResult> Index()
		{
			var vm = new UsersIndexViewModel
			{
				Users = await _userRepository.GetAll()
			};

			return View(vm);
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View(new AddUserViewModel());
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult> Add(AddUserViewModel vm)
		{
			if (!ModelState.IsValid)
				return View(vm);

			var userDTO = new AddApplicationUserDTO
			{
				Firstname = vm.Firstname,
				Lastname = vm.Lastname,
				Email = vm.Email,
				Password = vm.Password,
				ProfilePhotoUrl = vm.UserImageUrl
			};
			await _userRepository.Add(userDTO);

			TempData["StatusMessage"] = "New user account created successfuly";

			return RedirectToAction(nameof(Add));
		}
	}
}
