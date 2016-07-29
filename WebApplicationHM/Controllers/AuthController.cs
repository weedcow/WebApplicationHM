using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using WebApplicationHM.Models;

namespace WebApplicationHM.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
       
        // GET: Auth
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new User()
            {
                ReturnURL = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult LogIn(User model)
        {
            // Checking for errors in data annotations and props
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(model.Email == "admin@admin.com" && model.Password == "password")
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "Ben"),
                    new Claim(ClaimTypes.Email, "a@b.com"),
                    new Claim(ClaimTypes.Country, "England")
                },
                "ApplicationCookie");
                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnURL));
            }

            ModelState.AddModelError("", "Invalid email or password");
            return View();
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");

            return RedirectToAction("index", "home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if(string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
    }
}