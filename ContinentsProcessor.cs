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
using static DemoLibrary2.Models.ContinentsModel;

namespace DemoLibrary2
{
	public class ContinentsProcessor
	{
        public static async Task<ContinentsModel.Root> LoadContinents()
        {
            string url = "https://api.teleport.org/api/continents/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {

                Console.WriteLine(response);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    ContinentsModel.Root myDeserializedClass = JsonConvert.DeserializeObject<ContinentsModel.Root>(jsonString);

                    Console.WriteLine(myDeserializedClass);
                    return myDeserializedClass;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        //public static async Task<TeleportModel.Root> LoadTeleport()
        //{
        //          string url = "https://api.teleport.org/api/";

        //          using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        //          {

        //              Console.WriteLine(response);

        //              if (response.IsSuccessStatusCode)
        //              {
        //                  //TeleportModel result = await response.Content.ReadAsAsync<TeleportModel>();
        //                  var jsonString = await response.Content.ReadAsStringAsync();
        //                  //var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString)!;
        //                  TeleportModel.Root myDeserializedClass = JsonConvert.DeserializeObject<TeleportModel.Root>(jsonString);
        //                  // convert jsonString to Model object

        //                  // test sunModel can be inspected in Debug mode

        //                  //var continentList = dynamicObject._links["continent:list"];
        //                  //Console.WriteLine(continentList);
        //                  //var citybyid = links["city:by-id"];

        //                  //TeleportModel teleport = await response.Content.ReadAsAsync<TeleportModel>();
        //                  Console.WriteLine(myDeserializedClass);
        //                  return myDeserializedClass;
        //              }
        //              else
        //              {
        //                  throw new Exception(response.ReasonPhrase);
        //              }
        //          }
        //      }
    }
}
