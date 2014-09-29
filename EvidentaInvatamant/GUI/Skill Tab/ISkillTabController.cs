using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISkillTabController
    {

        void SkillSelected(ISkill skill);

        void PopulateSkills();
    }
}
