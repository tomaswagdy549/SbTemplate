using Catalog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using SbTemplate.Core.Entities.BaseEntity;
namespace App.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(builder);
        }
        public DbSet<Product> products { get; set; }
    }
}