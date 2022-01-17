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
    public class InvitationForTenderController : Controller
    {
        private readonly IInvitationForTender invitationForTender;
        private readonly IProject project;
        private readonly IVendorInformation vendorInformation;
        string result;
        public InvitationForTenderController(IInvitationForTender _invitationForTender, IProject _project, IVendorInformation _vendorInformation)
        {
            invitationForTender = _invitationForTender;
            project = _project;
            vendorInformation = _vendorInformation;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? ProjectId)
        {
            //var invitationForTenderList = await invitationForTender.GetAllInvitationForTender();
            //ViewBag.InvitationForTender = invitationForTenderList;
            //return View();
            


            //ProjectId = 1006;
            if (ProjectId != null)
            {
       
                InvitationForTenderViewModel tenderInvitation = await invitationForTender.GetInvitationForTendeByProjectId(ProjectId);
                ViewBag.InvitationForTender = tenderInvitation;

            }
            else
            {
                var invitationForTenderList = await invitationForTender.GetAllInvitationForTender();
                ViewBag.InvitationForTenderList = invitationForTenderList;
            }

            return View();


        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            ViewBag.VendorList = await vendorInformation.GetVendorInformation();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(InvitationForTenderViewModel invitationForTenderViewModel, IFormFile InvitationForTenderAttachment)
        {
            if(invitationForTenderViewModel==null)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await invitationForTender.CreateInvitationForTender(invitationForTenderViewModel, InvitationForTenderAttachment);
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
