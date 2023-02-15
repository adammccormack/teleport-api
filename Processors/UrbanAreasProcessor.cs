using System.Net.Http;
using DemoLibrary;
using DemoLibrary2.Models;
using Newtonsoft.Json;

namespace DemoLibrary2
{
	public class UrbanAreasProcessor
	{
        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadUrbanAreas(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var scores = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return scores;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadAfricaUrbanAreas()
        {
            string africaUrl = "https://api.teleport.org/api/continents/geonames:AF/urban_areas/";
            return await LoadUrbanAreas(africaUrl);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadAsiaUrbanAreas()
        {
            string asiaUrl = "https://api.teleport.org/api/continents/geonames:AS/urban_areas/";
            return await LoadUrbanAreas(asiaUrl);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadSouthAmericaUrbanAreas()
        {
            string southAamericaUrl = "https://api.teleport.org/api/continents/geonames:SA/urban_areas/";
            return await LoadUrbanAreas(southAamericaUrl);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadNorthAmericaUrbanAreas()
        {
            string northAamericaUrl = "https://api.teleport.org/api/continents/geonames:NA/urban_areas/";
            return await LoadUrbanAreas(northAamericaUrl);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadOceaniaUrbanAreas()
        {
            string oceaniaUrl = "https://api.teleport.org/api/continents/geonames:OC/urban_areas/";
            return await LoadUrbanAreas(oceaniaUrl);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadEuropeUrbanAreas()
        {
            string europeUrl = "https://api.teleport.org/api/continents/geonames:EU/urban_areas/";
            return await LoadUrbanAreas(europeUrl);
        }
    }
}
