using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet] 
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
            public ActionResult Index1()
        {
           
            return View();
        }
    }
}