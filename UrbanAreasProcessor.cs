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
using static DemoLibrary2.Models.AfricaUrbanAreas;

namespace DemoLibrary2
{
	public class UrbanAreasProcessor
	{
        public static async Task<AfricaUrbanAreas.Root> LoadAfricaUrbanAreas()
        {
            string africaUrl = "https://api.teleport.org/api/continents/geonames:AF/urban_areas/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(africaUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    AfricaUrbanAreas.Root myDeserializedClass = JsonConvert.DeserializeObject<AfricaUrbanAreas.Root>(jsonString);

                    Console.WriteLine(myDeserializedClass);
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

