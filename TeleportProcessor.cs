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
using static DemoLibrary2.Models.TeleportModel;

namespace DemoLibrary2
{
	public class TeleportProcessor
	{
		public static async Task<dynamic> LoadTeleport()
		{
            string url = "https://api.teleport.org/api/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                
                Console.WriteLine(response);
                
                if (response.IsSuccessStatusCode)
                {

                    var jsonString = await response.Content.ReadAsStringAsync();
                    var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString)!;

                    //Console.WriteLine("DYNAMIC");
                    //Console.WriteLine(dynamicObject);
                    //Console.WriteLine("LINK");
                    //Console.WriteLine(link);

                    //TeleportModel teleport = await response.Content.ReadAsAsync<TeleportModel>();
                    //Console.WriteLine("HEY");
                    //Console.WriteLine(teleport);
                    //Console.WriteLine("YOU");
                    return dynamicObject;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
	}
}
