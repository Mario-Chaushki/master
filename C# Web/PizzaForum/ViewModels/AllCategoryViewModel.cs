using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForum.ViewModels
{
    public class AllCategoryViewModel
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public override string ToString()
        {
            string representation =
                "<tr>\r\n " + 
                $"<td><a href=\"#\">{this.CategoryName}</a></td>\r\n    " + 
                $"<td><a href=\"/categories/edit?id={this.Id}\" class=\"btn btn-primary\">Edit</a></td>\r\n    " + 
                $"<td><a href=\"/categories/delete?id={this.Id}\" class=\"btn btn-danger\">Delete</a></td>" + 
                "\r\n</tr>";
            return representation;
        }
    }
}

