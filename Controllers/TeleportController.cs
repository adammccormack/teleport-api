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
            var continents = await ContinentsProcessor.LoadContinents();
            var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
            return View(continents);
        }
    }
}
