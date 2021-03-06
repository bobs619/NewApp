﻿using System;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bob = "dog";

            if (string.IsNullOrWhiteSpace(bob)){
                Console.Out.WriteLine("yo");
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}