using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
