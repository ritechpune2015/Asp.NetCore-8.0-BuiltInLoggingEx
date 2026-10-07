using Microsoft.AspNetCore.Mvc;

namespace BuiltInLoggingEx.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
        public IActionResult Index()
        {
            this.logger.LogInformation("Home Controller Index Action Called!");
            return View();
        }
        public IActionResult About()
        {
            this.logger.LogWarning("USer Called About Action");
            return View();
        }
        public IActionResult Contact()
        {
            this.logger.LogError("User Called Contact!");
            return View();
        }
    }
}
