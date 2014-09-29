using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    public interface IStudyPlan
    {
        void ComputePlan();
        void GetSubjectsFrom(ISkill skill);
        IYearOfStudy GetYearAt(int i);
        int Years { get; set; }
    }
}
