using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hydroid5.Controllers
{
    public class EcommerceController : Controller
    {
        //
        // GET: /Ecommerce/
        [ActionName("products")]
        public ActionResult products()
        {
            return View();
        }

        [ActionName("product-detail")]
        public ActionResult productdetail()
        {
            return View();
        }

        [ActionName("orders")]
        public ActionResult orders()
        {
            return View();
        }

        [ActionName("customers")]
        public ActionResult customers()
        {
            return View();
        }

        [ActionName("cart")]
        public ActionResult cart()
        {
            return View();
        }

        [ActionName("checkout")]
        public ActionResult checkout()
        {
            return View();
        }

        [ActionName("shops")]
        public ActionResult shops()
        {
            return View();
        }

        [ActionName("add-product")]
        public ActionResult addproduct()
        {
            return View();
        }
	}
}