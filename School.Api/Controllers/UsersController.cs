using Microsoft.AspNetCore.Mvc;
using School.Contract.Requests.Users;
using School.Service.Access_Control;
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

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult RegisterUser(RegisterUserRequest req)
        {
            bool inserted = _userService.Insert(req);
            if (inserted)
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
