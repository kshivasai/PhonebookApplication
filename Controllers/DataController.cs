using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhonebookApplication.Models;

namespace PhonebookApplication.Controllers
{
    public class DataController : Controller
    {
        // GET: Data

        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Data()
        {
            return View();
        }
        
        public ActionResult Phonesave()
        {
            return View();
        }
    }
}