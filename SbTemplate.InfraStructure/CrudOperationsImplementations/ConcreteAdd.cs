using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories.GenericRepository.Add
{
    public class ConcreteAdd<T> : IAdd<T> where T : class
    {
        readonly DbSet<T> _dbSet;
        public ConcreteAdd(DbContext ApplicationDbContext)
        {
            _dbSet = ApplicationDbContext.Set<T>();
        }
        async Task<T> IAdd<T>.AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }
    }
}
