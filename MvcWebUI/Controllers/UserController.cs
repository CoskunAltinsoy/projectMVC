using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        IRoleService _roleService;
        public UserController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetAll());
        }
        public IActionResult Add()
        {
            var model = new UserViewModels()
            {
                Roles = _roleService.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("index");
        }
    }
}
