using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlazorValidation.Shared.Models;

namespace BlazorValidation.Shared.Validations
{
    public class LogInValidation
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public User GetUser()
        {
            return new User {
                Email = Email,
                Password = Password
            };
        }
    }
}
