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
            string url = "https://api.teleport.org/api/continents/geonames:AF/urban_areas/";
            return await LoadUrbanAreas(url);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadAsiaUrbanAreas()
        {
            string url = "https://api.teleport.org/api/continents/geonames:AS/urban_areas/";
            return await LoadUrbanAreas(url);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadEuropeUrbanAreas()
        {
            string url = "https://api.teleport.org/api/continents/geonames:SA/urban_areas/";
            return await LoadUrbanAreas(url);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadNorthAmericaUrbanAreas()
        {
            string url = "https://api.teleport.org/api/continents/geonames:NA/urban_areas/";
            return await LoadUrbanAreas(url);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadOceaniaUrbanAreas()
        {
            string url = "https://api.teleport.org/api/continents/geonames:OC/urban_areas/";
            return await LoadUrbanAreas(url);
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadSouthAmericaUrbanAreas()
        {
            string url = "https://api.teleport.org/api/continents/geonames:EU/urban_areas/";
            return await LoadUrbanAreas(url);
        }
    }
}
