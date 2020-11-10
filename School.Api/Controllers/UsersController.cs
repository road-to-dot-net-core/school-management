using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Users;
using School.Service.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("[controller]")]

    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly HttpContextHelper _httpContextHelper;

        public UsersController(IUserService userService, IMapper mapper, HttpContextHelper httpContextHelper)
        {
            _userService = userService;
            _mapper = mapper;
            _httpContextHelper = httpContextHelper;
        }
        [HttpPost]
        [AuthorizeAccess("RegisterUser")]
        public IActionResult RegisterUser(RegisterUserRequest req)
        {
            var registercommand = _mapper.Map<RegisterUserCommand>(req);
            registercommand.CreatedBy = _httpContextHelper.GetUserId();
            Result insertedResult = _userService.Insert(registercommand);

            if (insertedResult.IsSuccess)
                return Ok();
            return StatusCode(500, "Internal server error");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            if (users != null)
                return Ok(users);
            return StatusCode(500, "Internal server error");

        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var user = _userService.GetById(id);
            if (user != null)
                return Ok(user);
            return NotFound();
        }

    }
}
