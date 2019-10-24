using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOptionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IOptionDemo.Controllers
{
 
   // [Route("api/[controller]")]
    public class HomeController : Controller
    {
        public   IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
           ViewData["settings"] =  _configuration["Setting1"];
           ViewData["Title"] = _configuration.GetSection("HomeControllerOptions:Title").Value;
            var instan = new HomeControllerOptions();
             _configuration.GetSection("HomeControllerOptions").Bind(instan);
            return View(instan);
        }
    }
}
