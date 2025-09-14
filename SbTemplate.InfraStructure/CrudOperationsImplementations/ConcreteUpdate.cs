using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories.GenericRepository.Update
{
    public class ConcreteUpdate<T> : IUpdate<T> where T : class
    {
        readonly DbSet<T> _dbSet;
        public ConcreteUpdate(DbContext ApplicationDbContext)
        {
            _dbSet = ApplicationDbContext.Set<T>();
        }

        public T Update(T entity,CancellationToken cancellationToken)
        {
            _dbSet.Update(entity);
            return entity;
        }
    }
}
