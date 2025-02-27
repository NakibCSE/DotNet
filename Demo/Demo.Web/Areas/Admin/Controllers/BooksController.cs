using Demo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Areas.Admin.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(AddBookModel model)
        {
            return View(model);
        }
    }
}
