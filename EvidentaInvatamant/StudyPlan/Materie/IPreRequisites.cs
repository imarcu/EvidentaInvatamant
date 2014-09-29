using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant

{
    public interface IPreRequisites
    {
        int GetlargestSubjectLine();
        void Add(ISubject subject);
        void Remove(ISubject subject);
        void RemoveAt(int index);
        ISubject GetAt(int index);
    }
}
