using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class FinalApprovalController : Controller
    {
        private readonly IFinalApproval finalApproval;
        private readonly IProject project;
        private readonly IUserInformation userInformation;
        string result;

        public FinalApprovalController(IFinalApproval _finalApproval, IProject _project, IUserInformation _userInformation)
        {
            finalApproval = _finalApproval;
            project = _project;
            userInformation = _userInformation;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.FinalApproval = await finalApproval.GetAllFinalApproval();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.ProjectList = await project.GetAllProject();
            ViewBag.UserList = await userInformation.GetAllUserInformation();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FinalApprovalViewModel finalApprovalViewModel, IFormFile finalApprovalAttachment)
        {
            if(finalApprovalViewModel == null || finalApprovalAttachment.Length==0)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await finalApproval.CreateFinalApproval(finalApprovalViewModel, finalApprovalAttachment);
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
