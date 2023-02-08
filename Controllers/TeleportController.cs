using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DemoLibrary2.Controllers
{
    public class TeleportController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();
            var data = await TeleportProcessor.LoadTeleport();
            Console.WriteLine("FROM THE CONTROLLER 1");
            Console.WriteLine(data);
            Console.WriteLine("FROM THE CONTROLLER 2");
            return View(data);
        }
    }
}
