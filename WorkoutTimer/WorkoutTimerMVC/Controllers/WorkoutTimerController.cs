using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkoutTimerMVC.Controllers
{
    public class WorkoutTimerController : Controller
    {
        // GET: WorkoutTimer
        public ActionResult Index()
        {
            return View();
        }

        // GET: WorkoutTimer
        public ActionResult Settings()
        {
            return View();
        }

        // POST: WorkoutTimer
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}