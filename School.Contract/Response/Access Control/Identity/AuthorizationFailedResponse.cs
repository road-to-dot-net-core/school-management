using School.Contract.ApiResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthorizationFailedResponse : IFailureResponse
    {
        public string ErrorCode => "UNAUTHORIZED";

        public string ErrorMessage => string.Empty;

        public List<string> InnerErrorMessages { get; set; }
    }
}
