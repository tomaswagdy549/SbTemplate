using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SbTemplate.SharedLayer.ResponseModel
{
    public interface IResponseModel<T>
    {
        HttpStatusCode StatusCode { get; set; }
        DateTime Timestamp { get; set; }
        bool IsError { get; set; }
        string Message { get; set; }
        T Result { get; set; }
        ResponseModel<T> Success(HttpStatusCode StatusCode, string Message, T Data);
        ResponseModel<T> Failure(HttpStatusCode StatusCode, string Message, T Data);
    }
}
