using App.Infrastructure;
using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.Products.Commands.UpdateProduct;
using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Catalog.Infrastructure.Repositories.GenericRepository.Add;
using Catalog.Infrastructure.Repositories.GenericRepository.GetById;
using Catalog.Infrastructure.Repositories.GenericRepository.Update;
using Catalog.Infrastructure.Repositories.Products;
using Catalog.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SbTemplate.SharedLayer.Interfaces;

namespace Catalog.Infrastructure;
public static class InfrastructureDependancyInjection
{
    public static IServiceCollection AddCatalogInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer("Server=.;Database=YourDatabaseName;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True");
        });

        services.AddHttpContextAccessor();
        services.AddScoped<AbstractUpdateProductProcessor, UpdateProductProcessor>();
        services.AddScoped(typeof(IGetById<>), typeof(ConcreteGetById<>));
        services.AddScoped(typeof(IAdd<>), typeof(ConcreteAdd<>));
        services.AddScoped(typeof(IUpdate<>), typeof(ConcreteUpdate<>));
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
        return services;
    }
}