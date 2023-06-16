using System.Net;

namespace Data.Results
{
    public interface IResult
    {
        string Message { get; set; }
        bool IsSuccess { get; set; }
        HttpStatusCode StatusCode { get; set; }
    }
}
