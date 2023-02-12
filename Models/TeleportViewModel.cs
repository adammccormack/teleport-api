using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel

	{   //North America
        public List<UrbanAreasModel.UrbanAreas.UaItem> NorthAmericaCities { get; set; }
        public List<ScoresModel.Scores.Root> NorthAmericaScores { get; set; }

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
        public List<UrbanAreasModel.UrbanAreas.UaItem> AfricaCities { get; set; }
        public List<ScoresModel.Scores.Root> AfricaScores { get; set; }

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


        //South America
        public List<UrbanAreasModel.UrbanAreas.UaItem> AsiaCities { get; set; }
        public List<ScoresModel.Scores.Root> AsiaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem Doha { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Manila { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Taipei { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem HongKong { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem Tokyo { get; set; }

        public ScoresModel.Scores.Root DohaScore { get; set; }
        public ScoresModel.Scores.Root ManilaScore { get; set; }
        public ScoresModel.Scores.Root TaipeiScore { get; set; }
        public ScoresModel.Scores.Root HongKongScore { get; set; }
        public ScoresModel.Scores.Root TokyoScore { get; set; }


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
