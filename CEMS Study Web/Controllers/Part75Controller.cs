using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEMS_Study_Web.Models;
using CEMS_Study_Web.ViewModels;

namespace CEMS_Study_Web.Controllers
{
    public class Part75Controller : Controller
    {
        CEMSStudyWebDbEntities1 db = new CEMSStudyWebDbEntities1();
        // GET: Part75
        public ActionResult Part75()
        {
            //LOAD VIEW MODEL
            Part75ViewModel vm = new Part75ViewModel
            {
                Regulation = "Part 75 Continuous Emission Monitoring",
                Subpart = "",
                SectionNumber = "1",
                SectionName = "",
                Content = "",
                SectionNumberList = new List<string>(),
               SubpartList = new List<string>(),
                SectionNameList = new List<string>(),
            };

            Dispose();
            return View(vm);
        }

        //[Route("Part75/{sectionNumber?}")]
        //public ActionResult Part75(string sectionNumber)
        //{
        //    //GET OBJECT
        //    var firstRow = db.Part75.First(x => x.SectionNumber == sectionNumber);

        //    //LOAD VIEW MODEL
        //    Part75ViewModel vm = new Part75ViewModel
        //    {
        //        Regulation = firstRow.Regulation,
        //        Subpart = firstRow.Subpart,
        //        SectionNumber = firstRow.SectionNumber,
        //        SectionName = firstRow.SectionName,
        //        Content = firstRow.Content,
        //        SectionNumberList = new List<string>(),
        //        SubpartList = new List<string>(),
        //        SectionNameList = new List<string>(),
        //    };

        //    vm.SectionNumberList = db.Part75.Select(x => x.SectionNumber).ToList();
        //    vm.SubpartList = db.Part75.Select(x => x.Subpart).ToList();
        //    vm.SectionNameList = db.Part75.Select(x => x.SectionName).ToList();

        //    Dispose();
        //    return View(vm);
        //}

        //DISPOSE DB
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}