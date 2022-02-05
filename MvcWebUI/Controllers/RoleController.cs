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
    }
}
