using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Service.Access_Control;
using Microsoft.AspNetCore.Cors;
using School.Contract.Response.Access_Control.Roles;
using School.Contract.Results;
using School.Contract.Results.MetaResult;
using System;
using School.Contract.Response.Roles;
using School.Contract.Requests.Access_Control.Roles;
using Schools.Domain.Models.Access_Control;
using System.Collections.Generic;
using School.Contract.QueryParameters;
using System.Linq;
using PagedList;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class RolesController : BaseController
    {
        private readonly IRoleService _roleService;
        private readonly IApiResult _apiResult;
        public RolesController(IRoleService roleService, IApiResult apiResult) : base(apiResult)
        {
            _roleService = roleService;
            _apiResult = apiResult;
        }

        [HttpGet]
        // [Route(ApiRoutes.Roles.GetAll)]
        //[AuthorizeAccess("GetAllRoles")]
        public IActionResult Get([FromQuery] QueryParameters queryParameters)
        {
            try
            {
                var result = _roleService.GetAll(queryParameters);
                return Ok(_apiResult.CreateSuccessPageListResult<RoleResponse>(result));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IActionResult Register(RegisterRoleRequest request)
        {
            try
            {
                var response = _roleService.Register(new Role(request.Name, request.Description, request.Permissions));
                return Ok(_apiResult.CreateSuccessResult(response));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
