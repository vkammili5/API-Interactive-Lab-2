﻿using Microsoft.AspNetCore.Mvc;
namespace API_Interactive_Lab_2.Controllers
{
    [ApiController]
    [Route("Noodles")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }
    }
}
