using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShakeMaker.Models;

namespace ShakeMaker.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Load()
        {
            User myUser = new User("dima", "abc", "abc@abc.com", null);
            return View("User",myUser);
        }
    }
}