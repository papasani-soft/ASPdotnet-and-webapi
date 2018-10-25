using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{ ProductId=1,Name="Samsung TV",Price=3000M},
            new Product{ ProductId=2,Name="Nike Shoe",Price=2400}
        };
        public JsonResult ProductsData()
        {
            return Json(products,JsonRequestBehavior.AllowGet);
        }
    }
}