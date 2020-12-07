using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.ApiResults.BusinessOperations
{
    public class AuthorizationOperation : IBusinessOperation
    {
        public string OperationName => "Authorization";

        public string OperationFailureMessage => "Authorization failed";

    }
}
