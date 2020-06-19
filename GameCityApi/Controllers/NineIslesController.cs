using GameCityApi.Data;
using GameCityApi.Models.NineIsles;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameCityApi.Controllers
{
    public class NineIslesController : Controller
    {
        private readonly INineIslesService _nineIslesService;

        public NineIslesController(INineIslesService nineIslesService)
        {
            _nineIslesService = nineIslesService;
        }

        [HttpGet]
        public string Index()
        {
            return "Welcome to the Game City API Nine Isles Service";
        }

        [HttpGet]
        public NineIslesData GetNineIslesData(string godName = null)
        {
            return NineIslesAviasta.GetNineIslesData();
        }

        [HttpGet]
        public async Task<IEnumerable<Research>> GetAllResearch()
        {
            return await _nineIslesService.GetAllResearchAsync();
        }
    }
}
