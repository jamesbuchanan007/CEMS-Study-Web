using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEMS_Study_Web.Models;
using CEMS_Study_Web.ViewModels;

namespace CEMS_Study_Web.Controllers
{
    public class Part60AppBController : Controller
    {
        CEMSStudyWebDbEntities1 db = new CEMSStudyWebDbEntities1();

        // GET: Part60AppendixB
        [Route("Part60AppB")]
        public ActionResult Part60AppB()
        {
            //GET OBJECT
            var firstRow = db.Part60AppB.First(x => x.SectionNumber == "Full Regulation");

            //LOAD VIEW MODEL
            Part75EMPViewModel vm = new Part75EMPViewModel
            {
                Regulation = firstRow.Regulation,
                SectionHeading = firstRow.SectionHeading,
                SectionNumber = firstRow.SectionNumber,
                SectionName = firstRow.SectionName,
                Content = firstRow.Content,
                SectionNumberList = new List<string>(),
                SectionHeadingList = new List<string>(),
                SectionNameList = new List<string>(),
            };

            vm.SectionHeadingList = db.Part60AppB.Select(x => x.SectionHeading).ToList();
            vm.SectionNumberList = db.Part60AppB.Select(x => x.SectionNumber).ToList();
            vm.SectionNameList = db.Part60AppB.Select(x => x.SectionName).ToList();

            Dispose();
            return View(vm);
        }

        [Route("Part60AppB/{sectionNumber?}")]
        public ActionResult Part60AppB(string sectionNumber)
        {
            //GET OBJECT
            var firstRow = db.Part60AppB.First(x => x.SectionNumber == sectionNumber);


            //LOAD VIEW MODEL
            Part75EMPViewModel vm = new Part75EMPViewModel
            {
                Regulation = firstRow.Regulation,
                SectionHeading = firstRow.SectionHeading,
                SectionNumber = firstRow.SectionNumber,
                SectionName = firstRow.SectionName,
                Content = firstRow.Content,
                SectionNumberList = new List<string>(),
                SectionHeadingList = new List<string>(),
                SectionNameList = new List<string>(),
            };

            vm.SectionHeadingList = db.Part60AppB.Select(x => x.SectionHeading).ToList();
            vm.SectionNumberList = db.Part60AppB.Select(x => x.SectionNumber).ToList();
            vm.SectionNameList = db.Part60AppB.Select(x => x.SectionName).ToList();

            Dispose();
            return View(vm);
        }
    }
}