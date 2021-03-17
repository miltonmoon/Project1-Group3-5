using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Models
{
    public class Project1DbContext : DbContext
    {
        public Project1DbContext (DbContextOptions<Project1DbContext> options) : base(options)
        {

        }

        public DbSet<Booking> Bookings { get; set; }
    }
}
