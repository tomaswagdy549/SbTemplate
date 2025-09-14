using Catalog.Core.Entities;
using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories.GenericRepository.GetAll
{
    public class ConcreteGetAll<T> : IGetAll<T> where T : class
    {
        readonly DbSet<T> _dbSet;
        public ConcreteGetAll(DbContext ApplicationDbContext)
        {
            _dbSet = ApplicationDbContext.Set<T>();
        }
        PaginationGenericResult<IQueryable<T>> IGetAll<T>.GetAll(int pageNumber, int pageSize, bool asNoTracking = true)
        {
            var query = asNoTracking ? _dbSet.AsNoTracking() : _dbSet;
            var result = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            var count = query.Count();
            var paginationResult = new PaginationGenericResult<IQueryable<T>>()
            {
                Data = result,
                TotalCount = count,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return paginationResult;
        }
    }
}
