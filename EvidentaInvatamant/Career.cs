using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Career
    {
        string name;
        string description;
        List<ISkill> skills;
        IStudyPlan studyPlan;

        public Career(string name, string description)
        {
            this.name = name;
            this.description = description;
            skills = new List<ISkill>();
            studyPlan = new StudyPlan();
        }
        public void AddSkill(ISkill skill)
        {
            skills.Add(skill);
        }
        public void GatherSubjects()
        {
            foreach (ISkill skill in skills)
            {
                studyPlan.GetSubjectsFrom(skill);
            }
        }
        void ComputePlan()
        {
            studyPlan.ComputePlan();
        }


    }
}
