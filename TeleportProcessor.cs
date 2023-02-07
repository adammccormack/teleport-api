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
		public static async Task<TeleportModel> LoadTeleport()
		{
            string url = "https://api.teleport.org/api/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                Console.WriteLine("RESPONSE 1");
                Console.WriteLine(response);
                Console.WriteLine("RESPONSE 2");
                if (response.IsSuccessStatusCode)
                {
                    TeleportModel teleport = await response.Content.ReadAsAsync<TeleportModel>();
                    
                    return teleport;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
	}
}
