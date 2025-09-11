using MediatR;
using SbTemplate.SharedLayer.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Common.Interfaces
{
    interface IGenericResponseRequest<TResponse>:IRequest<IResponseModel<TResponse>>
    {
    }
}
