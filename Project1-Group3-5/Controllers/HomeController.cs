using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1_Group3_5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Home page
        public IActionResult Index()
        {
            return View();
        }
        //SignUp page
        public IActionResult SignUp()
        {
            return View();
        }
        //Form page
        public IActionResult Form()
        {
            return View();
        }
        //ViewAppointments page
        public IActionResult ViewAppointments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
