using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class MapsController : Controller
    {
        //
        // GET: /Maps/
        [ActionName("google")]
        public ActionResult google()
        {
            return View();
        }

        [ActionName("vector")]
        public ActionResult vector()
        {
            return View();
        }

        [ActionName("leaflet")]
        public ActionResult leaflet()
        {
            return View();
        }
	}
}