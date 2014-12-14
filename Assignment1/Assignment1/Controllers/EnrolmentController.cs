using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Assignment1.Controllers
{
    public class EnrolmentController : Controller
    {
        //
        // GET: /Enrolment/

        [Authorize]
         public ActionResult Index()
        {
            return View();
        }

        

    }
}
