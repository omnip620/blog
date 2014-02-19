using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult HomeHead()
        {
            return View();
        }

        public ActionResult sideBarHotArticle()
        {
            return View();
        }

        public ActionResult sideBarLatestArticle()
        {
            return View();
        }

        public ActionResult sideBarHotLabels()
        {
            return View();
        }

        public ActionResult sideBarTimeStamp()
        {
            return View();
        }

    }
}
