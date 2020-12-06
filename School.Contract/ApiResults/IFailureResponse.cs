using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.ApiResults
{
    public interface IFailureResponse
    {
        string ErrorCode { get; }
        string ErrorMessage { get; }
        List<string> InnerErrorMessages { get; set; }
    }
}
