using System.Collections.Generic;
using System.Linq;

namespace GameCityApi.Models
{
    public class SkillViewModel
    {
        public Skill Skill { get; set; }

        public IEnumerable<string> SuggestedHelpSkills { get; set; }

        public SkillViewModel(IEnumerable<Skill> allSkills, IEnumerable<SuggestedHelp> suggestedHelpSkills)
        {
            SuggestedHelpSkills = allSkills
                .Where(skill => suggestedHelpSkills
                    .Where(shs => shs.SkillId == Skill.Id)
                    .Select(shs => shs.SkillId)
                    .Contains(skill.Id))
                .Select(skill => skill.Name);
        }
    }
}
