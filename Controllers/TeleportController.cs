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
            return RedirectToAction("NorthAmericaTable");
        }

        // IDEA
        // once continent is selected, send that value to Table(selectedcontinent)
        // put an if statement OR a case/when statement inside table() controller, if selectedContinent matches one of these cases
        // then send only that model for that continents 5 cities to the view
        // the view then has a generic for each loop for the model based on city, score and summary.
        // each continents 5 city model will be pre-built and grouped in here.

        public async Task<IActionResult> NorthAmericaTable()
        {
            var mymodel = await ScoresProcessor.NorthAmerica.ProcessNameandScores();
            return View(mymodel);
        }

        public async Task<IActionResult> AfricaTable()
        {
            var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
            var AFCities = africaUA._links.uaitems;

            var cairoScore = await ScoresProcessor.LoadCairoScores();
            var capeTownScore = await ScoresProcessor.LoadCapeTownScores();
            var casablancaScore = await ScoresProcessor.LoadCasablancaScores();
            var lagosScore = await ScoresProcessor.LoadLagosScores();
            var NairobiScore = await ScoresProcessor.LoadNairobiScores();

            var cairo = AFCities[0];
            var capeTown = AFCities[1];
            var casablanca = AFCities[2];
            var lagos = AFCities[5];
            var Nairobi = AFCities[6];

            List<ScoresModel.Scores.Root> africaScores = new List<ScoresModel.Scores.Root>();

            List<UrbanAreasModel.UrbanAreas.UaItem> africaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

            return View();
        }

        public async Task<IActionResult> AsiaTable()
        {
            var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
            var ASCities = asiaUA._links.uaitems;

            var dohaScore = await ScoresProcessor.LoadDohaScores();
            var manilaScore = await ScoresProcessor.LoadManilaScores();
            var taipeiScore = await ScoresProcessor.LoadTaipeiScores();
            var hongKongScore = await ScoresProcessor.LoadHongKongScores();
            var tokyoScore = await ScoresProcessor.LoadTokyoScores();

            var doha = ASCities[11];
            var manila = ASCities[22];
            var taipei = ASCities[31];
            var hongKong = ASCities[15];
            var tokyo = ASCities[35];

            List<ScoresModel.Scores.Root> asiaScores = new List<ScoresModel.Scores.Root>();

            List<UrbanAreasModel.UrbanAreas.UaItem> asiaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

            return View();
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
