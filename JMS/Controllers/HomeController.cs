using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cases()
        {
            return View();
        }

        public ActionResult List()
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

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult View2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult JuryQualify()
        {
            return View();
        }

        public ActionResult AboutJuryService()
        {
            return View();
        }
     
        public ActionResult TypesOfjury()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult JuryPay()
        {
            return View();
        }
        public ActionResult JuryScam()
        {
            return View();
        }
    }
}