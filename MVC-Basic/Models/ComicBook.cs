using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Basic.Models
{
    public class ComicBook
    {

        public int Id { get; set; }
        public string IssueTitle { get; set; }
        public int IssueNumber { get; set; }
        public string description { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favourit { get; set; }
    }
}