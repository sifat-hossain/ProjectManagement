using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class RankTypeController : Controller
    {
        private readonly IRankType rankType;

         string result;
        public RankTypeController(IRankType _rankType)
        {
            rankType = _rankType;
        }
        public async Task<IActionResult> Index()
        {
            var rankTypeList = await rankType.GetAllRankType();
            ViewBag.GetAllRankType = rankTypeList;
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Message = TempData["result"];
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Create(RankTypeViewModel rankTypeViewModel)
        {
            try
            {
                if(rankTypeViewModel!=null)
                {
                    result = await rankType.CreateRankType(rankTypeViewModel);
                }
            }
            catch(Exception e)
            {
                result = e.Message;
                TempData["result"] = result;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }

        public IActionResult Edit(int? id)
        {
            RankTypeViewModel rankTypeViewModel = new();
            try
            {
                if (id != null)
                {
                    rankTypeViewModel = rankType.GetRankTypeById(id);
                }
            }
            catch (Exception e)
            {
                result = e.Message;
                TempData["result"] = result;
            }
            ViewBag.Message = TempData["result"];
            return View(rankTypeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(RankTypeViewModel rankTypeViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    result = await rankType.UpdateRankType(rankTypeViewModel);
                }
            }
            catch(Exception e)
            {
                result = e.Message;
                
            }
            TempData["result"] = result;
            return RedirectToAction("Edit", new { id = rankTypeViewModel.RankTypeId });
        }
    }
}
