using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class PgVerificationController : Controller
    {
        public readonly IPGVerification pGVerification;
        public readonly INoa noa;
        string result;
        public PgVerificationController(IPGVerification _pGVerification, INoa _noa)
        {
            pGVerification = _pGVerification;
            noa = _noa;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.PgVerificationList = await pGVerification.GetAllPgVerification();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.Noa = await noa.GetAllNoa();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PgVerificationViewModel pgVerificationViewModel)
        {
            if(pgVerificationViewModel==null)
            {
                return NotFound();
            }
            try
            {
                if(ModelState.IsValid)
                {
                    result = await pGVerification.CreatePgVerification(pgVerificationViewModel);
                }
            }
            catch(Exception ex)
            {
                result = ex.Message;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }
    }
}
