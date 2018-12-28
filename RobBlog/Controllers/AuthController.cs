using RobBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        //Getting submitted info from login view
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            return Content("Hey there, "+form.Username);
        }
    }
}