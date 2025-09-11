using MediatR;
using SbTemplate.SharedLayer.ResponseModel;

namespace Catalog.Application.Common.Interfaces
{
    interface IGenericResponseRequestHandler<TRequest,TResponse> : IRequestHandler<TRequest, IResponseModel<TResponse>>
        where TRequest : IGenericResponseRequest<TResponse>
    {
    }
}
