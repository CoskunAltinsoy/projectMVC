using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class RoleController : Controller
    {
        IRoleService _roleService;
        //IUserService _userService;
        public RoleController(IRoleService roleService/*, IUserService userService*/)
        {
            _roleService = roleService;
           // _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_roleService.GetAll());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Role role)
        {      
            _roleService.Add(role);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var model = _roleService.GetById(id);
            return View("Update",model);
        }

        [HttpPost]
        public IActionResult Update(Role role)
        {
            _roleService.Update(role);
            return RedirectToAction("index");
        }

        public IActionResult Delete(Role role)
        {
            var model = _roleService.GetById(role.RoleId);
            _roleService.Delete(model);
            return RedirectToAction("index",model);
        }
    }
}
