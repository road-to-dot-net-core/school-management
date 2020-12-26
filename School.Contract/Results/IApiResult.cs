using PagedList;
using School.Contract.Results.MetaResult;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results
{
    public interface IApiResult
    {
        object CreateSuccessResult(ISuccessResponse response);
        object CreateSuccessPageListResult<T>(PagedList<T> response) where T : ISuccessResponse;
        object CreateFailureResult(string message);
        object CreateFailureResult(IFailureResponse response);
        object CreateFailureResult(Exception ex);
    }
}
