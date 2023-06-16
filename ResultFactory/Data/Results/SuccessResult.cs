using System.Net;

namespace Data.Results
{
    public class SuccessResult : IResult
    {
        public SuccessResult()
        {
            IsSuccess = true;
            Message = "Success";
            StatusCode = HttpStatusCode.OK;
        }

        public SuccessResult(string message,HttpStatusCode statusCode)
        {
            IsSuccess = true;
            Message = message; 
            StatusCode = statusCode;
        }


        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
