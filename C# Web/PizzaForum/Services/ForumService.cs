using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PizzaForum.BindingModels;
using PizzaForum.Models;

namespace PizzaForum.Services
{
    public class ForumService : Service
    {
        public bool IsRegisterModelValid(RegisterUserBindingModel rubm)
        {
            //Username validation
            if (rubm.Username.Length < 3)
            {
                return false;
            }
            Regex regex = new Regex("^[a-z0-9]+$");
            if (!regex.IsMatch(rubm.Username))
            {
                return false;
            }

            //Email validation
            if (!rubm.Email.Contains("@"))
            {
                return false;
            }

            //Password validation
            Regex passRegex = new Regex("^[0-9]{4}$");
            if (!passRegex.IsMatch(rubm.Password) || rubm.Password != rubm.ConfirmPassword)
            {
                return false;
            }

            //Check if user exists in database already
            if (this.Context.Users.Any(user => user.Username == rubm.Username || user.Email == rubm.Email))
            {
                return false;
            }

            //If all if statements passed the model is valid
            return true;
        }

        public User GetUserFromRegisterBind(RegisterUserBindingModel rubm)
        {
            return new User()
            {
                Username = rubm.Username,
                Email = rubm.Email,
                Password = rubm.Password,
            };
        }

        public User GetUserFromLoginBind(LoginUserBindingModel lubm)
        {
            return this.Context.Users
                .First(user => (user.Username == lubm.Credential || user.Email == lubm.Credential) &&
                               user.Password == lubm.Password);
        }

        public void RegisterUser(User user)
        {
            //Check
            if (!this.Context.Users.Any())
            {
                this.Context.Database.CreateIfNotExists();
                user.IsAdmin = true;
            }
            this.Context.Users.Add(user);
            this.Context.SaveChanges();
        }

        public bool IsLoginModelValid(LoginUserBindingModel lubm)
        {
            return this.Context.Users.Any(
                user =>
                    (user.Username == lubm.Credential || user.Email == lubm.Credential) &&
                    user.Password == lubm.Password);
        }

        public void LoginUser(User user, string sessionId)
        {
            this.Context.Logins.Add(new Login()
            {
                SessionId = sessionId,
                User = user,
                IsActive = true
            });

            this.Context.SaveChanges();
        }
    }
}
