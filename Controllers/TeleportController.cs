using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoLibrary2.Controllers
{
    public class TeleportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}