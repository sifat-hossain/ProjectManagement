using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.ViewModel;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProject projet;
        string result;
        public ProjectController(IProject _project)
        {
            projet = _project;
        }
        public async Task<IActionResult> Index()
        {
            var projectList= await projet.GetAllProject();
            ViewBag.Project = projectList;
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Message = TempData["result"];
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectViewModel projectViewModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    result =await projet.CreateProject(projectViewModel);
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
