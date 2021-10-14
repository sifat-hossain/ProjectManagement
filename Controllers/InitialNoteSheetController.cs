using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class InitialNoteSheetController : Controller
    {
        private readonly IInitialNoteSheet initialNoteSheet;
        public InitialNoteSheetController(IInitialNoteSheet _initialNoteSheet)
        {
            initialNoteSheet = _initialNoteSheet;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
