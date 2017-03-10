using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class TrackController : Controller
    {

        private Manager m = new Manager();
        // GET: Track
        public ActionResult AllTracks()
        {
            var l = m.TrackGetAll();
            return View(l);
        }

        public ActionResult PopTracks()
        {
            var l = m.TrackGetAllPop();
            return View(l);
        }

        public ActionResult DeepPurple()
        {
            var l = m.TrackGetAllDeepPurple();
            return View(l);
        }

        public ActionResult Top100Longest()
        {
            var l = m.TrackGetAllTop100Longest();
            return View(l);
        }

        // GET: Track/Details/5

    }
}
