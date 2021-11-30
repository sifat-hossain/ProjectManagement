using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class PSIMemberController : Controller
    {
        private readonly IPSIMember pSIMember;
        private readonly IProject project;
        private readonly IUserInformation userInformation;
        string result;
        public PSIMemberController(IPSIMember _pSImember, IProject _project, IUserInformation _userInformation)
        {
            pSIMember = _pSImember;
            project = _project;
            userInformation = _userInformation;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.PsiMemberList = await pSIMember.GetAllPsimember();
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
        public async Task<IActionResult> Create(PsiMemberViewModel pSIMemberViewModel)
        {
            if(pSIMemberViewModel== null)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await pSIMember.CreatepsiMember(pSIMemberViewModel);
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
