using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class EmailController : Controller
    {
        //
        // GET: /Email/
        [ActionName("inbox")]
        public ActionResult inbox()
        {
            return View();
        }

        [ActionName("read")]
        public ActionResult read()
        {
            return View();
        }
	}
}