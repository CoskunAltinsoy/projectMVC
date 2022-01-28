using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       
        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var model = _userService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(User user)
        {
            _userService.Update(user);  
            return RedirectToAction("index");
        }

        public IActionResult Delete(User user)
        {
            var model = _userService.GetById(user.Id);
            _userService.Delete(model);
            return RedirectToAction("index");
        }
    }
}
