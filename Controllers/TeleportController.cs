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

            // move this type of logic to a helper function in continents processor, do the same where ever items are con
            var continentsItems = await ContinentsProcessor.LoadContinents();
            var continents = continentsItems._links.continentitems;
            //var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();

            //var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();

            var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
            var northAmericaCities = northAmericaUA._links.uaitems;
            var northAmericaScore = await ScoresProcessor.LoadNorthAmericaScores();

            {
                
                TeleportViewModel mymodel = new TeleportViewModel();
                mymodel.Continents = continents;
                mymodel.NorthAmericaUACities = northAmericaCities;
                mymodel.NorthAmericaScore = northAmericaScore;

                return View(mymodel);
            }


            //return View();
        }
    }
}
