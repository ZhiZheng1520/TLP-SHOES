using Microsoft.AspNetCore.Mvc;

namespace TLPShoes.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
