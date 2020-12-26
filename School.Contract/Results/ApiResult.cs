using PagedList;
using School.Contract.Results.FailureResult;
using School.Contract.Results.MetaResult;
using School.Contract.Results.SuccessResults;
using System;
using System.Linq;


namespace School.Contract.Results
{
    public class ApiResult : IApiResult
    {
        public object CreateSuccessResult(ISuccessResponse response)
        {
            return new SuccessResult(response);
        }

        public object CreateSuccessPageListResult<T>(PagedList<T> response) where T : ISuccessResponse
        {
            return new SuccessWithMetadataResult<T>(response);
        }

        public object CreateFailureResult(string message)
        {
            return new FailureApiResult(new TechnicalFailureResponse(message)).GetError();
        }

        public object CreateFailureResult(IFailureResponse response)
        {
            return new FailureApiResult(response).GetError();
        }

        public object CreateFailureResult(Exception ex)
        {
            return new TechnicalFailureResponse(ex);
        }

      
    }
}
