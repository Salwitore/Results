using System.Net;

namespace Data.Results
{
    public class SuccessDataResult<T> : IDataResult<T> where T : class
    {

        public SuccessDataResult(T data)
        {
            IsSuccess = true;
            Data = data;
            Message = "Success";
            StatusCode = HttpStatusCode.OK;
        }

        public SuccessDataResult(T data , string message , HttpStatusCode statusCode)
        {
            IsSuccess= true;
            Data = data;
            Message = message;
            StatusCode = statusCode;
        }

        public T Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
