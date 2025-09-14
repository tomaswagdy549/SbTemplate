using Catalog.Core.Entities;
using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Microsoft.EntityFrameworkCore;
using SbTemplate.Core.Entities.BaseEntity;

namespace Catalog.Infrastructure.Repositories.GenericRepository.GetById
{
    public class ConcreteGetById<T> : IGetById<T> where T : BaseEntity
    {
        readonly DbSet<T> _dbSet;
        public ConcreteGetById(DbContext ApplicationDbContext)
        {
            _dbSet = ApplicationDbContext.Set<T>();
        }
        public Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _dbSet.SingleAsync(t => t.Id == id, cancellationToken);
        }
    }
}
