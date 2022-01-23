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
    public class POController : Controller
    {
        private readonly IPO pO;
        private readonly IProject project;
        string result;

        public POController(IPO _pO, IProject _project)
        {
            pO = _pO;
            project = _project;
        }
        public async Task<IActionResult> Index(int? ProjectId)
        {
            if (ProjectId != null)
            {
                ViewBag.POList = await pO.GetPOByProjectId(ProjectId);
            }
            else
            {
                ViewBag.POList = await pO.GetAllPO();
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PoViewModel poViewModel, IFormFile poAttachment)
        {
            if (poViewModel == null && poAttachment.Length <= 0)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await pO.CreatePO(poViewModel, poAttachment);
                }
            }
            catch
            {
                throw;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }
    }
}
