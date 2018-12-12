﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockers.Controllers
{
    public class HomeController : Controller
    {
        // Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // Home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        // Add a new action method for Backstage
        public ActionResult Backstage(string secret, string format)
        {
            if (secret != "special")
            {
                return new HttpStatusCodeResult(403); // forbidden View
            }
            return View();
        }
    }
}