using System.Collections.Generic;

namespace CEMS_Study_Web
{
    public class Part75EMPViewModel
    {
        public string Regulation { get; set; }
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }
        public string SectionHeading { get; set; }
        public string Content { get; set; }
        public List<string> SectionNameList { get; set; }
        public List<string> SectionHeadingList { get; set; }
        public List<string> SectionNumberList { get; set; }
    }
}