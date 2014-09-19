using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class SubjectRepository:ISubjectRepository
    {
        List<ISubject> subjects;

        public SubjectRepository()
        {
            subjects = new List<ISubject>();

        }

        public void Add(ISubject subject)
        {
            subjects.Add(subject);
        }

        public void Remove(ISubject subject)
        {
            subjects.Remove(subject);
        }

        public ISubjectRepository SearchByName(string name)
        {
            ISubjectRepository tempRepository = new SubjectRepository();

            foreach (ISubject subject in subjects)
            {
                if (subject.MatchesName(name))
                {
                    tempRepository.Add(subject);
                }
            }

            return tempRepository;
        }

        public ISubject GetAt(int index)
        {
            return subjects[index];
        }
    }
}
