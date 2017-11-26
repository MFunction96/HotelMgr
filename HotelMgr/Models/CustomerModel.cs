using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public class CustomerModel : AccountModel
    {
        [Required]
        public bool IsVip { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
