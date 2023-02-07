using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DemoLibrary2.Models
{
	public partial class TeleportModel
	{

        //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class CityById
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class CitySearch
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class ContinentById
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class ContinentList
        {
            public string? href { get; set; }
        }

        public class CountryById
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class CountryList
        {
            public string? href { get; set; }
        }

        public class Cury
        {
            public string? href { get; set; }
            public string? name { get; set; }
            public bool templated { get; set; }
        }

        public class FlockCreatePlan
        {
            public string href { get; set; }
        }

        public class Links
        {
            [JsonProperty("city:by-id")]
            public CityById citybyid { get; set; }

            [JsonProperty("city:search")]
            public CitySearch citysearch { get; set; }

            [JsonProperty("continent:by-id")]
            public ContinentById continentbyid { get; set; }

            [JsonProperty("continent:list")]
            public ContinentList continentlist { get; set; }

            [JsonProperty("country:by-id")]
            public CountryById countrybyid { get; set; }

            [JsonProperty("country:list")]
            public CountryList countrylist { get; set; }
            public List<Cury> curies { get; set; }

            [JsonProperty("flock:create-plan")]
            public FlockCreatePlan flockcreateplan { get; set; }

            [JsonProperty("location:by-coordinates")]
            public LocationByCoordinates locationbycoordinates { get; set; }
            public Self self { get; set; }

            [JsonProperty("tz:by-id")]
            public TzById tzbyid { get; set; }

            [JsonProperty("tz:list")]
            public TzList tzlist { get; set; }

            [JsonProperty("ua:by-id")]
            public UaById uabyid { get; set; }

            [JsonProperty("ua:list")]
            public UaList ualist { get; set; }
        }

        public class LocationByCoordinates
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class Root
        {
            public Links _links { get; set; }
        }

        public class Self
        {
            public string? href { get; set; }
        }

        public class TzById
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class TzList
        {
            public string? href { get; set; }
        }

        public class UaById
        {
            public string? href { get; set; }
            public bool templated { get; set; }
        }

        public class UaList
        {
            public string? href { get; set; }
        }

    }
}

