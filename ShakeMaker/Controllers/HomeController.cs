using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShakeMaker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // ViewBag.CurrentTime1 = DateTime.Now.ToString();
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            TempData["CurrentTime"] = DateTime.Now.ToString();
            Session["CurrentTime"] = DateTime.Now.ToString();
            return RedirectToAction("ShowHomePage", "Home");
        }

        public ActionResult ShowHomePage()
        {
            
            //ViewBag.CurrentTime1 = DateTime.Now.ToString();
            return View("MyHome");
         }
    }
}