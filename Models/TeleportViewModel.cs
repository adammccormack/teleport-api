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
		public ScoresModel.NorthAmericaScores.Root NorthAmericaScore { get; set; }


		//Dropdown related properties

		public string SelectedContinent { get; set; }
		public List<SelectListItem> ContinentsSelectList { get; set; }
    }
}
