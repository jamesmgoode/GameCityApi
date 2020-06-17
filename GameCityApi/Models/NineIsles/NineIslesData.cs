using System.Collections.Generic;

namespace GameCityApi.Models.NineIsles
{
    public class NineIslesData
    {
        public IEnumerable<Settlement> Settlements { get; set; }

        public IEnumerable<Research> ResearchData { get; set; }
    }
}
