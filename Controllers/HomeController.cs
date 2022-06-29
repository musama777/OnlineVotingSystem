using Microsoft.AspNetCore.Mvc;
using OnlineVotingSystem.Models;
using System.Diagnostics;

namespace OnlineVotingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public String Index(string? firstname=null, string? lastname=null)
        {
            HelloController obj = new HelloController();
            return obj.Index(firstname, lastname);
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