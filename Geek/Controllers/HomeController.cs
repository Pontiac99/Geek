using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Geek.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.message = "Sample changes";
            //Aj changes
            //done



            return View();
        }

        public ActionResult About()
        {
            //dfsdfsdfsfs
            string aa = "bb";

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