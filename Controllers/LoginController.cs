using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class LoginController : Controller
    {
        public async Task<IActionResult> Signin()
        {
            return View();
        }
    }
}
