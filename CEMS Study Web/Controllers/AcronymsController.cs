using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CEMS_Study_Web.Controllers
{
    public class AcronymsController : Controller
    {
        // GET: Acronyms
        public ActionResult Index()
        {
            return View();
        }
    }
}