using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
namespace MVCDemo.Controllers
{
    public class ProductsController :Controller
    {
        //public ViewResult Index()
        //{
        //    ViewBag.name = "anji";
        //    ViewBag.categories=new List<string>()
        //    {
        //        "Electronics",
        //        "shoes"
        //    };
        //    return View();
        //}
        ProductsData db = new ProductsData();
        public ViewResult Index()
        {
            return View(db.ProductList.ToList());
        }
        public ViewResult Details(int id)
        {
          Product product=  db.ProductList.Single(x => x.ProductId == id);
            return View(product);
        }
    }
}