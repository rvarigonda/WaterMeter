using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class InvoiceController : Controller
    {
        //
        // GET: /Invoice/
        [ActionName("list")]
        public ActionResult list()
        {
            return View();
        }

        [ActionName("details")]
        public ActionResult details()
        {
            return View();
        }
	}
}