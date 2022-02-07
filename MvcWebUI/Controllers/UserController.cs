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
        [HttpGet]
        public IActionResult Add()
        {
            var model = new UserViewModels()
            {
                Roles = _roleService.GetAll()
            };
            return View("add",model);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return RedirectToAction("index");
        }

       [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _userService.GetById(id);
            var model = new UserViewModels()
            {
                Roles = _roleService.GetAll(),
                User = user             
            };
            return View("update",model);
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            _userService.Update(user);
            return RedirectToAction("index");
        }
    }
}
