using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DemoLibrary;
using System.Security.Policy;
using DemoLibrary2.Models;

namespace DemoLibrary2
{
	public class TeleportProcessor
	{
		public static async Task<TeleportModel> LoadTeleport()
		{
            var url = "https://api.teleport.org/api/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    TeleportModel teleport = await response.Content.ReadAsAsync<TeleportModel>();
                    Console.WriteLine(teleport);
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

