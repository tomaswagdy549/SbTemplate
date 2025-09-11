using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SbTemplate.SharedLayer.ResponseModel
{
    public class ResponseModel<T> : IResponseModel<T>
    {
        public HttpStatusCode StatusCode { get ; set ; }
        public DateTime Timestamp { get ; set ; }
        public bool IsError { get ; set ; }
        public string Message { get ; set ; }
        public T Result { get ; set ; } // THIS IS TEST FOR GENERIC TEMPLATE USAGE

        public ResponseModel<T> Failure(HttpStatusCode StatusCode, string Message, T Data)
        {
            Result = Data;
            this.Message = Message;
            this.StatusCode = StatusCode;
            IsError = true;
            return this;
        }

        public ResponseModel<T> Success(HttpStatusCode StatusCode, string Message, T Data)
        {
            Result = Data;
            this.Message = Message;
            this.StatusCode = StatusCode;
            IsError = false;
            return this;
        }
    }
}
