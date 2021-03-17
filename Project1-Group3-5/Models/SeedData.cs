using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            Project1DbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<Project1DbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Bookings.Any())
            {
                context.Bookings.AddRange(
                    
                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 8, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 9, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 10, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 11, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 12, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 13, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 14, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 15, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 16, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 17, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 18, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 19, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 15, 20, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 8, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 9, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 10, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 11, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 12, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 13, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 14, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 15, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 16, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 17, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 18, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 19, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 16, 20, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 8, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 9, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 10, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 11, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 12, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 13, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 14, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 15, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 16, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 17, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 18, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 19, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 17, 20, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 8, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 9, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 10, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 11, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 12, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 13, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 14, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 15, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 16, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 17, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 18, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 19, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 18, 20, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 8, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 9, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 10, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 11, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 12, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 13, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 14, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 15, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 16, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 17, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 18, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 19, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    },

                    new Booking
                    {
                        BookingDateTime = new DateTime(2021, 03, 19, 20, 00, 00),
                        GroupName = "Available",
                        GroupSize = 0,
                        GroupEmail = "Available",
                        GroupPhone = "000-000-0000"
                    }
                );

                context.SaveChanges();
            
            }
        }
    }
}
