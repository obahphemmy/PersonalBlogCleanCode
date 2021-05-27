using Blog.ApplicationCore.DTOs;
using Blog.ApplicationCore.Entities;
using Blog.ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.DAL.Services
{
	public class UserService : IUserService
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly RoleManager<IdentityRole> _roleManager;

		public UserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_roleManager = roleManager;
		}

		public async Task<bool> Add(AddApplicationUserDTO vm)
		{
			var user = new ApplicationUser
			{
				Firstname = vm.Firstname,
				Lastname = vm.Lastname,
				Email = vm.Email,
				UserName = vm.Email,
				ProfilePhotoUrl = vm.ProfilePhotoUrl
			};

			var result = await _userManager.CreateAsync(user, vm.Password);

			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, "Moderator");
				return true;
			}
			return false;
		}

		public async Task<ApplicationUserDTO> Find(string id)
		{
			var user = await _userManager.FindByIdAsync(id);
			return new ApplicationUserDTO
			{
				Firstname = user.Firstname,
				Lastname = user.Lastname,
				Email = user.Email,
				ProfilePhotoUrl = user.ProfilePhotoUrl,
				Id = user.Id
			};
		}

		public async Task<IEnumerable<ApplicationUserDTO>> GetAll()
		{
			var users = await _userManager.Users.Select(u => new ApplicationUserDTO
			{
				Firstname = u.Firstname,
				Lastname = u.Lastname,
				Email = u.Email,
				ProfilePhotoUrl = u.ProfilePhotoUrl,
				Id = u.Id
			}).ToListAsync();
			return users;
		}

		public async Task<string> GetCurrentUserId(ClaimsPrincipal principal)
		{
			var user = await _userManager.GetUserAsync(principal);
			return user.Id;
		}

		public async Task<ApplicationUserDTO> GetCurrentUser(ClaimsPrincipal principal)
		{
			var user = await _userManager.GetUserAsync(principal);
			return new ApplicationUserDTO 
			{
				Firstname = user.Firstname,
				Lastname = user.Lastname,
				Email = user.Email,
				ProfilePhotoUrl = user.ProfilePhotoUrl,
				Id = user.Id
			};
		}

		public async Task<bool> Login(AddApplicationUserDTO loginView)
		{
			var result = await _signInManager.PasswordSignInAsync(loginView.Email, loginView.Password, isPersistent: loginView.RememberMe, lockoutOnFailure: true);
			if (result.Succeeded)
				return true;

			return false;
		}

		public async Task Logout()
		{
			await _signInManager.SignOutAsync();
		}

		public async Task<bool> Remove(string id)
		{
			var user = await _userManager.FindByIdAsync(id);
			var result = await _userManager.DeleteAsync(user);

			if (result.Succeeded)
			{
				return true;
			}
			return false;
		}
	}
}
