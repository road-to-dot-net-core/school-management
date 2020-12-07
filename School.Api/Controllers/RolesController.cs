using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Service.Access_Control;
using Microsoft.AspNetCore.Cors;
using School.Contract.ApiResults;
using School.Contract.ApiResults.BusinessOperations.Roles;
using School.Contract.Response.Access_Control.Roles;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class RolesController : Controller
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        //  [Route(ApiRoutes.Roles.GetAll)]
        [AuthorizeAccess("GetAllRoles")]
        public IActionResult Get()
        {
            var result = ApiResult<RequestingRolesOperation>.CreateResult();
            var roles = _roleService.GetAll();
            var apiResult = result.Success(new AllRoleResponse { Roles=roles});

            return Ok(apiResult);

        }



    }
}
