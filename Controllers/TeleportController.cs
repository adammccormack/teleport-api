using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using DemoLibrary2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoLibrary2.Controllers
{
    public class TeleportController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();

            // These are models, pass them to ViewModel
            var continents = await ContinentsProcessor.LoadContinents();

            //var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();

            //var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();

            //var naUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();

            //var naScore = await ScoresProcessor.LoadNorthAmericaScores();

            {
                
                TeleportViewModel mymodel = new TeleportViewModel();
                mymodel.Continents = continents;
                
                return View(mymodel);
            }


            //return View();
        }
    }
}
