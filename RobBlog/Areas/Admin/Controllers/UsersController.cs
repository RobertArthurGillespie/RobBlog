﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobBlog.Areas.Admin.Controllers
{
    public class UsersController:Controller
    {
        public ActionResult Index()
        {
            return Content("Users!");
        }
    }
}