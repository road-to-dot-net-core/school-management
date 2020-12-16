using School.Contract.Results.MetaResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results
{
    public interface IApiResult
    {
        object CreateSuccessResult(ISuccessResponse response);
        object CreateSuccessResult(ISuccessResponse response, ResponseMetadata responseMetadata);
        object CreateFailureResult(string message);
        object CreateFailureResult(IFailureResponse response);
        object CreateFailureResult(Exception ex);
    }
}
