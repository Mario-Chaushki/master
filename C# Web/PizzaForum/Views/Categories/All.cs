using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.ViewModels;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace PizzaForum.Views.Categories
{
    public class All : IRenderable<AllViewModel>
    {
        public string Render()
        {
            StringBuilder sb = new StringBuilder();

            string header = File.ReadAllText(Constants.ContentPath + Constants.Header);
            string navigation = File.ReadAllText(Constants.ContentPath + Constants.NavLogged);
            navigation = string.Format(navigation, Model.User.Username);
            string categories = File.ReadAllText(Constants.ContentPath + Constants.Categories);
            categories = string.Format(categories, Model);
            string footer = File.ReadAllText(Constants.ContentPath + Constants.Footer);

            sb.Append(header);
            sb.Append(navigation);
            sb.Append(categories);
            sb.Append(footer);

            return sb.ToString();
        }

        public AllViewModel Model { get; set; }
    }
}
