using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BinaryStudio.Exam.Core;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                UserProcessor userProcessor = new UserProcessor();
                if(userProcessor.CreateUser(registerModel))
                {
                    return View();
                }
                else
                {
                    return View(registerModel);
                }
            }
            else
            {
                return View(registerModel);
            }
        }

        public ActionResult LogOn(LogOnModel logOn)
        {
            if (ModelState.IsValid)
            {
                UserProcessor userProcessor = new UserProcessor();
                if (userProcessor.ValidateUser(logOn.EMail, logOn.Password))
                {
                    string userName = userProcessor.GetUserByEmail(logOn.EMail).FirstName;
                    FormsAuthentication.SetAuthCookie(userName, logOn.Stay);
                }
                else
                {
                    return View(logOn);
                }
                
            }
            return View(logOn);

        }

    }
}
