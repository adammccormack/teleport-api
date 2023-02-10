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

            //TODO: Refactor all of this

            // move this type of logic to a helper function in continents processor, do the same where ever items are there.
            var continentItems = await ContinentsProcessor.LoadContinents();
            var continents = continentItems._links.continentitems;

            {
                TeleportViewModel mymodel = new TeleportViewModel();
                mymodel.Continents = continents;

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

            //var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
            //var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
            var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
            var northAmericaCities = northAmericaUA._links.uaitems;
            var northAmericaScore = await ScoresProcessor.LoadNorthAmericaScores();

            {
                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.NorthAmericaCities = northAmericaCities;
                mymodel.NorthAmericaScore = northAmericaScore;


                return View(mymodel);
            }
        }

        // Your application should provide a drop-down list of continents,
        // and when one is selected, an ordered table of maximum 5 rows with
        // the following structure should be displayed

        // should grab top 5 NorthAmericaCities.name, top 5 NorthAmericaScore.teleport_city_score and top 5 NorthAmericaScore.summary
        // put them into one object and pass into the view.
        // If I can do this for all the continents, put each top 5 cities, score and summary into their own objects, then I can update
        // the table dynamically.


        //https://developers.teleport.org/api/reference/#/
        // with this page, once I click on a city from the list, can perhaps get the request URL https://api.teleport.org/api/cities/?search=albuquerque
        // then set the api call to be dynamic based on the city you click on, thereby making one api function that searches dynamically.

        // still should choose top 5 cities for each continent first. 

    }
}
