using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [ActionName("grid")]
        public ActionResult grid()
        {
            return View();
            
        }

        [ActionName("list")]
        public ActionResult list()
        {
            return View();
        }
        

        [ActionName("profile")]
        public ActionResult profile()
        {
            return View();
        }
	}
}