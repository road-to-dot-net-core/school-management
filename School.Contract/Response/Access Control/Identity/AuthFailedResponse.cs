using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthFailedResponse : IFailureResponse
    {
        public string ErrorCode => "INVALID_CREDENTIALS";

        public string ErrorMessage => "Authentification failed";

        public List<string> InnerErrorMessages { get; set; }
    }
}
