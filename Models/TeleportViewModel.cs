﻿using System;
using DemoLibrary2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoLibrary2.Models
{
	public class TeleportViewModel

	{   //North America
        public List<UrbanAreasModel.UrbanAreas.UaItem>? NorthAmericaCities { get; set; }
        public List<ScoresModel.Scores.Root>? NorthAmericaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Boston { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? LasVegas { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? NewYork { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? WashingtonDC { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Miami { get; set; }

        public ScoresModel.Scores.Root? BostonScore { get; set; }
        public ScoresModel.Scores.Root? LasVegasScore { get; set; }
        public ScoresModel.Scores.Root? NewYorkScore { get; set; }
        public ScoresModel.Scores.Root? WashingtonDCScore { get; set; }
        public ScoresModel.Scores.Root? MiamiScore { get; set; }

        //Africa
        public List<UrbanAreasModel.UrbanAreas.UaItem>? AfricaCities { get; set; }
        public List<ScoresModel.Scores.Root>? AfricaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Cairo { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? CapeTown { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Johannesburg { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Tunis { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Nairobi { get; set; }

        public ScoresModel.Scores.Root? CairoScore { get; set; }
        public ScoresModel.Scores.Root? CapeTownScore { get; set; }
        public ScoresModel.Scores.Root? JohannesburgScore { get; set; }
        public ScoresModel.Scores.Root? TunisScore { get; set; }
        public ScoresModel.Scores.Root? NairobiScore { get; set; }

        //Asia
        public List<UrbanAreasModel.UrbanAreas.UaItem>? AsiaCities { get; set; }
        public List<ScoresModel.Scores.Root>? AsiaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Singapore { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Seoul { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Osaka { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? HongKong { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Tokyo { get; set; }

        public ScoresModel.Scores.Root? SingaporeScore { get; set; }
        public ScoresModel.Scores.Root? SeoulScore { get; set; }
        public ScoresModel.Scores.Root? OsakaScore { get; set; }
        public ScoresModel.Scores.Root? HongKongScore { get; set; }
        public ScoresModel.Scores.Root? TokyoScore { get; set; }

        //South America
        public List<UrbanAreasModel.UrbanAreas.UaItem>? SouthAmericaCities { get; set; }
        public List<ScoresModel.Scores.Root>? SouthAmericaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Bogota { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Caracas { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Medellin { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? SaoPaulo { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? PortoAlegre { get; set; }

        public ScoresModel.Scores.Root? BogotaScore { get; set; }
        public ScoresModel.Scores.Root? CaracasScore { get; set; }
        public ScoresModel.Scores.Root? MedellinScore { get; set; }
        public ScoresModel.Scores.Root? SaoPauloScore { get; set; }
        public ScoresModel.Scores.Root? PortoAlegreScore { get; set; }

        //Oceania
        public List<UrbanAreasModel.UrbanAreas.UaItem>? OceaniaCities { get; set; }
        public List<ScoresModel.Scores.Root>? OceaniaScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Wellington { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Adelaide { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? ChristChurch { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Melbourne { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Brisbane { get; set; }

        public ScoresModel.Scores.Root? WellingtonScore { get; set; }
        public ScoresModel.Scores.Root? AdelaideScore { get; set; }
        public ScoresModel.Scores.Root? ChristChurchScore { get; set; }
        public ScoresModel.Scores.Root? MelbourneScore { get; set; }
        public ScoresModel.Scores.Root? BrisbaneScore { get; set; }

        //Europe
        public List<UrbanAreasModel.UrbanAreas.UaItem>? EuropeCities { get; set; }
        public List<ScoresModel.Scores.Root>? EuropeScores { get; set; }

        public UrbanAreasModel.UrbanAreas.UaItem? Aarhus { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Chisinau { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Lille { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Naples { get; set; }
        public UrbanAreasModel.UrbanAreas.UaItem? Vilnius { get; set; }

        public ScoresModel.Scores.Root? AarhusScore { get; set; }
        public ScoresModel.Scores.Root? ChisinauScore { get; set; }
        public ScoresModel.Scores.Root? LilleScore { get; set; }
        public ScoresModel.Scores.Root? NaplesScore { get; set; }
        public ScoresModel.Scores.Root? VilniusScore { get; set; }

        //Continent
        public List<ContinentsModel.ContinentItem>? Continents { get; set; }
        public string? SelectedContinent { get; set; }
        public List<SelectListItem>? ContinentsSelectList { get; set; }
    }
}
