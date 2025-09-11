using Catalog.Application.Features.Products.Dtos.Products;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.Features.Products.Commands.UpdateProductCommand;
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ProductResponseDto>
{
    private readonly ILogger<UpdateProductCommandHandler> _logger;

    public UpdateProductCommandHandler(ILogger<UpdateProductCommandHandler> logger)
    {
        _logger = logger;
    }

    public Task<ProductResponseDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
