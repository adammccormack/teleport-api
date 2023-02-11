using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel
	{
		public List<ContinentsModel.ContinentItem> Continents { get; set; }

		public List<UrbanAreasModel.UrbanAreas.UaItem> NorthAmericaCities { get; set; }

        public List<UrbanAreasModel.UrbanAreas.UaItem> NACities { get; set; }
        public List<ScoresModel.Scores.Root> NAScores { get; set; }

        //Dropdown related properties

        public string? SelectedContinent { get; set; }
		public List<SelectListItem>? ContinentsSelectList { get; set; }

    }
}
