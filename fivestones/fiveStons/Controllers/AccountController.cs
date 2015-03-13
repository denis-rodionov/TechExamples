using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using fiveStons.Models;

namespace fiveStons.Controllers
{

    [HandleError]
    public class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }

            base.Initialize(requestContext);
        }

        // **************************************
        // URL: /Account/LogOn
        // **************************************

        public ActionResult LogOn()
        {
            return View();
        }

        public ActionResult Log()
        {
            ViewData["logs"] = PlayerManager.GetInstance().DB.Log;

            return View();
        }

        public ActionResult Results()
        {
            ViewData["players"] = PlayerManager.GetInstance().DB.Players;
            
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var p = PlayerManager.GetInstance().FindPlayer(model.UserName);
                if (p != null && p.pas == model.Password)
                {
                    FormsService.SignIn(model.UserName, model.RememberMe);

                    PlayerManager.GetInstance().LogPlayerOn(p, true);                    
                    
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Неверное имя игрока или пароль");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        // **************************************
        // URL: /Account/LogOff
        // **************************************

        public ActionResult LogOff()
        {
            FormsService.SignOut();

            Player p = PlayerManager.GetInstance().findMe(this);
            if (p != null)
                PlayerManager.GetInstance().LogPlayerOn(p, false);
            
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }

        // **************************************
        // URL: /Account/Register
        // **************************************

        public ActionResult Register()
        {
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (PlayerManager.GetInstance().FindPlayer(model.UserName) != null)
            {
                ModelState.AddModelError("UserName", "Пользователь с таким именем уже есть в системе!");
            }
            else if (ModelState.IsValid)
            {
                // Attempt to register the user
                Player p = new Player();
                p.name = model.UserName;
                p.pas = model.Password;
                p.email = model.Email;
                p.vin_count = 0;
                p.lose_count = 0;
                p.logged_on = true;

                PlayerManager.GetInstance().AddPlayer(p);

                FormsService.SignIn(p.name, false /* createPersistentCookie */);
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePassword
        // **************************************

        [Authorize]
        public ActionResult ChangePassword()
        {
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (MembershipService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword))
                {
                    return RedirectToAction("ChangePasswordSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
                }
            }

            // If we got this far, something failed, redisplay form
            ViewData["PasswordLength"] = MembershipService.MinPasswordLength;
            return View(model);
        }

        // **************************************
        // URL: /Account/ChangePasswordSuccess
        // **************************************

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }

    }
}
