using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants.User;

namespace TaskBoardApp.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(MaxUserFirstNameLenght)]
        public string FirstName { get; init; }

        [Required]
        [MaxLength(MaxUserLastNameLenght)]
        public string LastName { get; init; }
    }
}
