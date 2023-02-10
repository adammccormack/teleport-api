using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel
	{
		public List<ContinentsModel.ContinentItem> Continents { get; set; }

		public UrbanAreasModel.AfricaUrbanAreas.Root AfricaUA { get; set; }

		public List<UrbanAreasModel.NorthAmericaUrbanAreas.UaItem> NorthAmericaCities { get; set; }
		public ScoresModel.NorthAmericaScores.Root BostonScore { get; set; }
		public ScoresModel.NorthAmericaScores.Root LasVegasScore { get; set; }
        public ScoresModel.NorthAmericaScores.Root NewYorkScore { get; set; }

        public UrbanAreasModel.NorthAmericaUrbanAreas.UaItem Boston { get; set; }
        public UrbanAreasModel.NorthAmericaUrbanAreas.UaItem LasVegas { get; set; }
        public UrbanAreasModel.NorthAmericaUrbanAreas.UaItem NewYork { get; set; }

        //Dropdown related properties

        public string? SelectedContinent { get; set; }
		public List<SelectListItem>? ContinentsSelectList { get; set; }

    }
}
