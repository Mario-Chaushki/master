using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.Models;

namespace PizzaForum.Utilities
{
    public class AuthenticationManager
    {
        public static bool IsAuthenticated(string sessionId)
        {
            return Data.Data.Context.Logins
                .Any(login => 
                    login.SessionId == sessionId && 
                    login.IsActive);
        }

        public static User GetAuthenticatedUser(string sessionId)
        {
            return Data.Data.Context.Logins
                .FirstOrDefault(login =>
                    login.SessionId == sessionId &&
                    login.IsActive).User;
        }
    }
}
