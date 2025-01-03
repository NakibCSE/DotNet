using System.Diagnostics;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemcs _item;

        public HomeController(ILogger<HomeController> logger, IItemcs item)
        {
            _logger = logger;
            _item = item;
        }

        public IActionResult Index()
        {
            var amount = _item.GetAmount();
            _logger.LogInformation("I am in Index page.");
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
