using System;
using System.ComponentModel.DataAnnotations;

namespace HotelMgr.Models
{
    public abstract class AccountModel
    {
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Sex { get; set; }
        [Required]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        public int Level { get; set; }
    }
}
