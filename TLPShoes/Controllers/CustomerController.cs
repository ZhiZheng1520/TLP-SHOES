using Microsoft.AspNetCore.Mvc;

namespace TLPShoes.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
