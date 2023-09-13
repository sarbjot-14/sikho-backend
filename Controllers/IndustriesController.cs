using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace sikho_backend.Controllers
{
    [Route("[controller]")]
    public class IndustriesController : Controller
    {
        private readonly ILogger<IndustriesController> _logger;

        public IndustriesController(ILogger<IndustriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Greetings(){
            return "Hello there";
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}