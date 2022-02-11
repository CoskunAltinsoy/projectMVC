using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class LandController : Controller
    {
        ILandService _landService;
        public LandController(ILandService landService)
        {
            _landService = landService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
