using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class NoaController : Controller
    {
        private readonly INoa noa;
        private readonly IProject project;

        public NoaController(INoa _noa, IProject _project)
        {
            noa = _noa;
            project = _project;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Noa = await noa.GetAllNoa();
            return View();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            return View();
        }
    }
}
