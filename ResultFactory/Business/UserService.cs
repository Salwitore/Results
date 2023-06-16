using Data.Context;
using Data.Model;
using Data.Results;
using Data.Results.Factory;
using System.Net;

namespace Business
{
    public class UserService
    {
        private readonly ResultCreater resultCreater;
        private StaticDB DB;


        public UserService(ResultCreater resultCreater)
        {
            this.resultCreater = resultCreater;
            this.DB = new StaticDB();
        }



        public IDataResult<User> GetUser(int userId) 
        {
            try
            {
                var user = DB.Database.FirstOrDefault(x => x.Id == userId);

                if (user == null)
                {
                    return resultCreater.CreateDataResult<User>(null,false,"User not found!",HttpStatusCode.BadRequest);
                }
                else
                {
                    return resultCreater.CreateDataResult<User>(user,true);
                }
                
            }
            catch (Exception ex)
            {
                return resultCreater.CreateExceptionResult<User>(ex);
            }
        }

        public IResult ExceptionDeneme()
        {
            try
            {
                throw new NotImplementedException("Deneme");
            }
            catch (Exception ex)
            {
                return resultCreater.CreateExceptionResult(ex);
            }
        }

    }
}