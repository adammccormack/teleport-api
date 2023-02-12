using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel

	{   //North America
        public List<UrbanAreasModel.UrbanAreas.UaItem> NACities { get; set; }
        public List<ScoresModel.Scores.Root> NAScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem Boston { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem LasVegas { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem NewYork { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem WashingtonDC { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Miami { get; set; }

        public ScoresModel.Scores.Root BostonScore { get; set; }
        public ScoresModel.Scores.Root LasVegasScore { get; set; }
        public ScoresModel.Scores.Root NewYorkScore { get; set; }
        public ScoresModel.Scores.Root WashingtonDCScore { get; set; }
        public ScoresModel.Scores.Root MiamiScore { get; set; }


        //Africa
        public List<UrbanAreasModel.UrbanAreas.UaItem> AFCities { get; set; }
        public List<ScoresModel.Scores.Root> AFScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem Cairo { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem CapeTown { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Casablanca { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Lagos { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Nairobi { get; set; }

        public ScoresModel.Scores.Root CairoScore { get; set; }
        public ScoresModel.Scores.Root CapeTownScore { get; set; }
        public ScoresModel.Scores.Root CasablancaScore { get; set; }
        public ScoresModel.Scores.Root LagosScore { get; set; }
        public ScoresModel.Scores.Root NairobiScore { get; set; }



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
