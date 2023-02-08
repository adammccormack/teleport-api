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

namespace DemoLibrary2
{
	public class ScoresProcessor
	{
        public static async Task<ScoresModel.NorthAmericaScores.Root> LoadNorthAmericaScores()
        {
            string albuquerqueUrl = "https://api.teleport.org/api/urban_areas/slug:albuquerque/scores/";
            string lasVegasScoreUrl = "https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/";

            using (HttpResponseMessage albuquerqueResponse = await ApiHelper.ApiClient.GetAsync(albuquerqueUrl))
            using (HttpResponseMessage lasVegasResponse = await ApiHelper.ApiClient.GetAsync(lasVegasScoreUrl))
            {
                if (albuquerqueResponse.IsSuccessStatusCode || lasVegasResponse.IsSuccessStatusCode)
                {
                    var albuquerqueJsonString = await albuquerqueResponse.Content.ReadAsStringAsync();
                    var lasVegasJsonString = await lasVegasResponse.Content.ReadAsStringAsync();

                    ScoresModel.NorthAmericaScores.Root albuquerqueDeserialized = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(albuquerqueJsonString);
                    ScoresModel.NorthAmericaScores.Root lasVegasDeserialized = JsonConvert.DeserializeObject<ScoresModel.NorthAmericaScores.Root>(lasVegasJsonString);

                    return albuquerqueDeserialized;
                }
                else
                {
                    throw new Exception(albuquerqueResponse.ReasonPhrase);
                }
            }
        }
    }
}

