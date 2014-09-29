using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class Career:ICareer
    {
        string name;
        string description;
        List<ISkill> skills;
        IStudyPlan studyPlan;

        public Career(string name, string description,ISubjectRepository subjectRepository)
        {
            this.name = name;
            this.description = description;
            skills = new List<ISkill>();
            studyPlan = new StudyPlan(subjectRepository);
        }
        public void AddSkill(ISkill skill)
        {
            skills.Add(skill);
        }
        public void RemoveSkill(ISkill skill)
        {
            skills.Remove(skill);
        }
        public void GatherSubjects()
        {
            foreach (ISkill skill in skills)
            {
                studyPlan.GetSubjectsFrom(skill);
            }
        }
        public void ComputePlan()
        {
            GatherSubjects();
            studyPlan.ComputePlan();
        }
        public override string ToString()
        {
            return name;
        }
        public string GetDescription()
        {
            return description;
        }


        public ISchedule GetSchedule()
        {
            ComputePlan();
            return studyPlan.GetSchedule();
        }
    }
}
