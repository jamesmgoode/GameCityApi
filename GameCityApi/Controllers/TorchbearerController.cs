using System.Collections.Generic;
using System.Linq;
using GameCityApi.Data;
using GameCityApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameCityApi.Controllers
{
    public class TorchbearerController : Controller
    {
        private readonly TorchbearerContext _torchbearerContext;

        public TorchbearerController(TorchbearerContext torchbearerContext)
        {
            _torchbearerContext = torchbearerContext;
        }

        [HttpGet]
        public string Index()
        {
            return "Welcome to the Game City API Torchbearer Service";
        }

        [HttpGet]
        public IEnumerable<SkillViewModel> GetTorchbearerSkills()
        {
            var skills = _torchbearerContext.Skills.ToList();
            var suggestedHelpSkills = _torchbearerContext.SuggestedHelp.ToList();

            var skillViewModels = new List<SkillViewModel>();
            foreach (var skill in skills)
            {
                skillViewModels.Add(new SkillViewModel(skills, suggestedHelpSkills) { Skill = skill });
            }

            return skillViewModels.OrderBy(s => s.Skill.Name).ToList();
        }
    }
}
