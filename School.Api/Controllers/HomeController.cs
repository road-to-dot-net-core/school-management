﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Api.Controllers
{
    [Route("")]
    [EnableCors("AllowOrigin")]

    public class HomeController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return Ok(new { text = "School Api is online" });
        }
    }
}
