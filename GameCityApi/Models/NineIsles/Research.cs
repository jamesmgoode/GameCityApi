using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GameCityApi.Models.NineIsles
{
    public class Research
    {
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ResearchType ResearchType { get; set; }

        public int Level { get; set; }
    }
}
