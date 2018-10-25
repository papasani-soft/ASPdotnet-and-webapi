using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormVal.Models;
namespace FormVal.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [HttpGet]
        public ActionResult AddOrEdit(int id)
        {
            Register user1 = new Register();
            return View(user1);
        }
       // [HttpPost]
        //public ActionResult AddOrEdit(Register user1)
        //{
        //    using (UsersContext userCo=new UsersContext ())
        //    {
        //        userCo.
        //    }
        //}
    }
}