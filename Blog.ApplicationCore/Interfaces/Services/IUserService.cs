using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Services
{
	public interface IUserService
	{
		Task<IEnumerable<ApplicationUserDTO>> GetAll();
		Task<ApplicationUserDTO> Find(string id);
		Task<bool> Add(AddApplicationUserDTO vm);
		Task<bool> Remove(string id);
		Task<string> GetCurrentUserId(ClaimsPrincipal user);
		Task<bool> Login(AddApplicationUserDTO vm);
		Task Logout();
	}
}
