﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEMS_Study_Web.Models;
using CEMS_Study_Web.ViewModels;

namespace CEMS_Study_Web.Controllers
{
    public class Part75EMPController : Controller
    {
        CEMSStudyWebDbEntities1 db = new CEMSStudyWebDbEntities1();

        // GET: Part75
        [Route("Part75EMP")]
        public ActionResult Part75EMP()
        {
            //GET OBJECT
            var firstRow = db.Part75EMP.First(x => x.SectionNumber == "Full Regulation");

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

            vm.SectionHeadingList = db.Part75EMP.Select(x => x.SectionHeading).ToList();
            vm.SectionNumberList = db.Part75EMP.Select(x => x.SectionNumber).ToList();
            vm.SectionNameList = db.Part75EMP.Select(x => x.SectionName).ToList();

            Dispose();
            return View(vm);
        }

        [Route("Part75EMP/{sectionNumber?}")]
        public ActionResult Part75EMP(string sectionNumber)
        {
            //GET OBJECT
            var firstRow = db.Part75EMP.First(x => x.SectionNumber == sectionNumber);

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

            vm.SectionHeadingList = db.Part75EMP.Select(x => x.SectionHeading).ToList();
            vm.SectionNumberList = db.Part75EMP.Select(x => x.SectionNumber).ToList();
            vm.SectionNameList = db.Part75EMP.Select(x => x.SectionName).ToList();

            Dispose();
            return View(vm);
        }

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