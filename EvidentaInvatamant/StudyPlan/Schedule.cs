using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class Schedule:ISchedule
    {
        List<IYearOfStudy> years;
        ISubjectRepository complementarySubjects;
        int currentYear;
        public Schedule(ISubjectRepository subjectRepository)
        {
            years = new List<IYearOfStudy>();
            complementarySubjects = new SubjectRepository();
            subjectRepository.CloneRepositoryTo(complementarySubjects);            
        }

        public void NextYear()
        {
            currentYear++;
        }
        public void AddAatYear(ISubject subject, int year)
        {
            if (years[year] == null)
                years[year] = new YearOfStudy();
            years[year].Add(subject);
        }

        public void AddInYear(ISubject materie)
        {
            years[currentYear].Add(materie);
        }



        public int GetYearNumber()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<IYearOfStudy> Years
        {
            get
            {
                return years;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public int NrOfYears
        {
            get { return years.Count; }
        }

        public IYearOfStudy GetYearindex(int index)
        {
            return years[index];
        }
    }
}
