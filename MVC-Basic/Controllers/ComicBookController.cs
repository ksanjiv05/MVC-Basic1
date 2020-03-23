using MVC_Basic.Data;
using MVC_Basic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basic.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBookRepositry _bookRepositry = null;
        public ComicBookController()
        {
            _bookRepositry = new ComicBookRepositry();
        }
        // GET: ComicBook
        //public ActionResult Details()
        //{
        //    if(DateTime.Today.DayOfWeek==DayOfWeek.Monday)
        //    {
        //        return new RedirectResult("/");
        //    }
        //    return new ContentResult()
        //    {
        //        Content = "Hii this is my first MVC Project"
        //    };

        //}

        //using view bag
        //public ActionResult Details()
        //{


        //    ViewBag.SeriesTitle = "The Amazing Spider-Man";
        //    ViewBag.IssueNumber = 700;
        //    ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
        //    ViewBag.Artists = new string[]
        //    {
        //        "Script: Dan Slott",
        //        "Pencils: Humberto Ramos",
        //        "Inks: Victor Olazaba",
        //        "Colors: Edgar Delgado",
        //        "Letters: Chris Eliopoulos"
        //    };
        //    return View();
        //}

        //public ActionResult Details()
        //{
        //var ComicBook = new ComicBook()
        //{
        //    SeriesTitle = "The Amazing Spider-Man",
        //    IssueNumber = 700,
        //    description = "< p > Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
        //    Artist = new Artist[]
        //    {
        //        new Artist(){ Name = "Dan Slott",Role = "Script" },
        //        new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
        //        new Artist() { Name = "Victor Olazaba", Role = "Inks" },
        //        new Artist() { Name = "Chris Eliopoulos", Role = "Colors" },

        //    }
        //};
        //return View(ComicBook);
        // return View(new ComicBookRepositry());

        //}

        public ActionResult Details(int? id)//? it is used to make nullable it means if u call this method without parameter it called without error
        {
            if (id == null)
                return HttpNotFound();
            return View(_bookRepositry.GetBook(id.Value));//the nullable type need type casting use Value properties or (int)id
        }
    }
}