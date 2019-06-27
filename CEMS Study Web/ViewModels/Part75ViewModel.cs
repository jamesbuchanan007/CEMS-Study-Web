using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEMS_Study_Web.ViewModels
{
    public class Part75ViewModel
    {
        public string Regulation { get; set; }
        public string Subpart { get; set; }
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }
        public string Content { get; set; }
        public List<string> SectionNameList { get; set; }
        public List<string> SubpartList { get; set; }
        public List<string> SectionNumberList { get; set; }
    }
}
}