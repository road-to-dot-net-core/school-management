using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.ApiResults.BusinessOperations
{
    public class AuthenticationOperation : IBusinessOperation
    {
        public string OperationName => "Authentication";

        public string OperationFailureMessage => "Authentication failed";

    }
}
