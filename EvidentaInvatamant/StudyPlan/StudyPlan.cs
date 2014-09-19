using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class StudyPlan:IStudyPlan
    {
        ISchedule schedule;
        List<ISubject> materii;

        public void Print()
        {
            throw new NotImplementedException();
        }
        

        public void ComputePlan()
        {
            int tempMaxLine = 0;
            foreach (ISubject materie in materii)
            {
                tempMaxLine = System.Math.Max(tempMaxLine, materie.GetLargestSubjectLine());
            }

        }
        public void GetSubjectsFrom(ISkill skill)
        {
            skill.PutSubjectsIn(materii);
        }
    }
}
