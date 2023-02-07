using Product_List.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Product_List.Controllers
{
    public class ProductsProfileController : Controller
    {
        // GET: ProductsProfile

        
        public ActionResult MyProfile()
        {
            Product[] allProducts = new Product[10];

            /*allProducts[0] = new Product("P001", "Ice-cream", 75);
            allProducts[1] = new Product("P002", "Chocolate", 100);
            allProducts[2] = new Product("P003", "Juice", 30);
            allProducts[3] = new Product("P003", "Chips", 20);
            allProducts[4] = new Product("P004", "Biscuit", 50);
            allProducts[5] = new Product("P005", "cake", 120);
            allProducts[6] = new Product("P006", "Drinko", 35);
            allProducts[7] = new Product("P007", "Pringles", 275);
            allProducts[8] = new Product("P008", "Lays", 60);
            allProducts[9] = new Product("P009", "Noodles", 180);*/

            for (int i = 0; i < 10; i++)
            {
                allProducts[i] = new Product()
                {
                    Id = i + 1,
                    Name = "P-" + (i + 1),
                    Price = 65,
                };
                /* allProducts[i] = new Product();
                 allProducts[i].Id = i + 1;
                 allProducts[i].Name = "P-" + (i + 1);
                 allProducts[i].Price = 45;*/

            }
           /* ViewBag.AllProducts = allProducts;*/
            
            ViewBag.Title = "My Profile";
            return View(allProducts);
        }

        public ActionResult Logout()
        {
            ViewBag.Title = "Logout";
            return RedirectToAction("Home", "ProductsIndex");
        }
    }
}