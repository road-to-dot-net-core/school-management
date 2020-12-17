using School.Contract.Results.FailureResult;
using School.Contract.Results.MetaResult;
using School.Contract.Results.SuccessResults;
using System;

namespace School.Contract.Results
{
    public class ApiResult : IApiResult
    {
        public object CreateSuccessResult(ISuccessResponse response)
        {
            return new SuccessResult(response);
        }

        public  object CreateSuccessResult(ISuccessResponse response, ResponseMetadata responseMetadata)
        {
            return new SuccessWithMetadataResult(response, responseMetadata);
        }

        public  object CreateFailureResult(string message)
        {
            return new FailureApiResult(new TechnicalFailureResponse(message)).GetError();
        }

        public  object CreateFailureResult(IFailureResponse response)
        {
            return new FailureApiResult(response).GetError();
        }

        public  object CreateFailureResult(Exception ex)
        {
            return new TechnicalFailureResponse(ex);
        }

    }
}
