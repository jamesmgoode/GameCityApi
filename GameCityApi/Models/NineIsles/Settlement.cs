using System.Collections.Generic;

namespace GameCityApi.Models.NineIsles
{
    public class Settlement
    {
        public string Name { get; set; }

        public IEnumerable<Building> Buildings { get; set; }
    }
}
