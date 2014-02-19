using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FrontEnd()
        {
            return View();
        }

        public ActionResult BackEnd()
        {
            return View();
        }

        public ActionResult ByTalk()
        {
            return View();
        }

        public ActionResult NewsDetails()
        {
            return View();
        
        }

    }
}
