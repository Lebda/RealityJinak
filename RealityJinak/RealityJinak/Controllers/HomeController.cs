﻿using System;
using System.Linq;
using System.Web.Mvc;

namespace RealityJinak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Offers()
        {
            ViewBag.Message = "Offers ";

            return View();
        }

        public ActionResult ServicesBuyers()
        {
            ViewBag.Message = "Služby pro kupující ";

            return View();
        }

        public ActionResult ServicesSellers()
        {
            ViewBag.Message = "Služby pro prodávající ";

            return View();
        }
    }
}