using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class OrderModel
    {
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        [Required]
        public DateTime ConfirmDate { get; set; }
        [Required]
        [MaxLength(256)]
        public string RoomType { get; set; }
        [Required]
        public uint Amount { get; set; }
        [Required]
        public bool IsHourRoom { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        [Required]
        public bool IsAccepted { get; set; }
    }
}
