using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.Products.Dtos.Products;
using MediatR;

namespace Catalog.Application.Features.Products.Commands.UpdateProductCommand;
public record UpdateProductCommand(Guid id) : IGenericResponseRequest<ProductResponseDto>;
