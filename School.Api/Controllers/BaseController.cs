using Microsoft.AspNetCore.Mvc;
using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    public class BaseController : Controller
    {
        private readonly IApiResult _apiResult;
        public BaseController(IApiResult apiResult)
        {
            _apiResult = apiResult;
        }
        public ObjectResult InternalServerError(Exception exception = null)
        {
            if(exception == null)
            {
               return StatusCode((int)HttpStatusCode.InternalServerError, _apiResult.CreateFailureResult("Unhandled server error"));
            }

            return StatusCode((int)HttpStatusCode.InternalServerError, _apiResult.CreateFailureResult(exception));
        }
    }
}
