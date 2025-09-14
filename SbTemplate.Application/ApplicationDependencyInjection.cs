using Catalog.Application.Behaviours.UnitOfWorkPipeLineBehaviour;
using Catalog.Application.Features.Products.MappingProfile;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Application;
public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddCatalogServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(typeof(ProductMappingProfile).Assembly);
            cfg.AddOpenBehavior(typeof(UnitOfWorkPipeLineBehaviour<,>), serviceLifetime: ServiceLifetime.Scoped);
        }
        );

        return services;
    }
}