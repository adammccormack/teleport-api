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

            switch(selectedContinent)
            {
                case "North America":
                    return RedirectToAction("NorthAmericaTable");
                    break;
                case "South America":
                    return RedirectToAction("SouthAmericaTable");
                    break;
                case "Africa":
                    return RedirectToAction("AfricaTable");
                    break;
                case "Asia":
                    return RedirectToAction("AsiaTable");
                    break;
                case "Oceania":
                    return RedirectToAction("OceaniaTable");
                    break;
                case "Europe":
                    return RedirectToAction("EuropeTable");
                    break;
                case "Antarctica":
                    TempData["AlertMessage"] = "Sorry no urban areas for this continent : (";
                    return RedirectToAction("Index");
                    break;
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> NorthAmericaTable()
        {
            var mymodel = await ScoresProcessor.NorthAmerica.ProcessNameAndScores();
            return View(mymodel);
        }

        public async Task<IActionResult> AfricaTable()
        {
            var mymodel = await ScoresProcessor.Africa.ProcessNameAndScores();
            return View(mymodel);
        }

        public async Task<IActionResult> AsiaTable()
        {
            var mymodel = await ScoresProcessor.Asia.ProcessNameAndScores();
            return View(mymodel);
        }

        public async Task<IActionResult> SouthAmericaTable()
        {
            var mymodel = await ScoresProcessor.SouthAmerica.ProcessNameAndScores();
            return View(mymodel);
        }

        public async Task<IActionResult> OceaniaTable()
        {
            var mymodel = await ScoresProcessor.Oceania.ProcessNameAndScores();
            return View(mymodel);
        }

        public async Task<IActionResult> EuropeTable()
        {
            var mymodel = await ScoresProcessor.Europe.ProcessNameAndScores();
            return View(mymodel);
        }
    }
}
