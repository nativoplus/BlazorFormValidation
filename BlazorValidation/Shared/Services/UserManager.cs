using BlazorValidation.Shared.Interfaces;
using BlazorValidation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorValidation.Shared.Services
{
    public class UserManager : IUserManager
    {
        private User User { get; set; } = new User {
            FirstName = "Isaias",
            Email = "idgv27@outlook.com",
            Password="123456789"
        };
        private string apiKey { get; set; } = "thygrfdewsqdwe";

        public User GetUserInfo()
        {
            if (User == null)
            {
                return new User();
            }
            return User;
        }

        public bool IsLogIn()
        {
            return apiKey != string.Empty ? true : false;
        }

        public bool LogIn(string email, string password)
        {
            if (User.Email == email && User.Password == password)
            {
               apiKey = "ghtiuehfskdjasnmlkdnjrtgfrdegtryt";
                return true;
            }
            return false;
        }

        public bool LogOut()
        {
            apiKey = string.Empty;
            return true;
        }

        public bool RegisterUser(User newUser)
        {
           User = newUser;
            return true;
        }


    }
}
