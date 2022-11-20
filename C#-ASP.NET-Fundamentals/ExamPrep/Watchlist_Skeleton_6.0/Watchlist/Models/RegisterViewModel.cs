using System.ComponentModel.DataAnnotations;
using static Watchlist.Data.DataConstants.User;

namespace Watchlist.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(MaxUserName, MinimumLength = MinUserName)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(MaxUserEmail, MinimumLength = MinUserEmail)]
        public string Email { get; set; }

        [Required]
        [StringLength(MaxUserPassword, MinimumLength = MinUserPassword)]
        [DataType(DataType.Password)]
        public string Password { get; set; } 

        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
