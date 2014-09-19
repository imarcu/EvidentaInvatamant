using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    interface IStudyPlan
    {
        void Print();
        void ComputePlan();
        void GetSubjectsFrom(ISkill skill);
    }
}
