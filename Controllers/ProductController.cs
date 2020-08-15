using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basics.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product() {ProductId=1,ProductName="Tea" });
            productList.Add(new Product() { ProductId = 2, ProductName = "Anything to eat" });
            return View(productList);
        }
    }
}