using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormVal.Models;
namespace FormVal.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int Id=0)
        {
            tblRegister userModel = new tblRegister();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(tblRegister userModel)
        {
            using (DbModels dbModel=new DbModels())
            {
                dbModel.tblRegisters.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration successful..";
            return View("AddOrEdit", new tblRegister());
        }

    }
}