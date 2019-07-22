using BlazorValidation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorValidation.Shared.Interfaces
{
    public interface IUserManager
    {
        bool LogIn(string email, string password);
        bool IsLogIn();
        bool LogOut();

        bool RegisterUser(User newUser);
        User GetUserInfo();
    }
}
