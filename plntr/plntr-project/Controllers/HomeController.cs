using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using plntr_project.Models;
using System.Diagnostics;

namespace plntr_project.Controllers
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

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Matchmaker()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Potm()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        public ActionResult DisplayImage(string imageName)
        {
            string imagePath = ("~/wwwroot/images/" + imageName);
            return File(imagePath, "image/jpeg");
        }
    }
}