using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel

	{
        public List<UrbanAreasModel.UrbanAreas.UaItem> NACities { get; set; }
        public List<ScoresModel.Scores.Root> NAScores { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> AFCities { get; set; }
        public List<ScoresModel.Scores.Root> AFScores { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> AsiaCities { get; set; }
        public List<ScoresModel.Scores.Root> AsiaScores { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> SouthAmericaCities { get; set; }
        public List<ScoresModel.Scores.Root> SouthAmericaScores { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> OceaniaCities { get; set; }
        public List<ScoresModel.Scores.Root> OceaniaScores { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> EuropeCities { get; set; }
        public List<ScoresModel.Scores.Root> EuropeScores { get; set; }

        public List<ContinentsModel.ContinentItem> Continents { get; set; }
        public string? SelectedContinent { get; set; }
        public List<SelectListItem>? ContinentsSelectList { get; set; }
    }
}
