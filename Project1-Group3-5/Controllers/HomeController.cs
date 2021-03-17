using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project1_Group3_5.Models;
using Project1_Group3_5.Models.ViewModels;
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
        private IProject1Repository _repository;

        public HomeController(ILogger<HomeController> logger, IProject1Repository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //Home page
        public IActionResult Index()
        {
            return View();
        }
        //SignUp page
        public IActionResult SignUp()
        {
            return View(new BookingListViewModel
            {
                Bookings = _repository.Bookings
                .OrderBy(p => p.BookingDateTime)
            });
        }
        //Form page
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        //For the post method of the form 
        //The "string data" can be changed to whatever value that needs to be passed thru the form--its just a placeholder right now so that the program runs.
        [HttpPost]
        public IActionResult Form(string data)
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
