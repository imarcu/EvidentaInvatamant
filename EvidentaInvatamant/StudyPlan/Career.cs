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
            ISubjectRepository clone = new SubjectRepository();
            subjectRepository.CloneRepositoryTo(clone);
            studyPlan = new StudyPlan(clone);
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



        public string Description
        {
            get { return this.description; }
        }

        public IStudyPlan StudyPlan
        {
            get { return this.studyPlan; }
        }
    }
}
