using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult Register(RegisterModel registerModel)
        {
            return View();
        }

    }
}
