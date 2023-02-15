using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Controllers
{
    public class TeleportController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ApiHelper.InitializeClient();

            var continentItems = await ContinentsProcessor.LoadContinents();
            var continents = continentItems._links.continentitems;
            {
                TeleportViewModel model = new TeleportViewModel();
                model.Continents = continents;
                model.ContinentsSelectList = new List<SelectListItem>();
                foreach (var continent in continents)
                {
                    model.ContinentsSelectList.Add(new SelectListItem { Text = continent.name });
                }
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Index(TeleportViewModel model)
        {
            var selectedContinent = model.SelectedContinent;

            switch(selectedContinent)
            {
                case "North America":
                    return RedirectToAction("NorthAmericaTable");
                case "South America":
                    return RedirectToAction("SouthAmericaTable");
                case "Africa":
                    return RedirectToAction("AfricaTable");
                case "Asia":
                    return RedirectToAction("AsiaTable");
                case "Oceania":
                    return RedirectToAction("OceaniaTable");
                case "Europe":
                    return RedirectToAction("EuropeTable");
                case "Antarctica":
                    TempData["AlertMessage"] = "Sorry no urban areas for this continent : (";
                    return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> NorthAmericaTable()
        {
            var model = await ScoresProcessor.NorthAmerica.ProcessNameAndScores();
            return View(model);
        }

        public async Task<IActionResult> AfricaTable()
        {
            var model = await ScoresProcessor.Africa.ProcessNameAndScores();
            return View(model);
        }

        public async Task<IActionResult> AsiaTable()
        {
            var model = await ScoresProcessor.Asia.ProcessNameAndScores();
            return View(model);
        }

        public async Task<IActionResult> SouthAmericaTable()
        {
            var model = await ScoresProcessor.SouthAmerica.ProcessNameAndScores();
            return View(model);
        }

        public async Task<IActionResult> OceaniaTable()
        {
            var model = await ScoresProcessor.Oceania.ProcessNameAndScores();
            return View(model);
        }

        public async Task<IActionResult> EuropeTable()
        {
            var model = await ScoresProcessor.Europe.ProcessNameAndScores();
            return View(model);
        }
    }
}
