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
        private readonly IInitialNoteSheet initialNS;
        private readonly IInvitationForTender tender;
        private readonly ITenderOpening openingTender;
        private readonly INoa inoa;
        private readonly ILC ilc;
        private readonly IFinalApproval finalApproval;

        string result;
        public ProjectController(IProject _project, IBureau _bureau, IInitialNoteSheet initialNoteSheet, IInvitationForTender _tender,
            ITenderOpening _openingTender, INoa _noa, ILC _lc, IFinalApproval finalApproval           )
        {
            project = _project;
            bureau = _bureau;
            initialNS = initialNoteSheet;
            tender = _tender;
            openingTender = _openingTender;
            inoa = _noa;
            ilc = _lc;
            this.finalApproval = finalApproval;

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
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            try
            {
                ViewBag.Project = await project.GetProjectById(id);

                //Initial Notesheet panel:
                InitialNotesheetViewModel noteSheet = await initialNS.GetInitialNoteSheetByProjectId(id);
                ViewBag.InitialNS = noteSheet;


                //Invitation for Tender:
                List<InvitationForTenderViewModel> tenderList = await tender.GetAllInvitationForTender();
                InvitationForTenderViewModel inviteForTender =  tenderList.Where(m => m.ProjectId == id).FirstOrDefault();
                ViewBag.Tender = inviteForTender;

                //Tender Opening:
                List<TenderOpeningViewModel> tenderOpenings = await openingTender.GetAllTenderOpening();
                TenderOpeningViewModel  tenderOpening = tenderOpenings.Where(m => m.ProjectId == id).FirstOrDefault();
                ViewBag.TenderOpening = tenderOpening;

                //NOA:
                ViewBag.Noa = await inoa.GetNoaByProjectId(id);

                //LC:
                List<LcViewModel> lcList = await ilc.GetLCByProjectId(id);
                ViewBag.LC = lcList.Where(m => m.ProjectId == id).FirstOrDefault();

                //Final Approval:
                List<FinalApprovalViewModel> finalApprovalViewModels = await finalApproval.GetFinalApprovalByProjectId(id);
                if (finalApprovalViewModels.Count > 0)
                {
                    ViewBag.FinalApproval = finalApprovalViewModels.Where(m => m.ProjectId == id).FirstOrDefault();
                }

            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
            }
            return View();
        }
    }
}
