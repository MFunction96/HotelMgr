using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class RoomModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid PriceId { get; set; }
        [Required]
        public bool IsCheckIn { get; set; }
        [Required]
        public bool NeedClean { get; set; }
        [Required]
        public bool NeedFix { get; set; }
        [Required]
        public bool IsAvailable { get; set; }
    }
}
