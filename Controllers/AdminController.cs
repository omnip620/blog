using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminHeader()
        {

            //ViewData["userName"] = Request.Cookies.Get("userName").Value;
            ViewData["userName"] = "PZC";
            return View();

        }

        public ActionResult Articles()
        {
            return View();
        }

        public ActionResult AddAtricle()
        { return View(); }



    }
}
