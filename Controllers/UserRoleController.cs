using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class UserRoleController : Controller
    {
        private readonly IUserRole userRole;
        string result;
        public UserRoleController(IUserRole _userRole)
        {
            userRole = _userRole;
        }
        public async Task<IActionResult> Index()
        {
            var userRoleList = await userRole.GetAllUserRole();
            ViewBag.UserRoleList = userRoleList;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Message = TempData["result"];
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRoleViewModel userRoleViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    result = await userRole.CreateUserRole(userRoleViewModel);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
        UserRoleViewModel userRoleViewModel = new();

            try
            {
                if (id != null)
                {
                    userRoleViewModel = userRole.GetUserRoleById(id);
                }

            }
            catch (Exception e)
            {
                result = e.Message;
                TempData["result"] = result;
            }
            ViewBag.Message = TempData["result"];
            return View(userRoleViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserRoleViewModel userRoleViewModel)
        {
            try
            {
                result = await userRole.UpdateUserRole(userRoleViewModel);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction("Edit", new { id = userRoleViewModel.UserRoleId });
        }
    }
}
