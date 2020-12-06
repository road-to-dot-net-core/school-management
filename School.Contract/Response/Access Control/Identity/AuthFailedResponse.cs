using School.Contract.ApiResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthFailedResponse : IFailureResponse
    {
        public string ErrorCode => "INVALID_CREDENTIALS";

        public string ErrorMessage => string.Empty;

        public List<string> InnerErrorMessages { get; set; }
    }
}
