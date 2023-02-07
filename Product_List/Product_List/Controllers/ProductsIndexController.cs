using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Product_List.Controllers
{
    public class ProductsIndexController : Controller
    {
        // GET: ProductsIndex
        public ActionResult Home()
        {
            ViewBag.Title = "Home";
            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Title = "Products";
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }
        public ActionResult LoginSubmit()
        {
            return RedirectToAction("MyProfile", "ProductsProfile");

        }
    }
}