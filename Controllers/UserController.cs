using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminLTEASPNETEmployees.Controllers
{
    public class UserController : Controller
    {
        [Authorize(Roles = "2")]
        public IActionResult User()
        {
            return View();
        }
    }
}
