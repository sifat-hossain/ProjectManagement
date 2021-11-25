using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class UserInformationController : Controller
    {
        private readonly IUserInformation userInformation;
        private readonly IDesignation designation;
        private readonly IUserRole userRole;
        string result;
        public UserInformationController(IUserInformation _userInformation, IDesignation _designation, IUserRole _userRole)
        {
            userInformation = _userInformation;
            designation = _designation;
            userRole = _userRole;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.UserInfo = await userInformation.GetAllUserInformation();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.Designation = await designation.GetAllDesignation();
            ViewBag.UserRole = await userRole.GetAllUserRole();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserInformationViewModel userInformationViewModel)
        {
            if(userInformationViewModel==null)
            {
               return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await userInformation.CreateUser(userInformationViewModel);
                }
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }
    }
}
