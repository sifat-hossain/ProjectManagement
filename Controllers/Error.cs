using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class Error : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)      
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, The Resource Cannot be Found";
               
                    break;
                default:
                    ViewBag.ErrorMessage = "Server Unreachable. Please Contact with Administrator";
                    break;
            }
            return View("Error");
        }
    }
}
