using System.Net;

namespace Data.Results
{
    public class ErrorResult : IResult
    {

        public ErrorResult()
        {
            IsSuccess = false;
            Message = "Error!";
            StatusCode = HttpStatusCode.InternalServerError;
        }

        public ErrorResult(string message , HttpStatusCode statusCode)
        {
            IsSuccess = false;
            Message = message; 
            StatusCode = statusCode;
        }

        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
