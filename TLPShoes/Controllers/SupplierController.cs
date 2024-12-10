using Microsoft.AspNetCore.Mvc;

namespace TLPShoes.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
