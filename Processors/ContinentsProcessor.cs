using System.Net.Http;
using DemoLibrary;
using DemoLibrary2.Models;
using Newtonsoft.Json;

namespace DemoLibrary2
{
	public class ContinentsProcessor
	{
        public static async Task<ContinentsModel.Root> LoadContinents()
        {   
            string url = "https://api.teleport.org/api/continents/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    ContinentsModel.Root? continentItems = JsonConvert.DeserializeObject<ContinentsModel.Root>(jsonString);
                    return continentItems;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
