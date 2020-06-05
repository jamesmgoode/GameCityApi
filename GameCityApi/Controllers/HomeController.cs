using Microsoft.AspNetCore.Mvc;

namespace GameCityApi.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Welcome to the Game City Api Service";
        }
    }
}
