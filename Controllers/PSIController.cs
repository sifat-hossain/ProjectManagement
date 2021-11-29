using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class PSIController : Controller
    {
        private readonly IPSI pSI;
        private readonly IProject project;

        string result;
        public PSIController(IPSI _pSI, IProject _project)
        {
            pSI = _pSI;
            project = _project;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.PsiList = await pSI.GetAllPSI();
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
        public async Task<IActionResult> Create(PsiViewModel psiViewModel)
        {
            if(psiViewModel==null)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await pSI.CreatePSI(psiViewModel);
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
