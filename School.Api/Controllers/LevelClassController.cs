using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Api.Requests;
using School.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LevelClassController : Controller
    {
        private readonly ILevelClassService _levelClassService;

        public LevelClassController(ILevelClassService levelClassService)
        {
            _levelClassService = levelClassService;
        }

        [HttpGet]
        public IActionResult Get() => Ok("School Api is online");

        [HttpPost("insert")]
        public IActionResult Insert(AddLevelClassRequest req)
        {
            var created = _levelClassService.InsertLevelClass(req.Name, req.Level);
            if (created)
                return Ok();
            else
                return BadRequest();
        }

        [HttpGet("get")]
        public IActionResult GetAll()
        {
            var listOfLevels = _levelClassService.GetAll();
            return Ok(listOfLevels);
        }
    }
}
