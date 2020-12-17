using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Users;
using School.Service.Access_Control;
using System;
using Microsoft.AspNetCore.Cors;
using School.Contract.ApiResults;
using School.Contract.Response.Access_Control.Menu;
using School.Contract.ApiResults.BusinessOperations.Menu;
using School.Contract.Requests.Access_Control.Permissions;
using School.Contract.Commands.AccessControl.Permissions;
using School.Contract.ApiResults.BusinessOperations;
using School.Contract.Response.Access_Control.Permissions;
using System.Linq;

namespace School.Api.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
   // [AuthorizeAccess("Permissions")]
    public class PermissionsController : Controller
    {
        private readonly IPermissionService _permissionService;
        private readonly IMapper _mapper;
        private readonly HttpContextHelper _httpContextHelper;

        public PermissionsController(IPermissionService permissionService, IMapper mapper, HttpContextHelper httpContextHelper)
        {
            _permissionService = permissionService;
            _mapper = mapper;
            _httpContextHelper = httpContextHelper;
        }



        [HttpPost]
        public IActionResult Post(InsertPermissionRequest req)
        {
            var cmd = _mapper.Map<InsertPermissionCommand>(req);
            bool insertedResult = _permissionService.Insert(cmd);
            if (insertedResult)
                return Ok();
            return StatusCode(500, "Internal server error");
        }


        [HttpGet]
        public IActionResult Get()
        {
            var permissions = _permissionService.GetAll();
           var result = ApiResult<RequestiongPermissionsOperation>.CreateSuccessResponse(new AllPermissionResponse { Permissions = permissions.ToList() });
            return Ok(result);
        }



        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var permission = _permissionService.GetById(id);
            if (permission != null)
            {
                var result = ApiResult<RequestiongPermissionsOperation>.CreateSuccessResponse(permission);
                return Ok(result);
            }
            return NotFound();
        }






    }
}
