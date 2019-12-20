using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["myviewdata"] = DateTime.Now.ToString();
            ViewBag.myviewbag = DateTime.Now.ToString();
            TempData["mytemp"] = DateTime.Now.ToString();
            Session["mysession"] = DateTime.Now.ToString();
            return RedirectToAction("Gotohome", "Home"); 
           


           


       
        }

        public ActionResult Gotohome()
        {

            ViewData["myviewdata"] = DateTime.Now.ToString();
            ViewBag.myviewbag = DateTime.Now.ToString();
            TempData["mytemp"] = DateTime.Now.ToString();
            Session["mysession"] = DateTime.Now.ToString();
            return View();
        }

           
    }
}