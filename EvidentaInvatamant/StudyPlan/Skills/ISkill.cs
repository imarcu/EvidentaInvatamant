using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISkill
    {
        void PutSubjectsIn(List<ISubject> list);
        bool MatchesName(string name);
    }
}
