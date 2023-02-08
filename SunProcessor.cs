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
using static DemoLibrary2.Models.SunModel;

namespace DemoLibrary2
{
	public class SunProcessor
	{
        public static async Task<SunModel> LoadSunData()
        {
            string url = "https://api.sunrise-sunset.org/json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {

                if (response.IsSuccessStatusCode)
                {
                    // test sunModel can be inspected in Debug mode

                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();

                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

