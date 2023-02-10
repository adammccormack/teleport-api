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
        public static async Task<UrbanAreasModel.AfricaUrbanAreas.Root> LoadAfricaUrbanAreas()
        {
            string africaUrl = "https://api.teleport.org/api/continents/geonames:AF/urban_areas/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(africaUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    UrbanAreasModel.AfricaUrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.AfricaUrbanAreas.Root>(jsonString);

                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.AsiaUrbanAreas.Root> LoadAsiaUrbanAreas()
        {
            string asiaURL = "https://api.teleport.org/api/continents/geonames:AS/urban_areas/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(asiaURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    UrbanAreasModel.AsiaUrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.AsiaUrbanAreas.Root>(jsonString);

                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<UrbanAreasModel.NorthAmericaUrbanAreas.Root> LoadNorthAmericaUrbanAreas()
        {
            string northAmerciaURL = "https://api.teleport.org/api/continents/geonames:NA/urban_areas/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(northAmerciaURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    UrbanAreasModel.NorthAmericaUrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<UrbanAreasModel.NorthAmericaUrbanAreas.Root>(jsonString);

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
