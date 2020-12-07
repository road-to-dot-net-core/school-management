using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace School.Contract.ApiResults
{
    public class TechnicalFailureResponse : IFailureResponse
    {
        public string ErrorCode => "SERVER_ERROR";
        public string ErrorMessage { get; }
        public List<string> InnerErrorMessages { get; set; }

        public TechnicalFailureResponse(Exception exception)
        {
            ErrorMessage = exception.Message;
            if (exception.InnerException != null)
                InnerErrorMessages.Add(exception.InnerException.Message);
        }
    }
}
