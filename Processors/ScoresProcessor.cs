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

            public static async Task<ScoresModel.Scores.Root> LoadCasablancaScores()
            {
                return await LoadUrbanAreaScores("casablanca");
            }

            public static async Task<ScoresModel.Scores.Root> LoadLagosScores()
            {
                return await LoadUrbanAreaScores("lagos");
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
                mymodel.Casablanca = africaCities[2];
                mymodel.CasablancaScore = await LoadCasablancaScores();
                mymodel.Lagos = africaCities[5];
                mymodel.LagosScore = await LoadLagosScores();
                mymodel.Nairobi = africaCities[6];
                mymodel.NairobiScore = await LoadNairobiScores();

                return (mymodel);
            }
        }

        public class Asia
        {
            public static async Task<ScoresModel.Scores.Root> LoadDohaScores()
            {
                return await LoadUrbanAreaScores("doha");
            }

            public static async Task<ScoresModel.Scores.Root> LoadHongKongScores()
            {
                return await LoadUrbanAreaScores("hong-kong");
            }

            public static async Task<ScoresModel.Scores.Root> LoadManilaScores()
            {
                return await LoadUrbanAreaScores("manila");
            }

            public static async Task<ScoresModel.Scores.Root> LoadTaipeiScores()
            {
                return await LoadUrbanAreaScores("taipei");
            }

            public static async Task<ScoresModel.Scores.Root> LoadTokyoScores()
            {
                return await LoadUrbanAreaScores("tokyo");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var asiaUA = await UrbanAreasProcessor.LoadAsiaUrbanAreas();
                var asiaCities = asiaUA._links.uaitems;

                mymodel.Doha = asiaCities[11];
                mymodel.DohaScore = await LoadDohaScores();
                mymodel.HongKong = asiaCities[15];
                mymodel.HongKongScore = await LoadHongKongScores();
                mymodel.Manila = asiaCities[22];
                mymodel.ManilaScore = await LoadManilaScores();
                mymodel.Taipei = asiaCities[31];
                mymodel.TaipeiScore = await LoadTaipeiScores();
                mymodel.Tokyo = asiaCities[35];
                mymodel.TokyoScore = await LoadTokyoScores();

                return (mymodel);
            }
        }

        public class Europe
        {
            public static async Task<ScoresModel.Scores.Root> LoadAarhusScores()
            {
                return await LoadUrbanAreaScores("aarhus");
            }

            public static async Task<ScoresModel.Scores.Root> LoadChisinauScores()
            {
                return await LoadUrbanAreaScores("chisinau");
            }

            public static async Task<ScoresModel.Scores.Root> LoadLilleScores()
            {
                return await LoadUrbanAreaScores("lille");
            }

            public static async Task<ScoresModel.Scores.Root> LoadNaplesScores()
            {
                return await LoadUrbanAreaScores("naples");
            }

            public static async Task<ScoresModel.Scores.Root> LoadVilniusScores()
            {
                return await LoadUrbanAreaScores("vilnius");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var europeUA = await UrbanAreasProcessor.LoadEuropeUrbanAreas();
                var europeanCities = europeUA._links.uaitems;

                mymodel.Aarhus = europeanCities[0];
                mymodel.AarhusScore = await LoadAarhusScores();
                mymodel.Chisinau = europeanCities[23];
                mymodel.ChisinauScore = await LoadChisinauScores();
                mymodel.Lille = europeanCities[53];
                mymodel.LilleScore = await LoadLilleScores();
                mymodel.Naples = europeanCities[71];
                mymodel.NaplesScore = await LoadNaplesScores();
                mymodel.Vilnius = europeanCities[106];
                mymodel.VilniusScore = await LoadVilniusScores();

                return (mymodel);
            }
        }

        public class NorthAmerica
        {
            
            public static async Task<ScoresModel.Scores.Root> LoadBostonScores()
            {
                return await LoadUrbanAreaScores("boston");
            }

            public static async Task<ScoresModel.Scores.Root> LoadLasVegasScores()
            {
                return await LoadUrbanAreaScores("las-vegas");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMiamiScores()
            {
                return await LoadUrbanAreaScores("miami");
            }

            public static async Task<ScoresModel.Scores.Root> LoadNewYorkScores()
            {
                return await LoadUrbanAreaScores("new-york");
            }

            public static async Task<ScoresModel.Scores.Root> LoadWashingtonDCScores()
            {
                return await LoadUrbanAreaScores("washington-dc");
            }

            

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var northAmericaUA = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();
                var northAmericaCities = northAmericaUA._links.uaitems;

                mymodel.Boston = northAmericaCities[9];
                mymodel.BostonScore = await LoadBostonScores();
                mymodel.LasVegas = northAmericaCities[40];
                mymodel.LasVegasScore = await LoadLasVegasScores();
                mymodel.Miami = northAmericaCities[47];
                mymodel.MiamiScore = await LoadMiamiScores();
                mymodel.NewYork = northAmericaCities[53];
                mymodel.NewYorkScore = await LoadNewYorkScores();
                mymodel.WashingtonDC = northAmericaCities[85];
                mymodel.WashingtonDCScore = await LoadWashingtonDCScores();
                
                return (mymodel);
            }
        }

        public class Oceania
        {
            public static async Task<ScoresModel.Scores.Root> LoadAdelaideScores()
            {
                return await LoadUrbanAreaScores("adelaide");
            }

            public static async Task<ScoresModel.Scores.Root> LoadBrisbaneScores()
            {
                return await LoadUrbanAreaScores("brisbane");
            }

            public static async Task<ScoresModel.Scores.Root> LoadChristChurchScores()
            {
                return await LoadUrbanAreaScores("christchurch");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMelbourneScores()
            {
                return await LoadUrbanAreaScores("melbourne");
            }

            public static async Task<ScoresModel.Scores.Root> LoadWellingtonScores()
            {
                return await LoadUrbanAreaScores("wellington");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var oceaniaUA = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();
                var oceaniaCities = oceaniaUA._links.uaitems;

                mymodel.Adelaide = oceaniaCities[0];
                mymodel.AdelaideScore = await LoadAdelaideScores();
                mymodel.Brisbane = oceaniaCities[2];
                mymodel.BrisbaneScore = await LoadBrisbaneScores();
                mymodel.ChristChurch = oceaniaCities[3];
                mymodel.ChristChurchScore = await LoadChristChurchScores();
                mymodel.Melbourne = oceaniaCities[4];
                mymodel.MelbourneScore = await LoadMelbourneScores();
                mymodel.Wellington = oceaniaCities[7];
                mymodel.WellingtonScore = await LoadWellingtonScores();

                return (mymodel);
            }
        }

        public class SouthAmerica
        {
            public static async Task<ScoresModel.Scores.Root> LoadBogotaScores()
            {
                return await LoadUrbanAreaScores("bogota");
            }

            public static async Task<ScoresModel.Scores.Root> LoadCaracasScores()
            {
                return await LoadUrbanAreaScores("caracas");
            }

            public static async Task<ScoresModel.Scores.Root> LoadMedellinScores()
            {
                return await LoadUrbanAreaScores("medellin");
            }

            public static async Task<ScoresModel.Scores.Root> LoadPortoAlegreScores()
            {
                return await LoadUrbanAreaScores("porto-alegre");
            }

            public static async Task<ScoresModel.Scores.Root> LoadSaoPauloScores()
            {
                return await LoadUrbanAreaScores("sao-paulo");
            }

            public static async Task<TeleportViewModel> ProcessNameAndScores()
            {
                TeleportViewModel mymodel = new TeleportViewModel();

                var southAmericaUA = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();
                var SACities = southAmericaUA._links.uaitems;

                mymodel.Bogota = SACities[1];
                mymodel.BogotaScore = await LoadBogotaScores();
                mymodel.Caracas = SACities[3];
                mymodel.CaracasScore = await LoadCaracasScores();
                mymodel.Medellin = SACities[8];
                mymodel.MedellinScore = await LoadMedellinScores();
                mymodel.PortoAlegre = SACities[10];
                mymodel.PortoAlegreScore = await LoadPortoAlegreScores();
                mymodel.SaoPaulo = SACities[14];
                mymodel.SaoPauloScore = await LoadSaoPauloScores();

                return (mymodel);
            }
        }
    }
}
