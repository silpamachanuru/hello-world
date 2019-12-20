using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult load()
        {
            Customer obj = new Customer { customercode = "1001", customername = "name" };


            return View("Customer",obj);
        }
        public ActionResult Enter()
        {
            return View("EnterCustomer");
        
        }
        public ActionResult Submit(Customer obj)
        {
            Customer obj = new Customer();
            obj.customercode = Request.Form["customercode"];
            obj.customername = Request.Form["customername"];
           
            return View("Customer",obj);
        }
    }
}