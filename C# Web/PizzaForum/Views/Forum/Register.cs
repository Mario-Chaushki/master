using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Interfaces;

namespace PizzaForum.Views.Forum
{
    public class Register : IRenderable
    {
        public string Render()
        {
            StringBuilder sb = new StringBuilder();

            string header = File.ReadAllText(Constants.ContentPath + Constants.Header);
            string navigation = File.ReadAllText(Constants.ContentPath + Constants.NavNotLogged);
            string register = File.ReadAllText(Constants.ContentPath + Constants.Register);
            string footer = File.ReadAllText(Constants.ContentPath + Constants.Footer);

            sb.Append(header);
            sb.Append(navigation);
            sb.Append(register);
            sb.Append(footer);

            return sb.ToString();
        }
    }
}
