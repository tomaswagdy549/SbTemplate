using Catalog.Application.Common.Interfaces;
using Catalog.Application.Features.ProductType.Dtos.CreateProductTypeResponse;
using SbTemplate.SharedLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.ProductType.Commands.CreateProductType
{
    public class CreateProductTypeCommandHandler : IGenericResponseRequestHandler<CreateProductTypeCommand, CreateProductTypeResponse>
    {
        public Task<IResponseModel<CreateProductTypeResponse>> Handle(CreateProductTypeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
