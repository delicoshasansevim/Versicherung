using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc;
using System.Drawing;
using System.Drawing.Imaging;
using WebGrease;
using System.IO;
using System.Data;
using System.Globalization;
using System.Web.Security;
using VersicherungResponsive3.Models;
using CaptchaMvc.HtmlHelpers;
//using CaptchaMvc.HtmlHelpers;


namespace VersicherungResponsive3.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Index(string txt1, string txt2, Person person)
        {

            ViewBag.message = "Danke " + txt1 + " " + txt2 + ". Es ist gesendet.";
            return View();
        }


        [HttpGet]
        public ActionResult Registrierung()
        {

            return View();
        }



        [ActionName("Registrierung")]

        [HttpPost]
        public ActionResult Registrierung(Person model)
        {
            if (ModelState.IsValid)
            {

                return View();

            }

            else
            {

                ModelState.AddModelError("#ERROR", "Please check the fields errors");

                //// Code for validating the CAPTCHA  
                if (this.IsCaptchaValid("Captcha is not valid"))
                {

                    //return RedirectToAction("ThankYouPage");
                    ViewBag.SuccessMessage = "Success: captcha is validated.";

                }
                else
                {
                    ViewBag.ErrMessage = "Error: captcha is not validated.";
                }
                return View(model);
                // return RedirectToAction("Registrierung");
            }




            //return View();

        }


    } // end of controller
} // end of namespace