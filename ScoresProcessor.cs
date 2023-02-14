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
        public class NorthAmerica
        {
            //public static async Task<ScoresModel.Scores.Root> LoadBostonScores()
            //{
            //    string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
            //    using (HttpResponseMessage bostonResponse = await ApiHelper.ApiClient.GetAsync(bostonUrl))
            //    {
            //        if (bostonResponse.IsSuccessStatusCode)
            //        {
            //            var bostonJsonString = await bostonResponse.Content.ReadAsStringAsync();
            //            var bostonScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(bostonJsonString);
            //            return (bostonScores);
            //        }
            //        else
            //        {
            //            throw new Exception(bostonResponse.ReasonPhrase);
            //        }
            //    }
            //}

            //public static async Task<ScoresModel.Scores.Root> LoadLasVegasScores()
            //{
            //    string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
            //    using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasUrl))
            //    {
            //        if (lasVegasResponse.IsSuccessStatusCode)
            //        {
            //            var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();
            //            var lasVegasScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(lasVegasJsonString);
            //            return (lasVegasScores);
            //        }
            //        else
            //        {
            //            throw new Exception(lasVegasResponse.ReasonPhrase);
            //        }
            //    }
            //}
            //public static async Task<ScoresModel.Scores.Root> LoadNewYorkScores()
            //{
            //    string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";

            //    using (HttpResponseMessage newYorkResponse = await ApiHelper.ApiClient.GetAsync(newYorkUrl))

            //    {
            //        if (newYorkResponse.IsSuccessStatusCode)

            //        {
            //            var newYorkJsonString = await newYorkResponse.Content.ReadAsStringAsync();
            //            var newYorkScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(newYorkJsonString);
            //            return (newYorkScores);
            //        }
            //        else
            //        {
            //            throw new Exception(newYorkResponse.ReasonPhrase);
            //        }
            //    }
            //}

            //public static async Task<ScoresModel.Scores.Root> LoadWashingtonDCScores()
            //{
            //    string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";

            //    using (HttpResponseMessage washingtonDCResponse = await ApiHelper.ApiClient.GetAsync(washingtonDCUrl))
            //    {
            //        if (
            //            washingtonDCResponse.IsSuccessStatusCode)
            //        {
            //            var washingtonDCJsonString = await washingtonDCResponse.Content.ReadAsStringAsync();
            //            var washingtonDCScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(washingtonDCJsonString);
            //            return (washingtonDCScores);
            //        }
            //        else
            //        {
            //            throw new Exception(washingtonDCResponse.ReasonPhrase);
            //        }
            //    }
            //}

            //public static async Task<ScoresModel.Scores.Root> LoadMiamiScores()
            //{
            //    string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";
            //    using (HttpResponseMessage miamiResponse = await ApiHelper.ApiClient.GetAsync(miamiUrl))
            //    {
            //        if (miamiResponse.IsSuccessStatusCode)
            //        {
            //            var miamiJsonString = await miamiResponse.Content.ReadAsStringAsync();
            //            var miamiScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(miamiJsonString);
            //            return (miamiScores);
            //        }
            //        else
            //        {
            //            throw new Exception(miamiResponse.ReasonPhrase);
            //        }
            //    }
            //}

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

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
                var NACities = northAmericaUA._links.uaitems;

                string[] cities = new string[] { "boston", "las-vegas", "new-york", "washington-dc", "miami" };

                foreach (string city in cities)
                {
                    try
                    {
                        var cityScores = await LoadScoresByCity(city);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error while loading scores for city {city}: {ex.Message}");
                    }
                }

                //var bostonScore = await ScoresProcessor.NorthAmerica.LoadBostonScores();
                //var lasVegasScore = await ScoresProcessor.NorthAmerica.LoadLasVegasScores();
                //var newYorkScore = await ScoresProcessor.NorthAmerica.LoadNewYorkScores();
                //var washingtonDCScore = await ScoresProcessor.NorthAmerica.LoadWashingtonDCScores();
                //var miamiScore = await ScoresProcessor.NorthAmerica.LoadMiamiScores();

                var boston = NACities[9];
                var lasVegas = NACities[40];
                var newYork = NACities[53];
                var washingtonDC = NACities[85];
                var miami = NACities[47];

                List<ScoresModel.Scores.Root> northAmericascores = new List<ScoresModel.Scores.Root>();

                //northAmericascores.Add(bostonScore);
                //northAmericascores.Add(lasVegasScore);
                //northAmericascores.Add(newYorkScore);
                //northAmericascores.Add(washingtonDCScore);
                //northAmericascores.Add(miamiScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> northAmericaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                northAmericaCities.Add(boston);
                northAmericaCities.Add(lasVegas);
                northAmericaCities.Add(newYork);
                northAmericaCities.Add(washingtonDC);
                northAmericaCities.Add(miami);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.NorthAmericaCities = northAmericaCities;
                mymodel.NorthAmericaScores = northAmericascores;
                mymodel.CityScores = cityScores;
                mymodel.Boston = boston;
                mymodel.BostonScore = bostonScore;
                mymodel.LasVegas = lasVegas;
                mymodel.LasVegasScore = lasVegasScore;
                mymodel.NewYork = newYork;
                mymodel.NewYorkScore = newYorkScore;
                mymodel.WashingtonDC = washingtonDC;
                mymodel.WashingtonDCScore = washingtonDCScore;
                mymodel.Miami = miami;
                mymodel.MiamiScore = miamiScore;

                return (mymodel);
            }
        }

        public class Africa
        {
            public static async Task<ScoresModel.Scores.Root> LoadCairoScores()
            {
                string cairoUrl = "https://api.teleport.org/api/urban_areas/slug:cairo/scores/";
                using (HttpResponseMessage cairoResponse = await ApiHelper.ApiClient.GetAsync(cairoUrl))
                {
                    if (cairoResponse.IsSuccessStatusCode)
                    {
                        var cairoJsonString = await cairoResponse.Content.ReadAsStringAsync();
                        var cairoScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(cairoJsonString);
                        return (cairoScores);
                    }
                    else
                    {
                        throw new Exception(cairoResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadCapeTownScores()
            {
                string capeTownUrl = "https://api.teleport.org/api/urban_areas/slug:cape-town/scores/";
                using (HttpResponseMessage capeTownResponse = await ApiHelper.ApiClient.GetAsync(capeTownUrl))
                {
                    if (capeTownResponse.IsSuccessStatusCode)
                    {
                        var capeTownJsonString = await capeTownResponse.Content.ReadAsStringAsync();
                        var capeTownScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(capeTownJsonString);
                        return (capeTownScores);
                    }
                    else
                    {
                        throw new Exception(capeTownResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadCasablancaScores()
            {
                string casablancaUrl = "https://api.teleport.org/api/urban_areas/slug:casablanca/scores/";
                using (HttpResponseMessage casablancaResponse = await ApiHelper.ApiClient.GetAsync(casablancaUrl))
                {
                    if (casablancaResponse.IsSuccessStatusCode)
                    {
                        var casablancaJsonString = await casablancaResponse.Content.ReadAsStringAsync();
                        var casablancaScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(casablancaJsonString);
                        return (casablancaScores);
                    }
                    else
                    {
                        throw new Exception(casablancaResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadLagosScores()
            {
                string lagosUrl = "https://api.teleport.org/api/urban_areas/slug:lagos/scores/";
                using (HttpResponseMessage lagosResponse = await ApiHelper.ApiClient.GetAsync(lagosUrl))
                {
                    if (lagosResponse.IsSuccessStatusCode)
                    {
                        var lagosJsonString = await lagosResponse.Content.ReadAsStringAsync();
                        var lagosScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(lagosJsonString);
                        return (lagosScores);
                    }
                    else
                    {
                        throw new Exception(lagosResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadNairobiScores()
            {
                string nairobiUrl = "https://api.teleport.org/api/urban_areas/slug:nairobi/scores/";
                using (HttpResponseMessage nairobiResponse = await ApiHelper.ApiClient.GetAsync(nairobiUrl))
                {
                    if (nairobiResponse.IsSuccessStatusCode)
                    {
                        var nairobiJsonString = await nairobiResponse.Content.ReadAsStringAsync();
                        var nairobiScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(nairobiJsonString);
                        return (nairobiScores);
                    }
                    else
                    {
                        throw new Exception(nairobiResponse.ReasonPhrase);
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


            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                var africaUA = await UrbanAreasProcessor.LoadAfricaUrbanAreas();
                var AFCities = africaUA._links.uaitems;

                var cairoScore = await ScoresProcessor.Africa.LoadCairoScores();
                var capeTownScore = await ScoresProcessor.Africa.LoadCapeTownScores();
                var casablancaScore = await ScoresProcessor.Africa.LoadCasablancaScores();
                var lagosScore = await ScoresProcessor.Africa.LoadLagosScores();
                var nairobiScore = await ScoresProcessor.Africa.LoadNairobiScores();

                var cairo = AFCities[0];
                var capeTown = AFCities[1];
                var casablanca = AFCities[2];
                var lagos = AFCities[5];
                var nairobi = AFCities[6];

                List<ScoresModel.Scores.Root> africaScores = new List<ScoresModel.Scores.Root>();

                africaScores.Add(cairoScore);
                africaScores.Add(capeTownScore);
                africaScores.Add(casablancaScore);
                africaScores.Add(lagosScore);
                africaScores.Add(nairobiScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> africaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                africaCities.Add(cairo);
                africaCities.Add(capeTown);
                africaCities.Add(casablanca);
                africaCities.Add(lagos);
                africaCities.Add(nairobi);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.AfricaCities = africaCities;
                mymodel.AfricaScores = africaScores;
                mymodel.Cairo = cairo;
                mymodel.CairoScore = cairoScore;
                mymodel.CapeTown = capeTown;
                mymodel.CapeTownScore = capeTownScore;
                mymodel.Casablanca = casablanca;
                mymodel.CasablancaScore = casablancaScore;
                mymodel.Lagos = lagos;
                mymodel.LagosScore = lagosScore;
                mymodel.Nairobi = nairobi;
                mymodel.NairobiScore = nairobiScore;

                return (mymodel);
            }
        }

        public class Asia
        {
            public static async Task<ScoresModel.Scores.Root> LoadDohaScores()
            {
                string dohaUrl = "https://api.teleport.org/api/urban_areas/slug:doha/scores/";
                using (HttpResponseMessage dohaResponse = await ApiHelper.ApiClient.GetAsync(dohaUrl))
                {
                    if (dohaResponse.IsSuccessStatusCode)
                    {
                        var dohaJsonString = await dohaResponse.Content.ReadAsStringAsync();
                        var dohaScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(dohaJsonString);
                        return (dohaScores);
                    }
                    else
                    {
                        throw new Exception(dohaResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadManilaScores()
            {
                string manilaUrl = "https://api.teleport.org/api/urban_areas/slug:manila/scores/";
                using (HttpResponseMessage manilaResponse = await ApiHelper.ApiClient.GetAsync(manilaUrl))
                {
                    if (manilaResponse.IsSuccessStatusCode)
                    {
                        var manilaJsonString = await manilaResponse.Content.ReadAsStringAsync();
                        var manilaScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(manilaJsonString);
                        return (manilaScores);
                    }
                    else
                    {
                        throw new Exception(manilaResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadTaipeiScores()
            {
                string taipeiUrl = "https://api.teleport.org/api/urban_areas/slug:taipei/scores/";
                using (HttpResponseMessage taipeiResponse = await ApiHelper.ApiClient.GetAsync(taipeiUrl))
                {
                    if (taipeiResponse.IsSuccessStatusCode)
                    {
                        var taipeiJsonString = await taipeiResponse.Content.ReadAsStringAsync();
                        var taipeiScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(taipeiJsonString);
                        return (taipeiScores);
                    }
                    else
                    {
                        throw new Exception(taipeiResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadHongKongScores()
            {
                string hongKongUrl = "https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/";
                using (HttpResponseMessage hongKongResponse = await ApiHelper.ApiClient.GetAsync(hongKongUrl))
                {
                    if (hongKongResponse.IsSuccessStatusCode)
                    {
                        var hongKongJsonString = await hongKongResponse.Content.ReadAsStringAsync();
                        var hongKongScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(hongKongJsonString);
                        return (hongKongScores);
                    }
                    else
                    {
                        throw new Exception(hongKongResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<ScoresModel.Scores.Root> LoadTokyoScores()
            {
                string tokyoUrl = "https://api.teleport.org/api/urban_areas/slug:tokyo/scores/";
                using (HttpResponseMessage tokyoResponse = await ApiHelper.ApiClient.GetAsync(tokyoUrl))
                {
                    if (tokyoResponse.IsSuccessStatusCode)
                    {
                        var tokyoJsonString = await tokyoResponse.Content.ReadAsStringAsync();
                        var tokyoScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(tokyoJsonString);
                        return (tokyoScores);
                    }
                    else
                    {
                        throw new Exception(tokyoResponse.ReasonPhrase);
                    }
                }
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
                var ASCities = asiaUA._links.uaitems;

                var dohaScore = await ScoresProcessor.Asia.LoadDohaScores();
                var manilaScore = await ScoresProcessor.Asia.LoadManilaScores();
                var taipeiScore = await ScoresProcessor.Asia.LoadTaipeiScores();
                var hongKongScore = await ScoresProcessor.Asia.LoadHongKongScores();
                var tokyoScore = await ScoresProcessor.Asia.LoadTokyoScores();

                var doha = ASCities[11];
                var manila = ASCities[22];
                var taipei = ASCities[31];
                var hongKong = ASCities[15];
                var tokyo = ASCities[35];

                List<ScoresModel.Scores.Root> asiaScores = new List<ScoresModel.Scores.Root>();

                asiaScores.Add(dohaScore);
                asiaScores.Add(manilaScore);
                asiaScores.Add(taipeiScore);
                asiaScores.Add(hongKongScore);
                asiaScores.Add(tokyoScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> asiaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                asiaCities.Add(doha);
                asiaCities.Add(manila);
                asiaCities.Add(taipei);
                asiaCities.Add(hongKong);
                asiaCities.Add(tokyo);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.AsiaCities = asiaCities;
                mymodel.AsiaScores = asiaScores;
                mymodel.Doha = doha;
                mymodel.DohaScore = dohaScore;
                mymodel.Manila = manila;
                mymodel.ManilaScore = manilaScore;
                mymodel.Taipei = taipei;
                mymodel.TaipeiScore = taipeiScore;
                mymodel.HongKong = hongKong;
                mymodel.HongKongScore = hongKongScore;
                mymodel.Tokyo = tokyo;
                mymodel.TokyoScore = tokyoScore;

                return (mymodel);
            }
        }

        public class SouthAmerica
        {
            public static async Task<ScoresModel.Scores.Root> LoadBogotaScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:bogota/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadCaracasScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:caracas/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadMedellinScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:medellin/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadSaoPauloScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:sao-paulo/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadPortoAlegreScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:porto-alegre/scores/";
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
                var southAmericaUA = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();
                var SACities = southAmericaUA._links.uaitems;

                var bogotaScore = await ScoresProcessor.SouthAmerica.LoadBogotaScores();
                var caracasScore = await ScoresProcessor.SouthAmerica.LoadCaracasScores();
                var medellinScore = await ScoresProcessor.SouthAmerica.LoadMedellinScores();
                var saoPauloScore = await ScoresProcessor.SouthAmerica.LoadSaoPauloScores();
                var portoAlegreScore = await ScoresProcessor.SouthAmerica.LoadPortoAlegreScores();

                var bogota = SACities[1];
                var caracas = SACities[3];
                var medellin = SACities[8];
                var saoPaulo = SACities[14];
                var portoAlegre = SACities[10];

                List<ScoresModel.Scores.Root> southAmericaScores = new List<ScoresModel.Scores.Root>();

                southAmericaScores.Add(bogotaScore);
                southAmericaScores.Add(caracasScore);
                southAmericaScores.Add(medellinScore);
                southAmericaScores.Add(saoPauloScore);
                southAmericaScores.Add(portoAlegreScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> southAmericaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                southAmericaCities.Add(bogota);
                southAmericaCities.Add(caracas);
                southAmericaCities.Add(medellin);
                southAmericaCities.Add(saoPaulo);
                southAmericaCities.Add(portoAlegre);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.SouthAmericaCities = southAmericaCities;
                mymodel.SouthAmericaScores = southAmericaScores;
                mymodel.Bogota = bogota;
                mymodel.BogotaScore = bogotaScore;
                mymodel.Caracas = caracas;
                mymodel.CaracasScore = caracasScore;
                mymodel.Medellin = medellin;
                mymodel.MedellinScore = medellinScore;
                mymodel.SaoPaulo = saoPaulo;
                mymodel.SaoPauloScore = saoPauloScore;
                mymodel.PortoAlegre = portoAlegre;
                mymodel.PortoAlegreScore = portoAlegreScore;

                return (mymodel);
            }
        }

        public class Oceania
        {
            public static async Task<ScoresModel.Scores.Root> LoadWellingtonScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:wellington/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadAdelaideScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:adelaide/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadChristChurchScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:christchurch/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadMelbourneScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:melbourne/scores/";
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

            public static async Task<ScoresModel.Scores.Root> LoadBrisbaneScores()
            {
                string url = "https://api.teleport.org/api/urban_areas/slug:brisbane/scores/";
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
                var oceaniaUA = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();
                var OCCities = oceaniaUA._links.uaitems;

                var wellingtonScore = await ScoresProcessor.Oceania.LoadWellingtonScores();
                var adelaideScore = await ScoresProcessor.Oceania.LoadAdelaideScores();
                var christChurchScore = await ScoresProcessor.Oceania.LoadChristChurchScores();
                var melbourneScore = await ScoresProcessor.Oceania.LoadMelbourneScores();
                var brisbaneScore = await ScoresProcessor.Oceania.LoadBrisbaneScores();

                var wellington = OCCities[7];
                var adelaide = OCCities[0];
                var christChurch = OCCities[3];
                var melbourne = OCCities[4];
                var brisbane = OCCities[2];

                List<ScoresModel.Scores.Root> oceaniaScores = new List<ScoresModel.Scores.Root>();

                oceaniaScores.Add(wellingtonScore);
                oceaniaScores.Add(adelaideScore);
                oceaniaScores.Add(christChurchScore);
                oceaniaScores.Add(melbourneScore);
                oceaniaScores.Add(brisbaneScore);

                List<UrbanAreasModel.UrbanAreas.UaItem> oceaniaCities = new List<UrbanAreasModel.UrbanAreas.UaItem>();

                oceaniaCities.Add(wellington);
                oceaniaCities.Add(adelaide);
                oceaniaCities.Add(christChurch);
                oceaniaCities.Add(melbourne);
                oceaniaCities.Add(brisbane);

                TeleportViewModel mymodel = new TeleportViewModel();

                mymodel.OceaniaCities = oceaniaCities;
                mymodel.OceaniaScores = oceaniaScores;
                mymodel.Wellington = wellington;
                mymodel.WellingtonScore = wellingtonScore;
                mymodel.Adelaide = adelaide;
                mymodel.AdelaideScore = adelaideScore;
                mymodel.ChristChurch = christChurch;
                mymodel.ChristChurchScore = christChurchScore;
                mymodel.Melbourne = melbourne;
                mymodel.MelbourneScore = melbourneScore;
                mymodel.Brisbane = brisbane;
                mymodel.BrisbaneScore = brisbaneScore;

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

