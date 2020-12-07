using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.ApiResults.BusinessOperations
{
    public interface IBusinessOperation
    {
        string OperationName { get; }
        string OperationFailureMessage { get; }
    }
}
