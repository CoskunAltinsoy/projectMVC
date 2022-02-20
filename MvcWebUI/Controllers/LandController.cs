using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class LandController : Controller
    {
        ILandService _landService;
        IPropertyService _propertyService;
       
        public LandController(ILandService landService, IPropertyService propertyService)
        {
            _landService = landService;
            _propertyService = propertyService;           
        }
        public IActionResult Index()
        {
            return View(_landService.GetAll());
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            var model = new LandViewModel
            {
                Land = _landService.GetById(id),
                Property = _propertyService.GetById(id)
            };
            return View("add",model);
        }

        [HttpPost]
        public IActionResult Add(Land land)
        {
            _landService.Add(land);
            return RedirectToAction("index");
        }
    }
}
