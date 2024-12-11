using Microsoft.AspNetCore.Mvc;

namespace TLPShoes.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult EditProducts()
        {
            return View();
        }

        public IActionResult EditProfile()
        {
            return View();
        }
    }
}
