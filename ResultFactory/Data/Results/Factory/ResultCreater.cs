using System.Net;

namespace Data.Results.Factory
{
    public class ResultCreater 
    {
        public IResult CreateResult(bool isSuccess)
        {
            return isSuccess ? new SuccessResult() : new ErrorResult();
        }

        public IResult CreateResult(bool isSuccess , string message , HttpStatusCode statusCode)
        {
            return isSuccess ? new SuccessResult(message,statusCode) : new ErrorResult(message,statusCode);
        }

        public IDataResult<T> CreateDataResult<T>(T data , bool isSuccess) where T : class
        {
            return isSuccess ? new SuccessDataResult<T>(data) : new ErrorDataResult<T>(data);
        }

        public IDataResult<T> CreateDataResult<T>(T data , bool isSuccess , string message , HttpStatusCode statusCode)  where T : class
        { 
            return isSuccess ? new SuccessDataResult<T>(data,message,statusCode) : new ErrorDataResult<T>(data,message ,statusCode);
        }

        public IDataResult<T> CreateExceptionResult<T>(Exception ex) where T : class 
        {
            return new ErrorDataResult<T>(null, ex.Message, HttpStatusCode.InternalServerError);
        }

        public IResult CreateExceptionResult(Exception ex)
        {
            return new ErrorResult(ex.Message, HttpStatusCode.InternalServerError);
        }

    }
}
