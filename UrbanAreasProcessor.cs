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
using static DemoLibrary2.Models.UrbanAreasModel;

namespace DemoLibrary2
{
	public class UrbanAreasProcessor
	{
        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadAfricaUrbanAreas()
        {
            string africaUrl = "https://api.teleport.org/api/continents/geonames:AF/urban_areas/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(africaUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    UrbanAreasModel.UrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadAsiaUrbanAreas()
        {
            string asiaURL = "https://api.teleport.org/api/continents/geonames:AS/urban_areas/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(asiaURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    UrbanAreasModel.UrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadSouthAmericaUrbanAreas()
        {
            string southAmericaUrl = "https://api.teleport.org/api/continents/geonames:SA/urban_areas/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(southAmericaUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    UrbanAreasModel.UrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadNorthAmericaUrbanAreas()
        {
            string northAmerciaURL = "https://api.teleport.org/api/continents/geonames:NA/urban_areas/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(northAmerciaURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    UrbanAreasModel.UrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.UrbanAreas.Root> LoadOceaniaUrbanAreas()
        {
            string northAmerciaURL = "https://api.teleport.org/api/continents/geonames:OC/urban_areas/";
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(northAmerciaURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    UrbanAreasModel.UrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.UrbanAreas.Root>(jsonString);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
