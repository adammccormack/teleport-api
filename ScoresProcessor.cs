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
        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadBostonScores()
        {
            string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
            using (HttpResponseMessage bostonResponse = await ApiHelper.ApiClient.GetAsync(bostonUrl))
            {
                if (bostonResponse.IsSuccessStatusCode)
                {
                    var bostonJsonString = await bostonResponse.Content.ReadAsStringAsync();
                    var bostonScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(bostonJsonString);
                    return (bostonScores);
                }
                else
                {
                    throw new Exception(bostonResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadLasVegasScores()
        {
            string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
            using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasUrl))
            {
                if (lasVegasResponse.IsSuccessStatusCode)
                {
                    var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();
                    var lasVegasScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(lasVegasJsonString);
                    return (lasVegasScores);
                }
                else
                {
                    throw new Exception(lasVegasResponse.ReasonPhrase);
                }
            }
        }
        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadNewYorkScores()
        {
            string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";
 
            using (HttpResponseMessage newYorkResponse = await ApiHelper.ApiClient.GetAsync(newYorkUrl))
            
            {
                if (newYorkResponse.IsSuccessStatusCode)
                    
                {
                    var newYorkJsonString = await newYorkResponse.Content.ReadAsStringAsync();
                    var newYorkScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(newYorkJsonString);
                    return (newYorkScores);
                }
                else
                {
                    throw new Exception(newYorkResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadWashingtonDCScores()
        {
            string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";

            using (HttpResponseMessage washingtonDCResponse = await ApiHelper.ApiClient.GetAsync(washingtonDCUrl))
            {
                if (
                    washingtonDCResponse.IsSuccessStatusCode)
                {
                    var washingtonDCJsonString = await washingtonDCResponse.Content.ReadAsStringAsync();
                    var washingtonDCScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(washingtonDCJsonString);
                    return (washingtonDCScores);
                }
                else
                {
                    throw new Exception(washingtonDCResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadMiamiScores()
        {
            string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";
            using (HttpResponseMessage miamiResponse = await ApiHelper.ApiClient.GetAsync(miamiUrl))
            {
                if (miamiResponse.IsSuccessStatusCode)
                {
                    var miamiJsonString = await miamiResponse.Content.ReadAsStringAsync();
                    var miamiScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(miamiJsonString);
                    return (miamiScores);
                }
                else
                {
                    throw new Exception(miamiResponse.ReasonPhrase);
                }
            }
        }

        // Africa
        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadCairoScores()
        {
            string cairoUrl = "https://api.teleport.org/api/urban_areas/slug:cairo/scores/";
            using (HttpResponseMessage cairoResponse = await ApiHelper.ApiClient.GetAsync(cairoUrl))
            {
                if (cairoResponse.IsSuccessStatusCode)
                {
                    var cairoJsonString = await cairoResponse.Content.ReadAsStringAsync();
                    var cairoScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(cairoJsonString);
                    return (cairoScores);
                }
                else
                {
                    throw new Exception(cairoResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadCapeTownScores()
        {
            string capeTownUrl = "https://api.teleport.org/api/urban_areas/slug:cape-town/scores/";
            using (HttpResponseMessage capeTownResponse = await ApiHelper.ApiClient.GetAsync(capeTownUrl))
            {
                if (capeTownResponse.IsSuccessStatusCode)
                {
                    var capeTownJsonString = await capeTownResponse.Content.ReadAsStringAsync();
                    var capeTownScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(capeTownJsonString);
                    return (capeTownScores);
                }
                else
                {
                    throw new Exception(capeTownResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadCasablancaScores()
        {
            string casablancaUrl = "https://api.teleport.org/api/urban_areas/slug:casablanca/scores/";
            using (HttpResponseMessage casablancaResponse = await ApiHelper.ApiClient.GetAsync(casablancaUrl))
            {
                if (casablancaResponse.IsSuccessStatusCode)
                {
                    var casablancaJsonString = await casablancaResponse.Content.ReadAsStringAsync();
                    var casablancaScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(casablancaJsonString);
                    return (casablancaScores);
                }
                else
                {
                    throw new Exception(casablancaResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadLagosScores()
        {
            string lagosUrl = "https://api.teleport.org/api/urban_areas/slug:lagos/scores/";
            using (HttpResponseMessage lagosResponse = await ApiHelper.ApiClient.GetAsync(lagosUrl))
            {
                if (lagosResponse.IsSuccessStatusCode)
                {
                    var lagosJsonString = await lagosResponse.Content.ReadAsStringAsync();
                    var lagosScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(lagosJsonString);
                    return (lagosScores);
                }
                else
                {
                    throw new Exception(lagosResponse.ReasonPhrase);
                }
            }
        }

        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadNairobiScores()
        {
            string nairobiUrl = "https://api.teleport.org/api/urban_areas/slug:nairobi/scores/";
            using (HttpResponseMessage nairobiResponse = await ApiHelper.ApiClient.GetAsync(nairobiUrl))
            {
                if (nairobiResponse.IsSuccessStatusCode)
                {
                    var nairobiJsonString = await nairobiResponse.Content.ReadAsStringAsync();
                    var nairobiScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(nairobiJsonString);
                    return (nairobiScores);
                }
                else
                {
                    throw new Exception(nairobiResponse.ReasonPhrase);
                }
            }
        }

    }
}


