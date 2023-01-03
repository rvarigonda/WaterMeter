using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class LayoutController : Controller
    {
        //
        // GET: /Layout/
        [ActionName("dark-sidebar")]
        public ActionResult darksidebar()
        {
            return View();
        }

        [ActionName("compact-sidebar")]
        public ActionResult compactsidebar()
        {
            return View();
        }

        [ActionName("icon-sidebar")]
        public ActionResult iconsidebar()
        {
            return View();
        }

        [ActionName("boxed-width")]
        public ActionResult boxedwidth()
        {
            return View();
        }

        [ActionName("preloader")]
        public ActionResult preloader()
        {
            return View();
        }

        [ActionName("colored-sidebar")]
        public ActionResult coloredsidebar()
        {
            return View();
        }

        [ActionName("horizontal")]
        public ActionResult horizontal()
        {
            return View();
        }

        [ActionName("horizontal-topbar")]
        public ActionResult horizontaltopbar()
        {
            return View();
        }

        [ActionName("horizontal-boxed-width")]
        public ActionResult horizontalboxedwidth()
        {
            return View();
        }

        [ActionName("horizontal-preloader")]
        public ActionResult horizontalpreloader()
        {
            return View();
        }
	}
}