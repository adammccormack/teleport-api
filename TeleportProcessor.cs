﻿using System;
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
            string url = "https://api.teleport.org/api/continents/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                
                Console.WriteLine(response);
                
                if (response.IsSuccessStatusCode)
                {

                    var jsonString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("HEY");
                    Console.WriteLine(jsonString);
                    Console.WriteLine("YOU");
                    //TeleportModel teleport = await response.Content.ReadAsAsync<TeleportModel>();
                    //Console.WriteLine("HEY");
                    //Console.WriteLine(teleport);
                    //Console.WriteLine("YOU");
                    return null;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
	}
}
