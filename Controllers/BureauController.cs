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
    public class BureauController : Controller
    {
        private readonly IBureau bureau;
        string result;
        public BureauController(IBureau _bureau)
        {
            bureau = _bureau;
        }
        // GET: BureauController
        public async Task<ActionResult> Index()
        {
            var bureauList = await bureau.GetAllBureau();
            ViewBag.GetAllBureau = bureauList;
            return View();
        }

        // GET: BureauController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: BureauController/Create
        public IActionResult Create()
        {
            ViewBag.Message = TempData["result"];
            return View();
        }

        // POST: BureauController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BureauViewModel bureauViewModel)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    result = await bureau.CreateBureau(bureauViewModel);
                }
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }

        // GET: BureauController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: BureauController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BureauController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: BureauController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
