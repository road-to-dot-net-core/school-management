using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results.FailureResult
{
    public class FailureApiResult 
    {
        public IFailureResponse Error { get; }

        public FailureApiResult(IFailureResponse response)
        {
            Error = response;
        }

        public object GetError()
        {
            return new { Error.ErrorCode, Error.ErrorMessage, Error.InnerErrorMessages };
        }
    }
}
