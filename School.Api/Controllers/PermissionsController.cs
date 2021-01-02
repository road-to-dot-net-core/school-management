using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Service.Access_Control;
using System;
using Microsoft.AspNetCore.Cors;
using School.Contract.Requests.Access_Control.Permissions;
using School.Contract.Commands.AccessControl.Permissions;
using School.Api.Extensions;

namespace School.Api.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]

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
            // var result = ApiResult<RequestiongPermissionsOperation>.CreateSuccessResponse(new AllPermissionResponse { Permissions = permissions.ToList() });
            return Ok(permissions);
        }



        [HttpGet("{id:Guid}")]
        public IActionResult Get(Guid id)
        {
            var permission = _permissionService.GetById(id);
            if (permission != null)
            {
                // var result = ApiResult<RequestiongPermissionsOperation>.CreateSuccessResponse(permission);
                return Ok(permission);
            }
            return NotFound();
        }

        [HttpPost("{id:Guid}")]
        public IActionResult Post(Guid id, UpdatePermissionRequest req)
        {
            var cmd = _mapper.Map<UpdatePermissionCommand>(req);
            cmd.Id = id;
            cmd.UpdatedBy = _httpContextHelper.GetUserId();
            var result = _permissionService.Edit(cmd);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return NotFound();
        }


        [HttpPost("{id:Guid}/delete")]
        public IActionResult Delete(Guid id, DeletePermissionRequest req)
        {
            var cmd = _mapper.Map<DeletePermissionCommand>(req);
            cmd.Id = id;
            cmd.DeletedBy = _httpContextHelper.GetUserId();
            var result = _permissionService.Delete(cmd);
            if (result.IsSuccess)
            {
                return Ok();
            }
            return NotFound();
        }


    }
}
