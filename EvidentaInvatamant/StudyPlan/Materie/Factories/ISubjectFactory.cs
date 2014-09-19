using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISubjectFactory
    {
        ISubject Make(string name, string topic, ICredit credit, IPreRequisites prerequisites);
    }
}
