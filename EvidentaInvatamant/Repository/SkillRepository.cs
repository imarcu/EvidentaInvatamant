using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class SkillRepository:ISkillRepository
    {
        List<ISkill> skills;

        public SkillRepository()
        {
            skills = new List<ISkill>();
        }

        public void Add(ISkill skill)
        {
            skills.Add(skill);
        }

        public void Remove(ISkill skill)
        {
            skills.Remove(skill);
        }

        public ISkill GetAt(int index)
        {
            return skills[index];
        }

        public ISkillRepository SearchByName(string name)
        {
            ISkillRepository tempRepository = new SkillRepository();

            foreach (ISkill skill in skills)
            {
                //
            }

            return tempRepository;
        }
    }
}
