using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DataAccess.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : Controller
    {
        //
        // GET: /Authentication/
        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Login(UserDetails ud)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
                UserStatus usr = ebl.GetValidUser(ud);
                bool IsAdmin = false;
                if (usr == UserStatus.AuthenticatedAdmin)
                {
                    IsAdmin = true;                    
                }

                else if (usr == UserStatus.Authenticateduser)
                {
                    IsAdmin = false;
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Invalid Credentials");
                    return View("Login");
                }
                FormsAuthentication.SetAuthCookie(ud.Username, false);
                Session["Admin"] = IsAdmin;
                return RedirectToAction("Index", "Employee");
            }

            else
                return View("Login");
        
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        
        }
	}
}