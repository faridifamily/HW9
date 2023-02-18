using HW9.DAL;
using HW9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace HW9.Controllers
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
            //var bookCount = BookRepository.Count();
            dynamic mymodel = new ExpandoObject();
            mymodel.BookCount = BookRepository.Count();
            mymodel.UserCount = UserRepository.Count();
            mymodel.LastTime = BookRepository.LastBorrowed();
            return View(mymodel);
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