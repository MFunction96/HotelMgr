using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class StaffModel : Account
    {
        [Required]
        [MaxLength(256)]
        public string Position { get; set; }
        [Required]
        [MaxLength(256)]
        public string Address { get; set; }
        [Required]
        public uint Salary { get; set; }
        [Required]
        public DateTime HireData { get; set; }

    }
}
