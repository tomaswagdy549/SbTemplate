using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.Products.Commands.UpdateProduct;
using Catalog.Application.Features.Products.Dtos.Products;
using MediatR;
using Microsoft.Extensions.Logging;
using SbTemplate.SharedLayer.ResponseModel;

namespace Catalog.Application.Features.Products.Commands.UpdateProductCommand;
public class UpdateProductCommandHandler : IGenericResponseRequestHandler<UpdateProductCommand, ProductResponseDto>
{
    private readonly ILogger<UpdateProductCommandHandler> _logger;
    private readonly AbstractUpdateProductProcessor _updateProductProcessor;
    private readonly IResponseModel<ProductResponseDto> _responseModel;

    public UpdateProductCommandHandler(IResponseModel<ProductResponseDto> responseModel, ILogger<UpdateProductCommandHandler> logger, AbstractUpdateProductProcessor updateProductProcessor)
    {
        _logger = logger;
        _updateProductProcessor = updateProductProcessor;
        _responseModel = responseModel;
    }

    public async Task<IResponseModel<ProductResponseDto>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _updateProductProcessor.GetProductByIdProcessor.GetByIdAsync(request.id, cancellationToken);
        if (product == null)
        {
            _logger.LogError("Product with id {ProductId} not found", request.id);
            return _responseModel.Failure(System.Net.HttpStatusCode.NotFound,$"Product not found", null);
        }
        product = _updateProductProcessor.UpdateProductProcessor.Update(product,cancellationToken);
        return _responseModel.Success(System.Net.HttpStatusCode.OK, "Product updated successfully",
            new ProductResponseDto
            (product.Id,
            product.Name,
            product.Description,
            product.Name,
            product.Price,
            true));
    }

    //public async Task<ProductResponseDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    //{
    //    var product = await _updateProductProcessor.GetProductByIdProcessor.GetByIdAsync(request.id, cancellationToken);
    //    if (product == null)
    //    {
    //        _logger.LogError("Product with id {ProductId} not found", request.id);
    //        throw new KeyNotFoundException($"Product with id {request.id} not found");
    //    }
    //}

}
