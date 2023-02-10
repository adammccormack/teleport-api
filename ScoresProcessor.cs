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
using static DemoLibrary2.Models.ScoresModel.NorthAmericaScores.Root;
using Microsoft.AspNetCore.Mvc.Rendering;
using static DemoLibrary2.Models.ScoresModel.NorthAmericaScores;

namespace DemoLibrary2
{
	public class ScoresProcessor
	{
        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadBostonScores()
        {
            string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
            string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
            string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";
            string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";
            string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";


            using (HttpResponseMessage bostonResponse = await ApiHelper.ApiClient.GetAsync(bostonUrl))
            using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasUrl))
            using (HttpResponseMessage newYorkResponse = await ApiHelper.ApiClient.GetAsync(newYorkUrl))
            using (HttpResponseMessage washingtonDCResponse = await ApiHelper.ApiClient.GetAsync(washingtonDCUrl))
            using (HttpResponseMessage miamiResponse = await ApiHelper.ApiClient.GetAsync(miamiUrl))


            {
                if (bostonResponse.IsSuccessStatusCode || lasVegasResponse.IsSuccessStatusCode ||
                    newYorkResponse.IsSuccessStatusCode || washingtonDCResponse.IsSuccessStatusCode || miamiResponse.IsSuccessStatusCode)
                {
                    var bostonJsonString = await bostonResponse.Content.ReadAsStringAsync();
                    var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();
                    var newYorkJsonString = await newYorkResponse.Content.ReadAsStringAsync();
                    var washingtonDCJsonString = await washingtonDCResponse.Content.ReadAsStringAsync();
                    var miamiJsonString = await miamiResponse.Content.ReadAsStringAsync();

                    var bostonScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(bostonJsonString);
                    var lasVegasScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(lasVegasJsonString);
                    var newYorkScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(newYorkJsonString);
                    var washingtonDCScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(washingtonDCJsonString);
                    var miamiScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(miamiJsonString);

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
            string bostonUrl = "https://api.teleport.org/api/urban_areas/slug:boston/scores/";
            string lasVegasUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";
            string newYorkUrl = "https://api.teleport.org/api/urban_areas/slug:new-york/scores/";
            string washingtonDCUrl = "https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/";
            string miamiUrl = "https://api.teleport.org/api/urban_areas/slug:miami/scores/";


            using (HttpResponseMessage bostonResponse = await ApiHelper.ApiClient.GetAsync(bostonUrl))
            using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasUrl))
            using (HttpResponseMessage newYorkResponse = await ApiHelper.ApiClient.GetAsync(newYorkUrl))
            using (HttpResponseMessage washingtonDCResponse = await ApiHelper.ApiClient.GetAsync(washingtonDCUrl))
            using (HttpResponseMessage miamiResponse = await ApiHelper.ApiClient.GetAsync(miamiUrl))


            {
                if (bostonResponse.IsSuccessStatusCode || lasVegasResponse.IsSuccessStatusCode ||
                    newYorkResponse.IsSuccessStatusCode || washingtonDCResponse.IsSuccessStatusCode || miamiResponse.IsSuccessStatusCode)
                {
                    var bostonJsonString = await bostonResponse.Content.ReadAsStringAsync();
                    var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();
                    var newYorkJsonString = await newYorkResponse.Content.ReadAsStringAsync();
                    var washingtonDCJsonString = await washingtonDCResponse.Content.ReadAsStringAsync();
                    var miamiJsonString = await miamiResponse.Content.ReadAsStringAsync();

                    var bostonScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(bostonJsonString);
                    var lasVegasScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(lasVegasJsonString);
                    var newYorkScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(newYorkJsonString);
                    var washingtonDCScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(washingtonDCJsonString);
                    var miamiScores = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(miamiJsonString);

                    return (lasVegasScores);
                }
                else
                {
                    throw new Exception(bostonResponse.ReasonPhrase);
                }
            }
        }
    }
}
