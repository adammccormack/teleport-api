using System.Net.Http;
using DemoLibrary;
using DemoLibrary2.Models;
using Newtonsoft.Json;

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
            string url = $"https://api.teleport.org/api/urban_areas/slug:{city}/scores/";
            return await LoadScores(url);
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
                TeleportViewModel model = new TeleportViewModel();

                var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
                var africaCities = africaUA._links.uaitems;

                model.Cairo = africaCities[0];
                model.CairoScore = await LoadCairoScores();
                model.CapeTown = africaCities[1];
                model.CapeTownScore = await LoadCapeTownScores();
                model.Johannesburg = africaCities[4];
                model.JohannesburgScore = await LoadJohannesburgScores();
                model.Tunis = africaCities[7];
                model.TunisScore = await LoadTunisScores();
                model.Nairobi = africaCities[6];
                model.NairobiScore = await LoadNairobiScores();

                return (model);
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
                TeleportViewModel model = new TeleportViewModel();

                var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
                var asiaCities = asiaUA._links.uaitems;

                model.Singapore = asiaCities[30];
                model.SingaporeScore = await LoadSingaporeScores();
                model.Tokyo = asiaCities[35];
                model.TokyoScore = await LoadTokyoScores();
                model.Seoul = asiaCities[28];
                model.SeoulScore = await LoadSeoulScores();
                model.Osaka = asiaCities[24];
                model.OsakaScore = await LoadOsakaScores();
                model.HongKong = asiaCities[15];
                model.HongKongScore = await LoadHongKongScores();
                
                return (model);
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
                TeleportViewModel model = new TeleportViewModel();

                var europeUA = await UrbanAreasProcessor.LoadEuropeUrbanAreas();
                var europeanCities = europeUA._links.uaitems;

                model.Munich = europeanCities[69];
                model.MunichScore = await LoadMunichScores();
                model.Berlin = europeanCities[8];
                model.BerlinScore = await LoadBerlinScores();
                model.Amsterdam = europeanCities[1];
                model.AmsterdamScore = await LoadAmsterdamScores();
                model.London = europeanCities[57];
                model.LondonScore = await LoadLondonScores();
                model.Copenhagen = europeanCities[26];
                model.CopenhagenScore = await LoadCopenhagenScores();

                return (model);
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
                TeleportViewModel model = new TeleportViewModel();

                var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
                var northAmericaCities = northAmericaUA._links.uaitems;

                model.Toronto = northAmericaCities[82];
                model.TorontoScore = await LoadTorontoScores();
                model.Montreal = northAmericaCities[50];
                model.MontrealScore = await LoadMontrealScores();
                model.Boston = northAmericaCities[9];
                model.BostonScore = await LoadBostonScores();
                model.NewYork = northAmericaCities[53];
                model.NewYorkScore = await LoadNewYorkScores();
                model.Vancouver = northAmericaCities[83];
                model.VancouverScore = await LoadVancouverScores();

                return (model);
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
                TeleportViewModel model = new TeleportViewModel();

                var oceaniaUA = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();
                var oceaniaCities = oceaniaUA._links.uaitems;

                model.Melbourne = oceaniaCities[4];
                model.MelbourneScore = await LoadMelbourneScores();
                model.Sydney = oceaniaCities[6];
                model.SydneyScore = await LoadSydneyScores();
                model.Brisbane = oceaniaCities[2];
                model.BrisbaneScore = await LoadBrisbaneScores();
                model.Wellington = oceaniaCities[7];
                model.WellingtonScore = await LoadWellingtonScores();
                model.Adelaide = oceaniaCities[0];
                model.AdelaideScore = await LoadAdelaideScores();
                
                return (model);
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
                TeleportViewModel model = new TeleportViewModel();

                var southAmericaUA = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();
                var southAmericaCities = southAmericaUA._links.uaitems;

                model.Santiago = southAmericaCities[13];
                model.SantiagoScore = await LoadSantiagoScores();
                model.Bogota = southAmericaCities[1];
                model.BogotaScore = await LoadBogotaScores();
                model.Medellin = southAmericaCities[8];
                model.MedellinScore = await LoadMedellinScores();
                model.Montevideo = southAmericaCities[9];
                model.MontevideoScore = await LoadMontevideoScores();
                model.BuenosAires = southAmericaCities[2];
                model.BuenosAirescore = await LoadBuenosAirescores();

                return (model);
            }
        }
    }
}
