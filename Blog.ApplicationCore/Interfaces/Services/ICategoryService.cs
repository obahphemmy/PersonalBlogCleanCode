using Blog.ApplicationCore.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Services
{
	public interface ICategoryService
	{
		Task<IEnumerable<CategoryDTO>> GetAll(int num = 20);
		Task<CategoryDTO> Find(int id);
		Task<bool> Add(CategoryDTO entity);
		Task Remove(int id);
	}
}
