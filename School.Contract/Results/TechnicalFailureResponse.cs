using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Results
{
    public class TechnicalFailureResponse : IFailureResponse
    {
        public string ErrorCode => "SERVER_ERROR";
        public string ErrorMessage { get; }
        public List<string> InnerErrorMessages { get; set; }

        public TechnicalFailureResponse(string errorMessage)
        {
            InnerErrorMessages = new List<string>();
            ErrorMessage = errorMessage;
        }
        public TechnicalFailureResponse(Exception exception) : this(exception.Message)
        {
            if (exception.InnerException != null)
                InnerErrorMessages.Add(exception.InnerException.Message);
        }
    }
}
