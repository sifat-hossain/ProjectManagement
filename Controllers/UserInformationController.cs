using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class UserInformationController : Controller
    {
        public IUserInformation userInformation;
        public UserInformationController(IUserInformation _userInformation)
        {
            userInformation = _userInformation;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
