
using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthorizationFailedResponse : IFailureResponse
    {
        public string ErrorCode => "UNAUTHORIZED";

        public string ErrorMessage => "Authorisation failed";

        public List<string> InnerErrorMessages { get; set; }
    }
}
