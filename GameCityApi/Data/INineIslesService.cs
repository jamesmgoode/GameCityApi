using GameCityApi.Models.NineIsles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCityApi.Data
{
    public interface INineIslesService
    {
        Task<IEnumerable<Research>> GetAllResearchAsync();
    }
}
