using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class PIController : Controller
    {
        private readonly IPI pi;
        private readonly IProject project;
        string result;

        public PIController(IPI iPI, IProject _project)
        {
            pi = iPI;
            project = _project;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.listOfData = await pi.GetAllPI();
            return View();
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PiViewModel viewModel)
        {
            try
            {
                if (viewModel.PIAttachmentFile.Length > 0 && ModelState.IsValid)
                {
                    result = await pi.CreatePI(viewModel);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }

    }
}
