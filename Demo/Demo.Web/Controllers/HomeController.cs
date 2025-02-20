using System.Diagnostics;
using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemcs _item;
        private readonly IProduct _product;
        public HomeController(ILogger<HomeController> logger, IItemcs item, [FromKeyedServices("Config2")] IProduct product)
        {
            _logger = logger;
            _item = item;
            _product = product;
        }

        public IActionResult Index()
        {
            var amount = _item.GetAmount();
            var price = _product.GetPrice();
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
