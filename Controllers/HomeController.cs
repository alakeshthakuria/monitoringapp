using Microsoft.AspNetCore.Mvc;
using System;

namespace MonitoringApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("App is running and being monitored!");
        }

        public IActionResult GenerateError()
        {
            // This will throw a test exception
            throw new Exception("This is a test exception to verify Application Insights logging.");
        }
    }
}

