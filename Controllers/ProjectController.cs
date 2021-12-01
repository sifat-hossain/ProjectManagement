using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.ViewModel;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProject project;
        private readonly IBureau bureau;

        string result;
        public ProjectController(IProject _project, IBureau _bureau)
        {
            project = _project;
            bureau = _bureau;

        }
        public async Task<IActionResult> Index()
        {
            var projectList = await project.GetAllProject();
            ViewBag.Project = projectList;
            return View();
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.BureauList = await bureau.GetAllBureau();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectViewModel projectViewModel, IFormFile ProjectAttachment)
        {
            try
            {
                if (ProjectAttachment.Length > 0 && ModelState.IsValid)
                {
                    result = await project.CreateProject(projectViewModel, ProjectAttachment);
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
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            try
            {
                ViewBag.Project = project.GetProjectById(id);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return View();
        }
    }
}
