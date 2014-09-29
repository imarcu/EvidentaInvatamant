using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISkillTabVIew
    {
        void AddSkill(ISkill skill);

        void UpdateSkillName(string p);

        void UpdateSkillDescription(string p);

        void AddSkillSubject(ISubject subject);

        void SubjectsClear();

        void ClearSkills();

        void ShowErrorMessage(string p);
    }
}
