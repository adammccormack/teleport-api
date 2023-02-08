﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoLibrary2.Models
{
	public partial class AfricaUrbanAreas
	{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Cury
        {
            public string href { get; set; }
            public string name { get; set; }
            public bool templated { get; set; }
        }

        public class Links
        {
            public List<Cury> curies { get; set; }
            public Self self { get; set; }

            [JsonProperty("ua:items")]
            public List<UaItem> uaitems { get; set; }
        }

        public class Root
        {
            public Links _links { get; set; }
            public int count { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }

        public class UaItem
        {
            public string href { get; set; }
            public string name { get; set; }
        }
    }

    public partial class AsiaUrbanAreas
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ContinentCountries
        {
            public string href { get; set; }
        }

        public class ContinentUrbanAreas
        {
            public string href { get; set; }
        }

        public class Cury
        {
            public string href { get; set; }
            public string name { get; set; }
            public bool templated { get; set; }
        }

        public class Links
        {
            [JsonProperty("continent:countries")]
            public ContinentCountries continentcountries { get; set; }

            [JsonProperty("continent:urban_areas")]
            public ContinentUrbanAreas continenturban_areas { get; set; }
            public List<Cury> curies { get; set; }
            public Self self { get; set; }
        }

        public class Root
        {
            public Links _links { get; set; }
            public string geonames_code { get; set; }
            public string name { get; set; }
        }

        public class Self
        {
            public string href { get; set; }
        }


    }
}

