using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISkillRepository
    {
        void Add(ISkill skill);
        void Remove(ISkill skill);
        ISkill GetAt(int index);
        ISkillRepository SearchByName(string name);
    }
}
