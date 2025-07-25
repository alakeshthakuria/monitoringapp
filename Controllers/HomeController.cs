using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("App is running");
        }

        // Trigger HTTP 500
        public IActionResult Simulate500()
        {
            return StatusCode(500, "Custom 500 Error");
        }

        // Trigger HTTP 502
        public IActionResult Simulate502()
        {
            return StatusCode(502, "Custom 502 Error");
        }

        // Trigger HTTP 503
        public IActionResult Simulate503()
        {
            return StatusCode(503, "Custom 503 Error");
        }
    }
}

