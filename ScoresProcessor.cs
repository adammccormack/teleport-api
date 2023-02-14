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

        public static async Task<ScoresModel.Scores.Root> LoadScoresByCity(string city)
        {
            string cityUrl = $"https://api.teleport.org/api/urban_areas/slug:{city}/scores/";
            using (HttpResponseMessage cityResponse = await ApiHelper.ApiClient.GetAsync(cityUrl))
            {
                if (cityResponse.IsSuccessStatusCode)
                {
                    var cityJsonString = await cityResponse.Content.ReadAsStringAsync();
                    var cityScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(cityJsonString);
                    return (cityScores);
                }
                else
                {
                    throw new Exception(cityResponse.ReasonPhrase);
                }
            }
        }

        public class NorthAmerica
        {
            public static async Task<ScoresModel.Scores.Root> LoadBostonScores()
            {
                string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
                return await LoadScores(bostonUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadLasVegasScores()
            {
                string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
                return await LoadScores(lasVegasUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadNewYorkScores()
            {
                string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";
                return await LoadScores(newYorkUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadWashingtonDCScores()
            {
                string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";
                return await LoadScores(washingtonDCUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadMiamiScores()
            {
                string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";
                return await LoadScores(miamiUrl);
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();
                var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
                var northAmericaCities = northAmericaUA._links.uaitems;

                var boston = northAmericaCities[9];
                var lasVegas = northAmericaCities[40];
                var newYork = northAmericaCities[53];
                var washingtonDC = northAmericaCities[85];
                var miami = northAmericaCities[47];

                mymodel.Boston = boston;
                mymodel.BostonScore = await LoadBostonScores();
                mymodel.LasVegas = lasVegas;
                mymodel.LasVegasScore = await LoadLasVegasScores();
                mymodel.NewYork = newYork;
                mymodel.NewYorkScore = await LoadNewYorkScores();
                mymodel.WashingtonDC = washingtonDC;
                mymodel.WashingtonDCScore = await LoadWashingtonDCScores();
                mymodel.Miami = miami;
                mymodel.MiamiScore = await LoadMiamiScores();

                return (mymodel);
            }
        }

        public class Africa
        {
            public static async Task<ScoresModel.Scores.Root> LoadCairoScores()
            {
                string cairoUrl = "https://api.teleport.org/api/urban_areas/slug:cairo/scores/";
                return await LoadScores(cairoUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadCapeTownScores()
            {
                string capeTownUrl = "https://api.teleport.org/api/urban_areas/slug:cape-town/scores/";
                return await LoadScores(capeTownUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadCasablancaScores()
            {
                string casablancaUrl = "https://api.teleport.org/api/urban_areas/slug:cape-town/scores/";
                return await LoadScores(casablancaUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadLagosScores()
            {
                string lagosUrl = "https://api.teleport.org/api/urban_areas/slug:lagos/scores/";
                return await LoadScores(lagosUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadNairobiScores()
            {
                string nairobiUrl = "https://api.teleport.org/api/urban_areas/slug:nairobi/scores/";
                return await LoadScores(nairobiUrl);
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
                var africaCities = africaUA._links.uaitems;

                var cairo = africaCities[0];
                var capeTown = africaCities[1];
                var casablanca = africaCities[2];
                var lagos = africaCities[5];
                var nairobi = africaCities[6];

                mymodel.Cairo = cairo;
                mymodel.CairoScore = await LoadCairoScores();
                mymodel.CapeTown = capeTown;
                mymodel.CapeTownScore = await LoadCapeTownScores();
                mymodel.Casablanca = casablanca;
                mymodel.CasablancaScore = await LoadCasablancaScores();
                mymodel.Lagos = lagos;
                mymodel.LagosScore = await LoadLagosScores();
                mymodel.Nairobi = nairobi;
                mymodel.NairobiScore = await LoadNairobiScores();

                return (mymodel);
            }
        }

        public class Asia
        {
            public static async Task<ScoresModel.Scores.Root> LoadDohaScores()
            {
                string dohaUrl = "https://api.teleport.org/api/urban_areas/slug:doha/scores/";
                return await LoadScores(dohaUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadManilaScores()
            {
                string manilaUrl = "https://api.teleport.org/api/urban_areas/slug:manila/scores/";
                return await LoadScores(manilaUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadTaipeiScores()
            {
                string taipeiUrl = "https://api.teleport.org/api/urban_areas/slug:taipei/scores/";
                return await LoadScores(taipeiUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadHongKongScores()
            {
                string hongKongUrl = "https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/";
                return await LoadScores(hongKongUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadTokyoScores()
            {
                string tokyoUrl = "https://api.teleport.org/api/urban_areas/slug:tokyo/scores/";
                return await LoadScores(tokyoUrl);
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
                var asiaCities = asiaUA._links.uaitems;

                var doha = asiaCities[11];
                var manila = asiaCities[22];
                var taipei = asiaCities[31];
                var hongKong = asiaCities[15];
                var tokyo = asiaCities[35];

                mymodel.Doha = doha;
                mymodel.DohaScore = await LoadDohaScores();
                mymodel.Manila = manila;
                mymodel.ManilaScore = await LoadManilaScores();
                mymodel.Taipei = taipei;
                mymodel.TaipeiScore = await LoadTaipeiScores();
                mymodel.HongKong = hongKong;
                mymodel.HongKongScore = await LoadHongKongScores();
                mymodel.Tokyo = tokyo;
                mymodel.TokyoScore = await LoadTokyoScores();

                return (mymodel);
            }
        }

        public class SouthAmerica
        {
            public static async Task<ScoresModel.Scores.Root> LoadBogotaScores()
            {
                string bogotaUrl = "https://api.teleport.org/api/urban_areas/slug:bogota/scores/";
                return await LoadScores(bogotaUrl);
            }
            
            public static async Task<ScoresModel.Scores.Root> LoadCaracasScores()
            {
                string caracasUrl = "https://api.teleport.org/api/urban_areas/slug:caracas/scores/";
                return await LoadScores(caracasUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadMedellinScores()
            {
                string medellinUrl = "https://api.teleport.org/api/urban_areas/slug:medellin/scores/";
                return await LoadScores(medellinUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadSaoPauloScores()
            {
                string saoPauloUrl = "https://api.teleport.org/api/urban_areas/slug:sao-paulo/scores/";
                return await LoadScores(saoPauloUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadPortoAlegreScores()
            {
                string portoAlegreUrl = "https://api.teleport.org/api/urban_areas/slug:porto-alegre/scores/";
                return await LoadScores(portoAlegreUrl);
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var southAmericaUA = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();
                var SACities = southAmericaUA._links.uaitems;

                var bogota = SACities[1];
                var caracas = SACities[3];
                var medellin = SACities[8];
                var saoPaulo = SACities[14];
                var portoAlegre = SACities[10];

                mymodel.Bogota = bogota;
                mymodel.BogotaScore = await LoadBogotaScores();
                mymodel.Caracas = caracas;
                mymodel.CaracasScore = await LoadCaracasScores();
                mymodel.Medellin = medellin;
                mymodel.MedellinScore = await LoadMedellinScores();
                mymodel.SaoPaulo = saoPaulo;
                mymodel.SaoPauloScore = await LoadSaoPauloScores();
                mymodel.PortoAlegre = portoAlegre;
                mymodel.PortoAlegreScore = await LoadPortoAlegreScores();

                return (mymodel);
            }
        }

        public class Oceania
        {
            public static async Task<ScoresModel.Scores.Root> LoadWellingtonScores()
            {
                string wellingtonUrl = "https://api.teleport.org/api/urban_areas/slug:wellington/scores/";
                return await LoadScores(wellingtonUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadAdelaideScores()
            {
                string adelaideUrl = "https://api.teleport.org/api/urban_areas/slug:adelaide/scores/";
                return await LoadScores(adelaideUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadChristChurchScores()
            {
                string christChurchUrl = "https://api.teleport.org/api/urban_areas/slug:christchurch/scores/";
                return await LoadScores(christChurchUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadMelbourneScores()
            {
                string melbourneUrl = "https://api.teleport.org/api/urban_areas/slug:melbourne/scores/";
                return await LoadScores(melbourneUrl);
            }

            public static async Task<ScoresModel.Scores.Root> LoadBrisbaneScores()
            {
                string brisbaneUrl = "https://api.teleport.org/api/urban_areas/slug:brisbane/scores/";
                return await LoadScores(brisbaneUrl);
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                var oceaniaUA = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();
                var OCCities = oceaniaUA._links.uaitems;

                var wellington = OCCities[7];
                var adelaide = OCCities[0];
                var christChurch = OCCities[3];
                var melbourne = OCCities[4];
                var brisbane = OCCities[2];

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.Wellington = wellington;
                mymodel.WellingtonScore = await LoadWellingtonScores();
                mymodel.Adelaide = adelaide;
                mymodel.AdelaideScore = await LoadAdelaideScores();
                mymodel.ChristChurch = christChurch;
                mymodel.ChristChurchScore = await LoadChristChurchScores();
                mymodel.Melbourne = melbourne;
                mymodel.MelbourneScore = await LoadMelbourneScores();
                mymodel.Brisbane = brisbane;
                mymodel.BrisbaneScore = await LoadBrisbaneScores();

                return (mymodel);
            }
        }

        public class Europe
        {
            public static async Task<ScoresModel.Scores.Root> LoadAarhusScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:aarhus/scores/";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var score = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                        return (score);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadChisinauScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:chisinau/scores/";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var score = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                        return (score);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadLilleScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:lille/scores/";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var score = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                        return (score);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadNaplesScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:naples/scores/";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var score = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                        return (score);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadVilniusScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:vilnius/scores/";
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var score = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(jsonString);
                        return (score);
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                var europeUA = await UrbanAreasProcessor.LoadEuropeUrbanAreas();
                var EUCities = europeUA._links.uaitems;

                var aarhusScore = await ScoresProcessor.Europe.LoadAarhusScores();
                var chisinauScore = await ScoresProcessor.Europe.LoadChisinauScores();
                var lilleScore = await ScoresProcessor.Europe.LoadLilleScores();
                var naplesScore = await ScoresProcessor.Europe.LoadNaplesScores();
                var vilniusScore = await ScoresProcessor.Europe.LoadVilniusScores();

                var aarhus = EUCities[0];
                var chisinau = EUCities[23];
                var lille = EUCities[53];
                var naples = EUCities[71];
                var vilnius = EUCities[106];

                List<ScoresModel.Scores.Root> europeScores = new List<ScoresModel.Scores.Root>();

                europeScores.Add(aarhusScore);
                europeScores.Add(chisinauScore);
                europeScores.Add(lilleScore);
                europeScores.Add(naplesScore);
                europeScores.Add(vilniusScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> europeCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                europeCities.Add(aarhus);
                europeCities.Add(chisinau);
                europeCities.Add(lille);
                europeCities.Add(naples);
                europeCities.Add(vilnius);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.EuropeCities = europeCities;
                mymodel.EuropeScores = europeScores;
                mymodel.Aarhus = aarhus;
                mymodel.AarhusScore = aarhusScore;
                mymodel.Chisinau = chisinau;
                mymodel.ChisinauScore = chisinauScore;
                mymodel.Lille = lille;
                mymodel.LilleScore = lilleScore;
                mymodel.Naples = naples;
                mymodel.NaplesScore = naplesScore;
                mymodel.Vilnius = vilnius;
                mymodel.VilniusScore = vilniusScore;

                return (mymodel);
            }

        }
    }
}

