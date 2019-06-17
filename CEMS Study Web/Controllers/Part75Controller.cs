using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEMS_Study_Web.RegulationsViewModel;

namespace CEMS_Study_Web.Controllers
{
    public class Part75Controller : Controller
    {
        // GET: Part75
        public ActionResult Part75()
        {
            Part75ViewModel vm = new Part75ViewModel
            {
                SectionNumber = "Full Regulation",
                SectionName = "Part 75",
                TableOfContents = new List<string>(),
                SiteAddress = "~/CEMS Study Web/CEMS Study Web/Views/Regulations/Part75Pages/Part75Introduction.cshtml"
                //NEED SECTION PAGE NAME FOR ROUTING
            };

            vm.TableOfContents.Add("Introduction");
            vm.TableOfContents.Add("Section 1.1 - General - Time-Shared Analysers");
            vm.TableOfContents.Add("Section 1.2 - General - Acceptable Monitors");
            vm.TableOfContents.Add("Section 2 - SO2 Monitoring");
            return View(vm);
        }

        public ActionResult Part75File(string url)
        {
            return View("~/Views/Part75/Introduction.cshtml");
        }
    }
}