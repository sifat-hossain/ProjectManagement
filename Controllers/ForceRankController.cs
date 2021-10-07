using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class ForceRankController : Controller
    {
        private readonly IForceRank forceRank;
        private readonly IRankType rankType;
        string result;

        public ForceRankController(IForceRank _forceRank, IRankType _rankType)
        {
            forceRank = _forceRank;
            rankType = _rankType;
        }
        public async Task<IActionResult> Index()
        {
            var forcerank = await forceRank.GetAllForceRank();
            return View(forcerank);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Message = TempData["result"];
            ViewBag.RankType = await rankType.GetAllRankType();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ForceRankViewModel forceRankViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    result = await forceRank.CreateForceRank(forceRankViewModel);
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
        public async Task<IActionResult> Edit(int? id)
        {
            ForceRankViewModel forceRankViewModel = new();
            try
            {
                if (id != null)
                {
                    forceRankViewModel = forceRank.GetForceRankById(id);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            ViewBag.RankType = await rankType.GetAllRankType();
            return View(forceRankViewModel);
        }
    }
}
