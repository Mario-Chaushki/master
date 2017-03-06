using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleHttpServer.Models;
using SimpleMVC.Attributes.Methods;
using SimpleMVC.Controllers;
using SimpleMVC.Interfaces;
using SoftUniStore.BindingModels;
using SoftUniStore.Models;
using SoftUniStore.Services;

namespace SoftUniStore.Controllers
{
    public class StoreController : Controller
    {
        private StoreService service;
        public StoreController()
        {
            this.service = new StoreService();
        }

        [HttpGet]
        public IActionResult Register(HttpSession session, HttpResponse response)
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(HttpResponse response, RegisterUserBindingModel rubm)
        {
            if (!this.service.IsRegisterModelValid(rubm))
            {
                this.Redirect(response, "/store/register");
                return null;
            }

            User user = this.service.GetUserFromRegisterBind(rubm);
            this.service.RegisterUser(user);

            this.Redirect(response, "/store/login");
            return null;
        }

        [HttpGet]
        public IActionResult Login(HttpSession session, HttpResponse response)
        {
            if (this.IsAuthenticated(session.Id, response))
            {
                return null;
            }

            return this.View();
        }

        private bool IsAuthenticated(string sessionId, HttpResponse response)
        {
            if (AuthenticationManager.IsAuthenticated(sessionId))
            {
                this.Redirect(response, "/store/home");
                return true;
            }

            return false;
        }

        [HttpPost]
        public IActionResult Login(
            HttpResponse response, HttpSession session, LoginUserBindingModel lubm)
        {
            if (!this.service.IsLoginModelValid(lubm))
            {
                this.Redirect(response, "/store/login");
                return null;
            }

            User user = this.service.GetUserFromLoginBind(lubm);

            this.service.LoginUser(user, session.Id);
            this.Redirect(response, "/store/home");
            return null;
        }

        [HttpGet]
        public IActionResult Home(HttpSession session, HttpResponse response)
        {
            return this.View();
        }
    }
}
