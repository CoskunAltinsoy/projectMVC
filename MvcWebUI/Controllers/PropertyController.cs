using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class PropertyController : Controller
    {
        IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
                _propertyService = propertyService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
