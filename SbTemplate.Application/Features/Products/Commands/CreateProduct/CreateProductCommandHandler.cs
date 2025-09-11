using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.Products.Dtos.Products;
using Mapster;
using Microsoft.Extensions.Logging;
using SbTemplate.SharedLayer.ResponseModel;

namespace Catalog.Application.Features.Products.Commands.CreateProductCommand;
public class CreateProductCommandHandler
    : IGenericResponseRequestHandler<CreateProductCommand, ProductResponseDto>
{
    //private readonly IProductRepository _productRepository;
    //private readonly IMapper _mapper;
    private readonly ILogger<CreateProductCommandHandler> _logger;
    private readonly IResponseModel<ProductResponseDto> _responseModel;

    public CreateProductCommandHandler()
    {
    }

    public Task<IResponseModel<ProductResponseDto>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
 

    //public async Task<ProductResponseDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    //{
    //    var product = _mapper.Map<Product>(request);

    //    var newProduct = await _productRepository.CreateProduct(product, cancellationToken);

    //    var productResponse = _mapper.Map<ProductResponseDto>(newProduct);

    //    return productResponse;
    //}
}
