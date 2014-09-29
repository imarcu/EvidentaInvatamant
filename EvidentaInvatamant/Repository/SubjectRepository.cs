using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    public class SubjectRepository:ISubjectRepository
    {
        List<ISubject> subjects;

        public SubjectRepository()
        {
            subjects = new List<ISubject>();

        }

        public void Add(ISubject subject)
        {
           if(this.DoesNotContain(subject) || subject == null)
           {
               this.subjects.Add(subject);
           }    
        }

        public void Remove(ISubject subject)
        {
            subjects.Remove(subject);
            //subject = null;
        }

        public ISubject SearchByName(string name)
        {     
            foreach (ISubject subject in subjects)
            {
                if (subject.MatchesName(name))
                {
                    return subject;
                }
            }

            return null;
        }

        public ISubject GetAt(int index)
        {            
                return subjects[index];         
         }

        public int GetSize()
        {
            return subjects.Count;
        }

        public void CloneRepositoryTo(ISubjectRepository target)
        {
            target.Clear();
            target.AddRange(this.subjects);
        }

        public void Clear()
        {
            subjects.Clear();
        }

        public void AddRange(List<ISubject> list)
        {
            foreach (ISubject subject in list)
            {
                this.Add(subject);
            }
        }

        public void RemoveRepository(ISubjectRepository target)
        {
            for(int i=0;   i<target.GetSize(); i++)
            {
                this.subjects.Remove(target.GetAt(i));
            }
        }

        public void SortBySubjectLine()
        {
            subjects.Sort();
        }


        public bool DoesNotContain(ISubject subject)
        {
            return this.SearchByName(subject.Name) == null;
        }


        public bool IsNotEmpty()
        {
            return this.subjects.Count != 0;
        }
    }
}
