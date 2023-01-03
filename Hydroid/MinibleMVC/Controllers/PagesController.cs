using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/
        [ActionName("starter")]
        public ActionResult starter()
        {
            return View();
        }

        [ActionName("maintenance")]
        public ActionResult maintenance()
        {
            return View();
        }

        [ActionName("comingsoon")]
        public ActionResult comingsoon()
        {
            return View();
        }

        [ActionName("timeline")]
        public ActionResult timeline()
        {
            return View();
        }

        [ActionName("faqs")]
        public ActionResult faqs()
        {
            return View();
        }

        [ActionName("pricing")]
        public ActionResult pricing()
        {
            return View();
        }

        [ActionName("404")]
        public ActionResult error404()
        {
            return View();
        }

        [ActionName("500")]
        public ActionResult error500()
        {
            return View();
        }
	}
}