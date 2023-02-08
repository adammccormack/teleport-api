using System;
using DemoLibrary2.Models;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel
	{
		public ContinentsModel.Root Continents { get; set; }
		public UrbanAreasModel.AfricaUrbanAreas.Root AfricaUA { get; set; }
		public List<UrbanAreasModel.NorthAmericaUrbanAreas.UaItem> NorthAmericaUA { get; set; }
    }
}

