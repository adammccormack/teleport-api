using System;
namespace DemoLibrary2.Models
{
	public class ScoresModel
	{
        public partial class Scores
        {
            public class Category
            {
                public string? color { get; set; }
                public string? name { get; set; }
                public double score_out_of_10 { get; set; }
            }

            public class Cury
            {
                public string? href { get; set; }
                public string? name { get; set; }
                public bool templated { get; set; }
            }

            public class Links
            {
                public List<Cury>? curies { get; set; }
                public Self? self { get; set; }
            }

            public class Root
            {
                public Links? _links { get; set; }
                public List<Category>? categories { get; set; }
                public string? summary { get; set; }
                public double teleport_city_score { get; set; }

                public static implicit operator Root(List<Root> v)
                {
                    throw new NotImplementedException();
                }
            }

            public class Self
            {
                public string? href { get; set; }
            }
        }
    }
}
