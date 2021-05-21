using Blog.ApplicationCore.Interfaces.Repositories;
using Blog.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected readonly BlogDbContext _dbContext;
		protected DbSet<T> dbSet;

		public Repository(BlogDbContext dbContext)
		{
			_dbContext = dbContext;
			dbSet = _dbContext.Set<T>();
		}
		public async Task Add(T entity)
		{
			await dbSet.AddAsync(entity);
		}

		public async Task<T> Get(Expression<Func<T, bool>> filter, string[] includeChildren = null)
		{
			IQueryable<T> query = dbSet;

			if (includeChildren != null)
			{
				foreach (var child in includeChildren)
				{
					query = query.Include(child);
				}
				return await query.Where(filter).FirstOrDefaultAsync();
			}
			return await query.Where(filter).FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter, string[] includeChildren = null)
		{
			IQueryable<T> query = dbSet;

			if(includeChildren != null)
			{
				foreach (var child in includeChildren)
				{
					query = query.Include(child);
				}
				return await query.Where(filter).ToListAsync();
			}
			return await query.Where(filter).ToListAsync();
		}

		public async Task<IEnumerable<T>> GetAll(int num = 20)
		{
			return await dbSet.ToListAsync();
		}

		public async Task Remove(int id)
		{
			var entity = await dbSet.FindAsync(id);
			dbSet.Remove(entity);
		}
	}
}
