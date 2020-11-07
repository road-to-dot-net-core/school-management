using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using School.Api.Filters;
using School.Common.Contracts.Identity;
using School.Service.Access_Control;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    public class RolesController : Controller
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("")]
        [AuthorizeAccess("GetAllRoles")]      
        public IActionResult Get()
        {
            return Ok(_roleService.GetAll());
        }
       


    }
}
