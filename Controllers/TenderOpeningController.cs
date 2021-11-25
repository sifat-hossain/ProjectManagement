using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProjectManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.ViewModel;

namespace ProjectManagement.Controllers
{
    public class TenderOpeningController : Controller
    {
        private readonly ITenderOpening tenderOpening;
        private readonly IProject project;

        string result;
        public TenderOpeningController(ITenderOpening _tenderOpening, IProject _project)
        {
            tenderOpening = _tenderOpening;
            project = _project;
        }
        public async Task<IActionResult> Index()
        {
            var tenderopening = await tenderOpening.GetAllTenderOpening();
            ViewBag.TenderOpening = tenderopening;
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
        public async Task<IActionResult> Create(TenderOpeningViewModel tenderOpeningViewModel, IFormFile tenderOpeningAttachment)
        {
            if (tenderOpeningViewModel == null && tenderOpeningAttachment.Length < 0)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await tenderOpening.CreateTenderOpening(tenderOpeningViewModel, tenderOpeningAttachment);
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
