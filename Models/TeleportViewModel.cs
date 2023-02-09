using System;
using DemoLibrary2.Models;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel
	{
		public List<ContinentsModel.ContinentItem> Continents { get; set; }
		public UrbanAreasModel.AfricaUrbanAreas.Root AfricaUA { get; set; }
		public List<UrbanAreasModel.NorthAmericaUrbanAreas.UaItem> NorthAmericaUACities { get; set; }
		public ScoresModel.NorthAmericaScores.Root NorthAmericaScore { get; set; }
    }
}

