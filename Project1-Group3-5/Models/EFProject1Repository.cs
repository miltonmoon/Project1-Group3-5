using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Models
{
    public class EFProject1Repository : IProject1Repository
    {
        private Project1DbContext _context;

        public EFProject1Repository(Project1DbContext context)
        {
            _context = context;
        }

        public IQueryable<Booking> Bookings => _context.Bookings;

        public Booking GetBookingById(int id)
        {
            return _context.Bookings.Find(id);
        }

        public Booking GetBookingByDateTime(DateTime bookingDT)
        {
            return _context.Bookings.Find(bookingDT);
        }
        public void UpdateBooking(Booking booking)
        {
            _context.Bookings.Find(booking.BookingID).GroupName = booking.GroupName;
            _context.Bookings.Find(booking.BookingID).GroupEmail = booking.GroupEmail;
            _context.Bookings.Find(booking.BookingID).GroupSize = booking.GroupSize;
            _context.Bookings.Find(booking.BookingID).GroupPhone = booking.GroupPhone;
            //_context.Entry(booking).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
