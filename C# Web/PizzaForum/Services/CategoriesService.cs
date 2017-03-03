using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.Models;
using PizzaForum.ViewModels;

namespace PizzaForum.Services
{
    public class CategoriesService : Service
    {
        public AllViewModel GetAllViewModel(User activeUser)
        {
            AllViewModel view = new AllViewModel();
            LoggedInUserViewModel loggedIn = new LoggedInUserViewModel()
            {
                Username = activeUser.Username
            };
            IEnumerable<AllCategoryViewModel> categories =
                this.Context.Categories.Select(c => new AllCategoryViewModel()
                {
                    Id = c.Id,
                    CategoryName = c.Name
                });
            view.User = loggedIn;
            view.Categories = categories;

            return view;
        }
    }
}
