using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using DemoLibrary2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Controllers
{
    public class TeleportController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();

            // move this type of logic to a helper function in continents processor, do the same where ever items are there.
            var continentItems = await ContinentsProcessor.LoadContinents();
            var continents = continentItems._links.continentitems;


            //var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
            //var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
            var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
            var northAmericaCities = northAmericaUA._links.uaitems;
            var northAmericaScore = await ScoresProcessor.LoadNorthAmericaScores();

            {
                TeleportViewModel mymodel = new TeleportViewModel();
                mymodel.Continents = continents;
                mymodel.NorthAmericaCities = northAmericaCities;
                mymodel.NorthAmericaScore = northAmericaScore;

                mymodel.ContinentsSelectList = new List<SelectListItem>();

                foreach (var continent in continents)
                {
                    mymodel.ContinentsSelectList.Add(new SelectListItem { Text = continent.name });
                }
                return View(mymodel);
            }
        }

        [HttpPost]
        public IActionResult Index(TeleportViewModel model)
        {
            var selectedContinent = model.SelectedContinent;

            return RedirectToAction("Table");
        }

        public async Task<IActionResult> Table()
        {

            var continentItems = await ContinentsProcessor.LoadContinents();
            var continents = continentItems._links.continentitems;


            //var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
            //var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
            var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
            var northAmericaCities = northAmericaUA._links.uaitems;
            var northAmericaScore = await ScoresProcessor.LoadNorthAmericaScores();
            {
                TeleportViewModel mymodel = new TeleportViewModel();
                mymodel.Continents = continents;
                mymodel.NorthAmericaCities = northAmericaCities;
                mymodel.NorthAmericaScore = northAmericaScore;

                mymodel.ContinentsSelectList = new List<SelectListItem>();

                foreach (var continent in continents)
                {
                    mymodel.ContinentsSelectList.Add(new SelectListItem { Text = continent.name });
                }
                return View(mymodel);
            }
        }

        // Your application should provide a drop-down list of continents,
        // and when one is selected, an ordered table of maximum 5 rows with
        // the following structure should be displayed

        // when one is selected, send a HTTP request to the controller
        // grab urban areas for continent "mymodel.NorthAmericaCities"
        // take them to a new view called Table

    }
}
