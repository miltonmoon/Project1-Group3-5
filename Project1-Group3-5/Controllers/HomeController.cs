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
        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new BookingListViewModel
            {
                Bookings = _repository.Bookings
                .OrderBy(p => p.BookingDateTime)
            });
        }

        [HttpPost]
        public IActionResult SignUp(Booking model)
        {
            int id = model.BookingID;

            return View("Form", new BookingListViewModel
            {
                Bookings = _repository.Bookings
                .Where(p => p.BookingID == id)
                .OrderBy(p => p.BookingDateTime)
            });
        }

        //Form page
        /*[HttpGet]
        public IActionResult Form(BookingListViewModel b)
        {
            return View(b);
        }*/
        //For the post method of the form 
        //The "string data" can be changed to whatever value that needs to be passed thru the form--its just a placeholder right now so that the program runs.
        [HttpPost]
        public IActionResult Form(Booking booking)
        {
            //Booking tempBooking = new Booking();
            //_repository.Bookings.Where(p => p.BookingDateTime == booking.BookingDateTime) = tempBooking;

            //_repository.GetBookingById(booking.BookingID).GroupName = booking.GroupName;
            //_repository.GetBookingById(booking.BookingID).GroupEmail = booking.GroupEmail;
            //_repository.GetBookingById(booking.BookingID).GroupPhone = booking.GroupPhone;
            //_repository.GetBookingById(booking.BookingID).GroupSize = booking.GroupSize;

            _repository.UpdateBooking(booking);

            return View("Confirmation", booking);
        }

        //ViewAppointments page
        public IActionResult ViewAppointments()
        {
            return View(_repository.Bookings);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
