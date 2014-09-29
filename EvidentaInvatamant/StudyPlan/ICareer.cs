using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    public interface ICareer
    {
           void AddSkill(ISkill skill);
           void RemoveSkill(ISkill skill);
           void ComputePlan();
           string Description { get; }
           IStudyPlan StudyPlan { get; }
    }
}
