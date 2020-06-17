using GameCityApi.Data;
using GameCityApi.Models.NineIsles;
using Microsoft.AspNetCore.Mvc;

namespace GameCityApi.Controllers
{
    public class NineIslesController : Controller
    {
        public NineIslesController() { }

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
    }
}
