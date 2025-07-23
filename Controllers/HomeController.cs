using Microsoft.AspNetCore.Mvc;

namespace MonitoringApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("App is running and being monitored!");
        }
    }
}

