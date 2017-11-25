using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class PriceModel
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string RoomType { get; set; }
        [Required]
        public uint RoomPrice { get; set; }
        [Required]
        public bool IsHourRoom { get; set; }
    }
}
