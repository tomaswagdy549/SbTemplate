using Catalog.Core.Interfaces.GenericRepositoryInterface;
using Microsoft.Extensions.DependencyInjection;
using SbTemplate.Core.Entities.BaseEntity;
namespace Catalog.Infrastructure.Repositories.Products;
public class UpdateProductProcessor : Application.Features.Products.Commands.UpdateProduct.AbstractUpdateProductProcessor
{

    public UpdateProductProcessor(IServiceProvider serviceProvider)
    {
        var GetById = serviceProvider.GetRequiredService<IGetById<Product>>();
        this.GetProductByIdProcessor = GetById;
        var Update = serviceProvider.GetRequiredService<IUpdate<Product>>();
        this.UpdateProductProcessor = Update;
    }

}
