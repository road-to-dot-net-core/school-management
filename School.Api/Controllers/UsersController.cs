using AutoMapper;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using School.Api.Filters;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Users;
using School.Service.Access_Control;
using System;
using Microsoft.AspNetCore.Cors;

namespace School.Api.Controllers
{
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    [AuthorizeAccess("Users")]
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
        //[Route(ApiRoutes.Users.Post)]
        //[AuthorizeAccess("RegisterUser")]
        public IActionResult Post(RegisterUserRequest req)
        {
            var registercommand = _mapper.Map<RegisterUserCommand>(req);
            registercommand.CreatedBy = _httpContextHelper.GetUserId();
            Result insertedResult = _userService.Insert(registercommand);

            if (insertedResult.IsSuccess)
                return Ok();
            return StatusCode(500, "Internal server error");
        }


        [HttpGet]
        // [Route(ApiRoutes.Users.GetAll)]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            if (users != null)
                return Ok(users);
            return StatusCode(500, "Internal server error");

        }



        [HttpGet("{id}")]
        // [Route(ApiRoutes.Users.Get)]
        public IActionResult Get(Guid id)
        {
            var user = _userService.GetById(id);
            if (user != null)
                return Ok(user);
            return NotFound();
        }



        [HttpGet("menu")]
        // [Route(ApiRoutes.Users.GetAll)]
        public IActionResult GetMenu()
        {
            Guid userId = _httpContextHelper.GetUserId();
            var userMenu = _userService.GetMenu(userId);
            if (userMenu != null)
                return Ok(userMenu);


            return StatusCode(500, "Internal server error");

        }


    }
}
