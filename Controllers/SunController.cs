using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DemoLibrary2.Controllers
{
    public class SunController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();
            var data = await SunProcessor.LoadSunData();
            Console.WriteLine("HEY");
            Console.WriteLine(data);
            Console.WriteLine("HERE");
            return View();
        }
    }
}