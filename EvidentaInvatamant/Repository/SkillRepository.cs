using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    public class SkillRepository:ISkillRepository
    {
        List<ISkill> skills;

        public SkillRepository()
        {
            skills = new List<ISkill>();
        }

        public bool Add(ISkill skill)
        {
            if (NotAlreadyIn(skill))
            {
                skills.Add(skill);
                return true;
            }
            return false;
        }
        private bool NotAlreadyIn(ISkill skill)
        {
            return SearchByName(skill.Name) == null;
        }

        public void Remove(ISkill skill)
        {
            skills.Remove(skill);
        }

        public ISkill GetAt(int index)
        {
            return skills[index];
        }

        public ISkill SearchByName(string name)
        {
           

            foreach (ISkill skill in skills)
            {
                if (skill.MatchesName(name))
                {
                    return skill;
                }
            }

            return null;
        }


        public int GetSize()
        {
            return skills.Count();
        }
    }
}
