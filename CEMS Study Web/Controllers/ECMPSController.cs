using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CEMS_Study_Web.Controllers
{
    public class ECMPSController : Controller
    {
        // GET: ECMPS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MonitoringReporting()
        {
            return View();
        }
        public ActionResult QAReporting()
        {
            return View();
        }
        public ActionResult EmissionsReporting()
        {
            return View();
        }
        public ActionResult PGV()
        {
            return View();
        }
        public ActionResult GHG()
        {
            return View();
        }
        public ActionResult MATSTransition()
        {
            return View();
        }
        public ActionResult MATSGuidance()
        {
            return View();
        }

    }
}