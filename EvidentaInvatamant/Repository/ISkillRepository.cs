using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISkillRepository
    {
        bool Add(ISkill skill);
        void Remove(ISkill skill);
        ISkill GetAt(int index);
        int GetSize();
        ISkill SearchByName(string name);
    }
}
