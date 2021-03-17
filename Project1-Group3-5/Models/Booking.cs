using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1_Group3_5.Models
{
    public class Booking
    {
        [Required]
        [Key]
        public int BookingID { get; set; }
        [Required]
        public DateTime BookingDateTime { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string GroupEmail { get; set; }
        [Required]
        [RegularExpression(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$", ErrorMessage = "Must be a valid Phone Number")]
        public string GroupPhone { get; set; }
    }
}
