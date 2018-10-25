using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DemofileController : Controller
    {
        // GET: Demofile
        public FileResult Tutorial()
        {
            return File("~/Content/Microsoft.pdf","application/pdf");
        }
        public FileResult MvcDoc()
        {
            return File("~/Content/update.docx.", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}