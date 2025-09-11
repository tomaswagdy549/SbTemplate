using Catalog.Application.Features.Products.Dtos.Brands;
using Catalog.Application.Features.Products.Queries.GetAll;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Catalog.Application.Features.Products.Queries.GetAllBrands;
public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQuery, List<BrandResponseDto>>
{
    private readonly ILogger<GetAllBrandsQueryHandler> _logger;
    public GetAllBrandsQueryHandler(ILogger<GetAllBrandsQueryHandler> logger)
    {
        _logger = logger;
    }

    public Task<List<BrandResponseDto>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
