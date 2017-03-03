using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaForum.Models;
using PizzaForum.Services;
using PizzaForum.Utilities;
using PizzaForum.ViewModels;
using SimpleHttpServer.Models;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;
using SimpleMVC.Interfaces.Generic;

namespace PizzaForum.Controllers
{
    public class CategoriesController : Controller
    {
        private CategoriesService service;

        public CategoriesController()
        {
            this.service = new CategoriesService();
        }

        public IActionResult<AllViewModel> All(HttpSession session, HttpResponse response)
        {
            if (!AuthenticationManager.IsAuthenticated(session.Id))
            {
                this.Redirect(response, "/forum/login");
                return null;
            }
            User activeUser = AuthenticationManager.GetAuthenticatedUser(session.Id);
            if (!activeUser.IsAdmin)
            {
                this.Redirect(response, "/home/topics");
                return null;
            }
            AllViewModel viewModel = this.service.GetAllViewModel(activeUser);

            return this.View(viewModel);
        }
    }
}
