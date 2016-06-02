using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Norhwind.Entities;
using Northwind.Interfaces;

namespace Northwind.MVCWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationManager;

        public AccountController(IAuthenticationService authenticationManager)
        {
            _authenticationManager = authenticationManager;
        }

        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Login(User user, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User validatiedUser = _authenticationManager.Authenticate(user);
                if (validatiedUser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return Redirect(returnUrl);
                }
                ModelState.AddModelError("Hata", "Kullanıcı adı veya şifre hatalı");
            }
            return View();
        }
    }
}