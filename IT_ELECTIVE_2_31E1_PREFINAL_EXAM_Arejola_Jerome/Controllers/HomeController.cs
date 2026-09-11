using IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Arejola_Jerome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IT_ELECTIVE_2_31E1_PREFINAL_EXAM_Arejola_Jerome.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
