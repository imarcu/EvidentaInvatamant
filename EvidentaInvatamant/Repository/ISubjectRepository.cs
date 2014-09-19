using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISubjectRepository
    {
        void Add(ISubject subject);
        void Remove(ISubject subject);
        ISubjectRepository SearchByName(string name);
        ISubject GetAt(int index);

    }
}
