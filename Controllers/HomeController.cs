using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProject project;
        public HomeController(ILogger<HomeController> logger, IProject _project)
        {
            _logger = logger;
            project = _project;
        }

        public async Task<IActionResult> Index()
        {
            int count = 0;
            List<ProjectViewModel> amount =await  project.GetAllProject();
            foreach(var item in amount)
            {
                count++;
            }
            ViewBag.ProjectAmount = count;
            return View();
        }
        //public IActionResult Error(int statusCode)
        //{
        //    switch (statusCode)
        //    {
        //        case 404:
        //            ViewBag.ErrorMessage = "Sorry, The Resource Cannot be Found";
        //            break;
        //        default: 
        //            break;
        //    }
        //    return View("Not Fount");
        //}
       

    }
}
