using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HangFire_MVC_5_WebApp.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddEnqueue()
        {
            BackgroundJob.Enqueue(() => Console.WriteLine("Fire-and-forget!"));
            return RedirectToAction("Index", "Hangfire");
        }

        public ActionResult AddDelayed()
        {
            BackgroundJob.Schedule(() => Console.WriteLine("Hello, world. After a Days :)"), TimeSpan.FromDays(1));
            return RedirectToAction("Index", "Hangfire");
        }

        public ActionResult AddRecurring()
        {
            RecurringJob.AddOrUpdate("Job-1", () => Console.Write("Easy!"), Cron.Minutely);
            return RedirectToAction("Index", "Hangfire");
        }

        public ActionResult RemoveRecurring()
        {
            RecurringJob.RemoveIfExists("Job-1");
            return RedirectToAction("Index", "Hangfire");
        }
        
    }
}