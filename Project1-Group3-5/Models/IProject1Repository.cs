using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Models
{
    public interface IProject1Repository
    {
        IQueryable<Booking> Bookings { get; }

        Booking GetBookingById(int bookingId);
        void UpdateBooking(Booking booking);
    }
}
