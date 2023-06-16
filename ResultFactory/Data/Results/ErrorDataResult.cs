using System.Net;

namespace Data.Results
{
    public class ErrorDataResult<T> : IDataResult<T> where T : class
    {
        public ErrorDataResult(T data)
        {
            IsSuccess = false;
            Data = data;
            Message = "Error!";
            StatusCode = HttpStatusCode.InternalServerError;
        }
        
        public ErrorDataResult(T data , string message , HttpStatusCode statusCode)
        {
            IsSuccess=false;
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
