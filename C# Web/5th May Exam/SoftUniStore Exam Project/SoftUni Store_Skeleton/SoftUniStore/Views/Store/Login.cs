using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Interfaces;

namespace SoftUniStore.Views.Store
{
    public class Login : IRenderable
    {
        public string Render()
        {
            string header = File.ReadAllText(Constants.ContentPath + Constants.Header);
            string navigation = File.ReadAllText(Constants.ContentPath + Constants.NavNotLoggedIn);
            string register = File.ReadAllText(Constants.ContentPath + Constants.Login);
            string footer = File.ReadAllText(Constants.ContentPath + Constants.Footer);

            StringBuilder builder = new StringBuilder();
            builder.Append(header);
            builder.Append(navigation);
            builder.Append(register);
            builder.Append(footer);

            return builder.ToString();
        }
    }
}
