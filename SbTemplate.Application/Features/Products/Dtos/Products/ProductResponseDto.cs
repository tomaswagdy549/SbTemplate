using SbTemplate.Core.Entities;
namespace Catalog.Application.Features.Products.Dtos.Products;
public record ProductResponseDto
(
    Guid Id, 
    string Name,
    string Description, 
    string ImageFile,
    decimal Price,
    bool IsAvailable
);

