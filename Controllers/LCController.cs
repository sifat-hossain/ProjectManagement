using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class LCController : Controller
    {
        private readonly ILC lc;
        private readonly IProject project;
        string result;

        public LCController(ILC iLC, IProject _project)
        {
            lc = iLC;
            project = _project;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.listOfData = await lc.Details();
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
        public async Task<IActionResult> Create(LcViewModel viewModel)
        {
            try
            {
                if (viewModel.LCAttachmentFile.Length > 0 && ModelState.IsValid)
                {
                    result = await lc.Create(viewModel);
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
