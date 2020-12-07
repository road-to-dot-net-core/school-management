using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.ApiResults.BusinessOperations.Menu
{
    public class NavigationMenuOperation : IBusinessOperation
    {
        public string OperationName => "GettingMenu";

        public string OperationFailureMessage => "Getting Menu failed";

    }
}
