using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
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
    }
}
