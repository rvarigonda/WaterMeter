using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class IconsController : Controller
    {
        //
        // GET: /Icons/
        [ActionName("unicons")]
        public ActionResult unicons()
        {
            return View();
        }

        [ActionName("boxicons")]
        public ActionResult boxicons()
        {
            return View();
        }

        [ActionName("materialdesign")]
        public ActionResult materialdesign()
        {
            return View();
        }

        [ActionName("dripicons")]
        public ActionResult dripicons()
        {
            return View();
        }

        [ActionName("fontawesome")]
        public ActionResult fontawesome()
        {
            return View();
        }

	}
}