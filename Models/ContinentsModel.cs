using System;
using Newtonsoft.Json;

namespace DemoLibrary2.Models
{
	public partial class ContinentsModel
	{
        public class ContinentItem
        {
            public string? href { get; set; }
            public string? name { get; set; }
        }

        public class Cury
        {
            public string? href { get; set; }
            public string? name { get; set; }
            public bool templated { get; set; }
        }

        public class Links
        {
            [JsonProperty("continent:items")]
            public List<ContinentItem>? continentitems { get; set; }
            public List<Cury>? curies { get; set; }
            public Self? self { get; set; }
        }

        public class Root
        {
            public Links? _links { get; set; }
            public int count { get; set; }
        }

        public class Self
        {
            public string? href { get; set; }
        }
    }
}
