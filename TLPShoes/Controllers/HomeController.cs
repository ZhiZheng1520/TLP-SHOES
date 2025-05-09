using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TLPShoes.Areas.Identity.Data;
using TLPShoes.Models;

namespace TLPShoes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly UserManager<TLPShoesUser> _userManager;

		public HomeController(ILogger<HomeController> logger, UserManager <TLPShoesUser> userManager)
        {
            _logger = logger;
			this._userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["UserID"] = _userManager.GetUserId(this.User);
            return View();
        }

        public IActionResult Home()
        {
            return View(); // Renders Views/Home/Home.cshtml
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Service()
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
