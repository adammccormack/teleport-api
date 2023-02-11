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

namespace DemoLibrary2
{
	public class ScoresProcessor
	{
        // North America
        public static async Task<ScoresModel.Scores.Root> LoadBostonScores()
        {
            string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
            using (HttpResponseMessage bostonResponse = await ApiHelper.ApiClient.GetAsync(bostonUrl))
            {
                if (bostonResponse.IsSuccessStatusCode)
                {
                    var bostonJsonString = await bostonResponse.Content.ReadAsStringAsync();
                    var bostonScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(bostonJsonString);
                    return (bostonScores);
                }
                else
                {
                    throw new Exception(bostonResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.Scores.Root> LoadLasVegasScores()
        {
            string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
            using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasUrl))
            {
                if (lasVegasResponse.IsSuccessStatusCode)
                {
                    var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();
                    var lasVegasScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(lasVegasJsonString);
                    return (lasVegasScores);
                }
                else
                {
                    throw new Exception(lasVegasResponse.ReasonPhrase);
                }
            }
        }
        public static async Task<ScoresModel.Scores.Root> LoadNewYorkScores()
        {
            string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";
 
            using (HttpResponseMessage newYorkResponse = await ApiHelper.ApiClient.GetAsync(newYorkUrl))
            
            {
                if (newYorkResponse.IsSuccessStatusCode)
                    
                {
                    var newYorkJsonString = await newYorkResponse.Content.ReadAsStringAsync();
                    var newYorkScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(newYorkJsonString);
                    return (newYorkScores);
                }
                else
                {
                    throw new Exception(newYorkResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.Scores.Root> LoadWashingtonDCScores()
        {
            string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";

            using (HttpResponseMessage washingtonDCResponse = await ApiHelper.ApiClient.GetAsync(washingtonDCUrl))
            {
                if (
                    washingtonDCResponse.IsSuccessStatusCode)
                {
                    var washingtonDCJsonString = await washingtonDCResponse.Content.ReadAsStringAsync();
                    var washingtonDCScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(washingtonDCJsonString);
                    return (washingtonDCScores);
                }
                else
                {
                    throw new Exception(washingtonDCResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.Scores.Root> LoadMiamiScores()
        {
            string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";
            using (HttpResponseMessage miamiResponse = await ApiHelper.ApiClient.GetAsync(miamiUrl))
            {
                if (miamiResponse.IsSuccessStatusCode)
                {
                    var miamiJsonString = await miamiResponse.Content.ReadAsStringAsync();
                    var miamiScores = JsonConvert.DeserializeObject<ScoresModel.Scores.Root>(miamiJsonString);
                    return (miamiScores);
                }
                else
                {
                    throw new Exception(miamiResponse.ReasonPhrase);
                }
            }
        }

        // Africa
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

        //Asia
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
    }
}


