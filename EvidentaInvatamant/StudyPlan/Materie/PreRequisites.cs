using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant

{
    class PreRequisites:IPreRequisites
    {
        List<ISubject> preRequisites;

        

        private bool ListIsEmpty()
        {
            return (preRequisites.Count == 0);
                
        }


        public int GetlargestSubjectLine()
        {
            if (ListIsEmpty())
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        private int MaxSubjectLine()
        {
            int localMax = 0;

            foreach (ISubject subject in preRequisites)
            {
                localMax = Math.Max(localMax, subject.GetLargestSubjectLine());
            }
            return localMax;
        }

        public void Add(ISubject subject)
        {
            preRequisites.Add(subject);
        }


        public void Remove(ISubject subject)
        {
            preRequisites.Remove(subject);
        }

        public void RemoveAt(int index)
        {
            preRequisites.RemoveAt(index);
        }

        public ISubject GetAt(int index)
        {
            return preRequisites[index];
        }
    }
}
