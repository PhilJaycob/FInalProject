﻿using System;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        // Dashboard page
        public ActionResult Dashboard()
        {
            return View();
        }

        // Location page
        public ActionResult Location()
        {
            return View();
        }

        // Profile page
        public new ActionResult Profile()
        {
            return View();
        }

        // Logout page (clear session)
        public ActionResult Logout()
        {
            // Clear the session or perform other logout tasks
            Session.Clear();
            return RedirectToAction("LoginPage", "Home"); // Redirect to login page
        }

        // Login page
        public ActionResult LoginPage()
        {
            return View();
        }

        // Other actions
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

        public ActionResult RegistrationPage()
        {
            return View();
        }
    


    public string OneFunction()
        {
            return "VALUE FROM ONE FUNCTION";
        }

        public int TwoFunction(string FName, string LName)
        {
            if (FName.ToLower().Equals("Amado") && LName.ToLower().Equals("Sapit"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Assuming 'registrationData' is a model, define it accordingly.
        // For example:
        public class RegistrationData
        {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        public JsonResult TreeFunction(RegistrationData registrationData)
        {
            // Validate or manipulate the data here
            var rModel = new
            {
                Fname = registrationData.Fname,
                Lname = registrationData.Lname,
                Username = "asdfgtyuiol",  // Set username to a static value
                Password = "lkjhgfdsa"    // Set password to a static value
            };

            return Json(rModel, JsonRequestBehavior.AllowGet);
        }
    }
}