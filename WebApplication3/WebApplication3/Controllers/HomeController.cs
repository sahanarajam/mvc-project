using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Indexss()
        {
            return View();
        }
        public ActionResult test()
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
        [HttpGet]
        public ActionResult reg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult reg(sahana obj)
        {
            if(ModelState.IsValid)
            {
                Database1Entities db = new Database1Entities();
                db.sahanas.Add(obj);
                db.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public ActionResult log()
        {
            return View();
        }
        [HttpPost]
        public ActionResult log(sahana obju)
        {
            if (ModelState.IsValid)
            {
                using (Database1Entities db = new Database1Entities())
                {
                    var obj = db.sahanas.Where(model => model.email.Equals(obju.email) && model.password.Equals(obju.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["Id"] = obj.Id.ToString();
                        Session["email"] = obj.email.ToString();
                        return RedirectToAction("Exits");

                    }
                }

                
            }
            return View(obju);
        }
        public ActionResult Indexx()
        {
            if(Session["Id"] != null)
{
                return View();
            }
else
{
                return RedirectToAction("log");
            }
        }
        public ActionResult Media()
        {
            Database1Entities db = new Database1Entities();
            var test = db.sahanas.ToList();
            ViewBag.username = test;
            return View();
        }
        public ActionResult Index1(int id, string username)
        {

            var data = id.ToString();
            var test =username.ToString();
            ViewBag.Id = data;
            ViewBag.name = test;
            return View();
            
        }
    }
      


    }