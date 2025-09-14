using Catalog.Core.Entities;
using Catalog.Core.Interfaces.GenericRepositoryInterface;
using SbTemplate.Core.Entities.BaseEntity;

namespace Catalog.Application.Features.Products.Commands.UpdateProduct
{
    public abstract class AbstractUpdateProductProcessor
    {
        public IGetById<Product> GetProductByIdProcessor { get; set; }
        public IUpdate<Product> UpdateProductProcessor { get; set; }
    }
}
