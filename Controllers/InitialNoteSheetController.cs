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
    public class InitialNoteSheetController : Controller
    {
        private readonly IInitialNoteSheet initialNoteSheet;
        private readonly IProject project;
        private readonly IVendorInformation vendorInformation;
        string result;
        public InitialNoteSheetController(IInitialNoteSheet _initialNoteSheet, IProject _project,IVendorInformation _vendorInformation)
        {
            initialNoteSheet = _initialNoteSheet;
            project = _project;
            vendorInformation = _vendorInformation;
        }
        public async Task<IActionResult> Index()
        {
            var initialNoteSheetList= await initialNoteSheet.GetAllInitialNoteSheet();
            ViewBag.InitialNoteSheet = initialNoteSheetList;
            return View();
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            ViewBag.VendorList =await vendorInformation.GetVendorInformation();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InitialNotesheetViewModel initialNotesheetViewModel, IFormFile initialNotesheetAttachment)
        {
            if(initialNotesheetViewModel== null&& initialNotesheetAttachment.Length<0)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await initialNoteSheet.CreateInitialNoteSheet(initialNotesheetViewModel, initialNotesheetAttachment);
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
