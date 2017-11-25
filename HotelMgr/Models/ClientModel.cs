using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class ClientModel : Account
    {
        [Required]
        public bool IsVip { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
