using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.ApplicationCore.Interfaces.Repositories
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAll(int num = 20);
		Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, string[] includeChildren = null);
		Task<T> Get(Expression<Func<T, bool>> filter, string[] includeChildren = null);
		Task Add(T entity);
		Task Remove(int id);
	}
}
