using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            /*
            //Redirectrusult en Contentresult zijn klassen in MVC die een result/response geven.
            //Deze erfen beide van ActionResult, dus deze wordt bijna altijd meegegeven bij ActionMethods.
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                //return new RedirectResult("/"); is hetzelfde als onderstaand code:
                return Redirect("/");
            }
            return new ContentResult()
            {
                Content = "Hello from the comic book controller!"
            };
            */

            //Dit zijn nu property's van een dynamic viewbag. Deze kunnen nu opgevraagd worden door de view!!!
            ViewBag.Test1 = "hoi sacco";
            ViewBag.Namen = new string[] { "Sacco", "Jordi", "Trevi" };





            //Een view returnen!!!
            return View();


        }
    }
}