using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SoftUniStore.BindingModels;
using SoftUniStore.Models;
using SoftUniStore.Views.Store;

namespace SoftUniStore.Services
{
    public class StoreService : Service
    {
        public bool IsRegisterModelValid(RegisterUserBindingModel rubm)
        {
            //Check if email is valid
            if (!(rubm.Email.Contains("@") && rubm.Email.Contains(".")))
            {
                return false;
            }
            //Check if the database contains any user with this email
            if (Data.Data.Context.Users.Any(user => user.Email == rubm.Email))
            {
                return false;
            }

            //Check if password is valid
            if (!(rubm.Password.Length >= 6 &&
                rubm.Password == rubm.ConfirmPassword &&
                rubm.Password.Any(char.IsUpper) &&
                rubm.Password.Any(char.IsLower) &&
                rubm.Password.Any(char.IsDigit)))
            {
                return false;
            }

            if (rubm.FullName == "")
            {
                return false;
            }

            //if all checks pass then the model is valid
            return true;
        }

        public User GetUserFromRegisterBind(RegisterUserBindingModel rubm)
        {
            return new User()
            {
                Email = rubm.Email,
                FullName = rubm.FullName,
                Password = rubm.Password
            };
        }

        public void RegisterUser(User user)
        {
            if (this.Context.Users.Count() == 0)
            {
                user.IsAdmin = true;
            }

            this.Context.Users.Add(user);
            this.Context.SaveChanges();
        }

        public bool IsLoginModelValid(LoginUserBindingModel lubm)
        {
            return this.Context.Users.Any(
                user => user.Email == lubm.Email && user.Password == lubm.Password);
        }

        public User GetUserFromLoginBind(LoginUserBindingModel lubm)
        {
            return this.Context.Users.FirstOrDefault(
                 user => user.Email == lubm.Email && user.Password == lubm.Password);
        }

        public void LoginUser(User user, string sessionId)
        {
            this.Context.Logins.Add(new Models.Login()
            {
                SessionId = sessionId,
                User = user,
                IsActive = true
            });

            this.Context.SaveChanges();
        }

        //Home view services

    }
}
