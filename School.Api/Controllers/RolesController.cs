using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Service.Access_Control;
using Microsoft.AspNetCore.Cors;
using School.Contract.Response.Access_Control.Roles;
using School.Contract.Results;
using School.Contract.Results.MetaResult;
using System;

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
        public IActionResult Get()
        {
            try
            {
                return Ok(
                    _apiResult.CreateSuccessResult(
                        new AllRoleResponse(_roleService.GetAll()), new ResponseMetadata(1000, 10, 51, 23)));
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
          
        }
    }
}
