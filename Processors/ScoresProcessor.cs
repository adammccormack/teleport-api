using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DemoLibrary;
using System.Security.Policy;
using DemoLibrary2.Models;
using Microsoft.DotNet.MSIdentity.Shared;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace DemoLibrary2
{
    public class ScoresProcessor
    {
        public static async Task<ScoresModel.Scores.Root> LoadScores(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var scores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                    return scores;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.Scores.Root> LoadUrbanAreaScores(string city)
        {
            string apiUrl = $"https://api.teleport.org/api/urban_areas/slug:{city}/scores/";
            return await LoadScores(apiUrl);
        }

        public class Africa
        {   
            public static async Task<ScoresModel.Scores.Root> LoadCairoScores()
            {
                return await LoadUrbanAreaScores("cairo");
            }

            public static async Task<ScoresModel.Scores.Root> LoadCapeTownScores()
            {
                return await LoadUrbanAreaScores("cape-town");
            }

            public static async Task<ScoresModel.Scores.Root> LoadJohannesburgScores()
            {
                return await LoadUrbanAreaScores("johannesburg");
            }

            public static async Task<ScoresModel.Scores.Root> LoadTunisScores()
            {
                return await LoadUrbanAreaScores("tunis");
            }

            public static async Task<ScoresModel.Scores.Root> LoadNairobiScores()
            {
                return await LoadUrbanAreaScores("nairobi");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
                var africaCities = africaUA._links.uaitems;

                mymodel.Cairo = africaCities[0];
                mymodel.CairoScore = await LoadCairoScores();
                mymodel.CapeTown = africaCities[1];
                mymodel.CapeTownScore = await LoadCapeTownScores();
                mymodel.Johannesburg = africaCities[4];
                mymodel.JohannesburgScore = await LoadJohannesburgScores();
                mymodel.Tunis = africaCities[7];
                mymodel.TunisScore = await LoadTunisScores();
                mymodel.Nairobi = africaCities[6];
                mymodel.NairobiScore = await LoadNairobiScores();

                return (mymodel);
            }
        }

        public class Asia
        {
            public static async Task<ScoresModel.Scores.Root> LoadSingaporeScores()
            {
                return await LoadUrbanAreaScores("singapore");
            }

            public static async Task<ScoresModel.Scores.Root> LoadTokyoScores()
            {
                return await LoadUrbanAreaScores("tokyo");
            }

            public static async Task<ScoresModel.Scores.Root> LoadSeoulScores()
            {
                return await LoadUrbanAreaScores("seoul");
            }

            public static async Task<ScoresModel.Scores.Root> LoadOsakaScores()
            {
                return await LoadUrbanAreaScores("osaka");
            }

            public static async Task<ScoresModel.Scores.Root> LoadHongKongScores()
            {
                return await LoadUrbanAreaScores("hong-kong");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
                var asiaCities = asiaUA._links.uaitems;

                mymodel.Singapore = asiaCities[30];
                mymodel.SingaporeScore = await LoadSingaporeScores();
                mymodel.Tokyo = asiaCities[35];
                mymodel.TokyoScore = await LoadTokyoScores();
                mymodel.Seoul = asiaCities[28];
                mymodel.SeoulScore = await LoadSeoulScores();
                mymodel.Osaka = asiaCities[24];
                mymodel.OsakaScore = await LoadOsakaScores();
                mymodel.HongKong = asiaCities[15];
                mymodel.HongKongScore = await LoadHongKongScores();
                
                return (mymodel);
            }
        }

        public class Europe
        {
            public static async Task<ScoresModel.Scores.Root> LoadMunichScores()
            {
                return await LoadUrbanAreaScores("munich");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBerlinScores()
            {
                return await LoadUrbanAreaScores("berlin");
            }

            public static async Task<ScoresModel.Scores.Root> LoadAmsterdamScores()
            {
                return await LoadUrbanAreaScores("amsterdam");
            }

            public static async Task<ScoresModel.Scores.Root> LoadLondonScores()
            {
                return await LoadUrbanAreaScores("london");
            }

            public static async Task<ScoresModel.Scores.Root> LoadCopenhagenScores()
            {
                return await LoadUrbanAreaScores("copenhagen");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var europeUA = await UrbanAreasProcessor.LoadEuropeUrbanAreas();
                var europeanCities = europeUA._links.uaitems;

                mymodel.Munich = europeanCities[69];
                mymodel.MunichScore = await LoadMunichScores();
                mymodel.Berlin = europeanCities[8];
                mymodel.BerlinScore = await LoadBerlinScores();
                mymodel.Amsterdam = europeanCities[1];
                mymodel.AmsterdamScore = await LoadAmsterdamScores();
                mymodel.London = europeanCities[57];
                mymodel.LondonScore = await LoadLondonScores();
                mymodel.Copenhagen = europeanCities[26];
                mymodel.CopenhagenScore = await LoadCopenhagenScores();

                return (mymodel);
            }
        }

        public class NorthAmerica
        {
            public static async Task<ScoresModel.Scores.Root> LoadTorontoScores()
            {
                return await LoadUrbanAreaScores("toronto");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMontrealScores()
            {
                return await LoadUrbanAreaScores("montreal");
            }

            public static async Task<ScoresModel.Scores.Root> LoadVancouverScores()
            {
                return await LoadUrbanAreaScores("vancouver");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBostonScores()
            {
                return await LoadUrbanAreaScores("boston");
            }

            public static async Task<ScoresModel.Scores.Root> LoadNewYorkScores()
            {
                return await LoadUrbanAreaScores("new-york");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
                var northAmericaCities = northAmericaUA._links.uaitems;

                mymodel.Toronto = northAmericaCities[82];
                mymodel.TorontoScore = await LoadTorontoScores();
                mymodel.Montreal = northAmericaCities[50];
                mymodel.MontrealScore = await LoadMontrealScores();
                mymodel.Boston = northAmericaCities[9];
                mymodel.BostonScore = await LoadBostonScores();
                mymodel.NewYork = northAmericaCities[53];
                mymodel.NewYorkScore = await LoadNewYorkScores();
                mymodel.Vancouver = northAmericaCities[83];
                mymodel.VancouverScore = await LoadVancouverScores();

                return (mymodel);
            }
        }

        public class Oceania
        {
            public static async Task<ScoresModel.Scores.Root> LoadWellingtonScores()
            {
                return await LoadUrbanAreaScores("wellington");
            }

            public static async Task<ScoresModel.Scores.Root> LoadSydneyScores()
            {
                return await LoadUrbanAreaScores("sydney");
            }

            public static async Task<ScoresModel.Scores.Root> LoadAdelaideScores()
            {
                return await LoadUrbanAreaScores("adelaide");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMelbourneScores()
            {
                return await LoadUrbanAreaScores("melbourne");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBrisbaneScores()
            {
                return await LoadUrbanAreaScores("brisbane");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var oceaniaUA = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();
                var oceaniaCities = oceaniaUA._links.uaitems;

                mymodel.Melbourne = oceaniaCities[4];
                mymodel.MelbourneScore = await LoadMelbourneScores();
                mymodel.Sydney = oceaniaCities[6];
                mymodel.SydneyScore = await LoadSydneyScores();
                mymodel.Brisbane = oceaniaCities[2];
                mymodel.BrisbaneScore = await LoadBrisbaneScores();
                mymodel.Wellington = oceaniaCities[7];
                mymodel.WellingtonScore = await LoadWellingtonScores();
                mymodel.Adelaide = oceaniaCities[0];
                mymodel.AdelaideScore = await LoadAdelaideScores();
                
                return (mymodel);
            }
        }

        public class SouthAmerica
        {

            public static async Task<ScoresModel.Scores.Root> LoadSantiagoScores()
            {
                return await LoadUrbanAreaScores("santiago");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMontevideoScores()
            {
                return await LoadUrbanAreaScores("montevideo");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBuenosAirescores()
            {
                return await LoadUrbanAreaScores("buenos-aires");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBogotaScores()
            {
                return await LoadUrbanAreaScores("bogota");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMedellinScores()
            {
                return await LoadUrbanAreaScores("medellin");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var southAmericaUA = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();
                var southAmericaCities = southAmericaUA._links.uaitems;

                mymodel.Santiago = southAmericaCities[13];
                mymodel.SantiagoScore = await LoadSantiagoScores();
                mymodel.Bogota = southAmericaCities[1];
                mymodel.BogotaScore = await LoadBogotaScores();
                mymodel.Medellin = southAmericaCities[8];
                mymodel.MedellinScore = await LoadMedellinScores();
                mymodel.Montevideo = southAmericaCities[9];
                mymodel.MontevideoScore = await LoadMontevideoScores();
                mymodel.BuenosAires = southAmericaCities[2];
                mymodel.BuenosAirescore = await LoadBuenosAirescores();

                return (mymodel);
            }
        }
    }
}
