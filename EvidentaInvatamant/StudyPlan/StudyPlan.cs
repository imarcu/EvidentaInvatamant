using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class StudyPlan:IStudyPlan
    {
        List<IYearOfStudy> years;
        ISubjectRepository complementarySubjects;
        ISubjectRepository requiredSubjects;

        public StudyPlan(ISubjectRepository complementarySubjects)
        {
            this.complementarySubjects = complementarySubjects;
            requiredSubjects = new SubjectRepository();
            this.years = new List<IYearOfStudy>();
            CreateYear(0);

        }
        public void ComputePlan()
        {

            AddPrimarySubjects();
            complementarySubjects.RemoveRepository(requiredSubjects);
            AddComplementarySubjects();
        }

        private void AddComplementarySubjects()
        {
            foreach(IYearOfStudy year in years)
            {
                if (year.ValidYear())
                {
                    continue;
                }
                else
                {
                    year.AddComplementary(GetAComplementarySubject());
                }
            }
        }

        private ISubject GetAComplementarySubject()
        {
           if(complementarySubjects.IsNotEmpty())
           {
               ISubject chosenOne = complementarySubjects.GetAt(0);
            complementarySubjects.Remove(chosenOne);
            return chosenOne;
           }
           else
           {
               return null;
           }

        }

        private void AddPrimarySubjects()
        {
            this.requiredSubjects.SortBySubjectLine();
             for(int i=0 ;i <requiredSubjects.GetSize();i++)
             {
                 ISubject current = requiredSubjects.GetAt(i);
                 AddInYear(current, i);
             }

        }


        private void AddInYear(ISubject current, int i)
        {
            if (YearIsNotCreated(i))
            {
                CreateYear(i);
            }
            years[i].AddPrimary(current);

        }

        private void CreateYear(int i)
        {
            while(years.Count < i+1)
            {
                years.Add(new YearOfStudy(10, 10));
            }
        }

        private bool YearIsNotCreated(int i)
        {
            return years.Count < i+1;
        }

        public void GetSubjectsFrom(ISkill skill)
        {
            skill.SendSubjectsTo(requiredSubjects);
        }


        public int Years
        {
            get
            {
                return years.Count;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public IYearOfStudy GetYearAt(int i)
        {
            return years[i];
        }
    }
}
