using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.ProductType.Dtos.CreateProductTypeResponse;

namespace Catalog.Application.Features.ProductType.Commands.CreateProductType
{
    public record CreateProductTypeCommand(string Name) : IGenericResponseRequest<CreateProductTypeResponse>;
}
