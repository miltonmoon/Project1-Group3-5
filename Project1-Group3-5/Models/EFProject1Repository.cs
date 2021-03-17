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
    }
}
