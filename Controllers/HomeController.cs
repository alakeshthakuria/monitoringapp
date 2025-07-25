using Microsoft.AspNetCore.Mvc;
using System;

namespace MonitoringApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("App is running");
        }

        public IActionResult Simulate500()
        {
            return StatusCode(500, "Custom 500 Error");
        }

        public IActionResult Simulate502()
        {
            return StatusCode(502, "Custom 502 Error");
        }

        public IActionResult Simulate503()
        {
            return StatusCode(503, "Custom 503 Error");
        }

        // ✅ Add this method to throw an actual exception
        public IActionResult TriggerException()
        {
            throw new Exception("This is a simulated application-level exception.");
        }
    }
}

