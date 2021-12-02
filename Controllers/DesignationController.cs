using AspNetCoreHero.ToastNotification.Abstractions;
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
    public class DesignationController : Controller
    {
        private readonly IDesignation designation;
     
        string result ;

        public DesignationController(IDesignation _designation)
        {
            designation = _designation;
           
        }
        public async Task<IActionResult> Index()
        {

            var designationList = await designation.GetAllDesignation();
            ViewBag.GetAlldesignation = designationList;
            return View();
        }
        
        public IActionResult Create()
        {
            ViewBag.Message = TempData["result"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DesignationViewModel designationViewModel)
        
        {
            
            try
            {
                if(designationViewModel!=null)
                result = await designation.CreateDesignation(designationViewModel);
               
            }
           catch(Exception e)
            {
                result = e.Message;
              
            }
            TempData["result"] = result;
            return RedirectToAction(nameof(Create));
        }
            
        public IActionResult Edit(int? id)
        {
            DesignationViewModel designationViewModel = new();

            try
            {
                if(id!=null)
                {
                    designationViewModel = designation.GetDesignationById(id);
                }
               
            }
            catch(Exception e)
            {
                result = e.Message;
                TempData["result"] = result;
            }
            ViewBag.Message = TempData["result"];
            return View(designationViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(DesignationViewModel designationViewModel)
        {            
            try
            {
                result = await designation.UpdateDesignation(designationViewModel);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            TempData["result"] = result;
            return RedirectToAction("Edit", new{id= designationViewModel.DesignationId});
        }
    }
}
