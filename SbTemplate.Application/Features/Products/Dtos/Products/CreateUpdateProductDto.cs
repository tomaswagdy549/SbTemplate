
namespace Catalog.Application.Features.Products.Dtos.Products;
public class CreateUpdateProductDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageFile { get; set; }

    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }

}
