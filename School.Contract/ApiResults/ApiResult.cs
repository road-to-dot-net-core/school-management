using School.Contract.ApiResults.BusinessOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Contract.ApiResults
{
    public class ApiResult<T> where T : IBusinessOperation
    {
       
        private IBusinessOperation _businessOperation;
        public object Result { get; set; }
        public List<IFailureResponse> Errors { get; internal set; }
        public string ErrorTitle { get; internal set; }
        public bool IsOk => !Errors.Any();

        private ApiResult()
        {
            _businessOperation = GetBusinessOperation();
            ErrorTitle = _businessOperation.OperationFailureMessage;
            Errors = new List<IFailureResponse>();
        }
        private ApiResult(List<IFailureResponse> failureResponses) : this()
        {
            Errors = failureResponses;
        }
        private ApiResult(ISuccessResponse responseData) : this()
        {
            Result = responseData;
        }
        public static ApiResult<T> CreateResult()
        {
            return new ApiResult<T>();
        }

        public void AppendErrorResponse(IFailureResponse failureResponse)
        {
            Errors.Add(failureResponse);
        }

        public ApiResult<T> Success(ISuccessResponse responseData)
        {
            Result = responseData;
            Errors.Clear();
            ErrorTitle = string.Empty;
           
            return this;
        }

        public ApiResult<T> Failure()
        {
            Result = null;
            ErrorTitle = _businessOperation.OperationFailureMessage;
            return this;
        }

        public static ApiResult<T> CreateSuccessResponse(ISuccessResponse response)
        {
            return new ApiResult<T>(response);
        }

        public static ApiResult<T> CreateFailureResponse(IFailureResponse failureResponses)
        {
            return new ApiResult<T>(new List<IFailureResponse>() { failureResponses });
        }

        public static ApiResult<T> CreateFailureResponse(Exception exception)
        {
            return new ApiResult<T>(new List<IFailureResponse>() { new TechnicalFailureResponse(exception) });
        }

        private IBusinessOperation GetBusinessOperation()
        {
            var operation = (T)Activator.CreateInstance(typeof(T));
            return operation;
        }

    }
}
