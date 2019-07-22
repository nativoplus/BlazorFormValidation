using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlazorValidation.Shared.Models;

namespace BlazorValidation.Shared.Validations
{
    public class SignUpFormValidation
    {

        [Required(ErrorMessage ="first name is required.")]
        [StringLength(10, ErrorMessage = "first name is too long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required.")]
        [StringLength(10, ErrorMessage = "last name is too long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "age is required.")]
        [Range(13,200, ErrorMessage ="must be 13 or older")]
        public int Age { get; set; }

        [Required(ErrorMessage = "username is required.")]
        [MinLength(4, ErrorMessage = "username must be at least 4 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "email is required.")]
        [EmailAddress()]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is required.")]
        [MinLength(8, ErrorMessage = "password must be atleast 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "re-type password is required.")]
        [Compare(nameof(Password), ErrorMessage = "password dosent match")]
        public string ConfirmPassword { get; set; } = string.Empty;

        public void ResetPassword()
        {
            Password = string.Empty;
            ConfirmPassword = string.Empty;
        }

        public User GetRegisteredUser()
        {
            return new User
            {
            FirstName =FirstName,
            LastName = LastName,
            Age =Age,
            Username = Username,
            Email = Email,
            Password = Password,
            ConfirmPassword =ConfirmPassword
            };
        }
    }
}
