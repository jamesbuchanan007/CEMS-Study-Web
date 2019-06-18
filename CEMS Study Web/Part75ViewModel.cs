using System.Collections.Generic;

namespace CEMS_Study_Web
{
    public class Part75ViewModel
    {
        public int Part75EMPId { get; set; }
        public string Regulation { get; set; }
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }
        public string SectionHeading { get; set; }
        public List<string> TableOfContents { get; set; }
        public string Content { get; set; }
    }
}