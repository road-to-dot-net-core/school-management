using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Permissions;
using School.Contract.Results;
using School.Service.Access_Control;

namespace School.Api.Controllers
{

    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionService _permissionService;
        private readonly IApiResult _apiResult;

        public PermissionsController(IPermissionService permissionService, IApiResult apiResult)
        {
            _permissionService = permissionService;
            _apiResult = apiResult;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] QueryParameters queryParameters)
        {
            return Ok(_apiResult
                    .CreateSuccessPageListResult<PermissionResponse>(_permissionService.GetAll(queryParameters)));
        }
    }
}