using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class RecordModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid ClientId { get; set; }
        [Required]
        public double TotalMoney { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Sex { get; set; }
        [Required]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}
