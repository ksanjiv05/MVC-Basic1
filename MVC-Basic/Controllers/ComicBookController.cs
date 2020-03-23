using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Basic.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        public ActionResult Details()
        {
            if(DateTime.Today.DayOfWeek==DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
            return new ContentResult()
            {
                Content = "Hii this is my first MVC Project"
            };
            
        }
    }
}