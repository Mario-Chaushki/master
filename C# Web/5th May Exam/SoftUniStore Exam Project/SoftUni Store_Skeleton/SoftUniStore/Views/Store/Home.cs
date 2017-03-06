using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Interfaces;

namespace SoftUniStore.Views.Store
{
    public class Home : IRenderable
    {
        public string Render()
        {
            string header = File.ReadAllText(Constants.ContentPath + Constants.Header);
            string navigation = File.ReadAllText(Constants.ContentPath + Constants.NavLoggedIn);
            string home = File.ReadAllText(Constants.ContentPath + Constants.Home);
            string footer = File.ReadAllText(Constants.ContentPath + Constants.Footer);

            StringBuilder builder = new StringBuilder();
            builder.Append(header);
            builder.Append(navigation);
            builder.Append(home);
            builder.Append(footer);

            return builder.ToString();
        }
    }
}
