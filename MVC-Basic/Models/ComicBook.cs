using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Basic.Models
{
    public class ComicBook
    {

        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string description { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favourit { get; set; }

        public string DisplayText
        {
            get {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        public string FileName {
            get {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}