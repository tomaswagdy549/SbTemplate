using Catalog.Application.Features.Products.Dtos.Products;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.Features.Products.Queries.GetAllProductsQuery;
public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IList<ProductResponseDto>>
{
    private readonly ILogger<GetAllProductsQueryHandler> _logger;

    public GetAllProductsQueryHandler( ILogger<GetAllProductsQueryHandler> logger)
    {
        _logger = logger;
    }

    public Task<IList<ProductResponseDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
