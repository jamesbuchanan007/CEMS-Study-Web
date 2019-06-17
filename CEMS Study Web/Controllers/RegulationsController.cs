using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using CEMS_Study_Web.RegulationsViewModel;
using Microsoft.Ajax.Utilities;

namespace CEMS_Study_Web.Controllers
{
    public class RegulationsController : Controller
    {
        // GET: Regulations
        //public ActionResult Part75()
        //{
        //    RegualtionsViewModel vm = new RegualtionsViewModel
        //    {
        //        SectionNumber = "Full Regulation",
        //        SectionName = "Part 75",
        //        TableOfContents =  new List<string>(),
        //        SiteAddress = "~/CEMS Study Web/CEMS Study Web/Views/Regulations/Part75Pages/Part75Introduction.cshtml"
        //        //NEED SECTION PAGE NAME FOR ROUTING
        //    };

        //    vm.TableOfContents.Add("Introduction");
        //    vm.TableOfContents.Add("Section 1.1 - General - Time-Shared Analysers");
        //    vm.TableOfContents.Add("Section 1.2 - General - Acceptable Monitors");
        //    vm.TableOfContents.Add("Section 2 - SO2 Monitoring");

        //    return View(vm);
        //}

        public ActionResult Part75PlainEnglish()
        {
            return View();
        }
        public ActionResult Part75FieldAudit()
        {
            return View();
        }
        public ActionResult Part75AppendixD()
        {
            return View();
        }
        public ActionResult Part60AppendixB()
        {
            return View();
        }
        public ActionResult Part60AppendixF()
        {
            return View();
        }
        public ActionResult Part63SubpartUUUUU()
        {
            return View();
        }


    }
}