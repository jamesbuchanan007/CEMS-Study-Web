using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEMS_Study_Web.Models;

namespace CEMS_Study_Web.Controllers
{
    public class Part75EMPController : Controller
    {
        CEMSStudyWebDbEntities _db = new CEMSStudyWebDbEntities();

        // GET: Part75
        public ActionResult Part75EMP()
        {
            //GET OBJECT
            var firstRow = _db.Part75EMP.First(x => x.Part75EMPId == 1);

            //LOAD VIEW MODEL
            Part75ViewModel vm = new Part75ViewModel
            {
                Regulation = firstRow.Regulation,
                SectionHeading = firstRow.SectionHeading,
                SectionNumber = firstRow.SectionNumber,
                SectionName = firstRow.SectionName,
                Content = firstRow.Content,
                TableOfContents = new List<string>()
                
            };

            //GET TABLE OF CONTENTS
            var tableOfContentsObjects = _db.Part75EMPTableOfContents.ToList();

            //LOAD TABLE OF CONTENTS TO VIEW MODEL
            foreach (var item in tableOfContentsObjects)
            {
                vm.TableOfContents.Add(item.Object);
            }

            Dispose();
            return View(vm);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        //public ActionResult Part75File(string url)
        //{

        //    return View();
        //}
    }
}