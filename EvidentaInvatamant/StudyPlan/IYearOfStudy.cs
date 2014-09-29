using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface IYearOfStudy
    {
        void AddPrimary(ISubject materie);
        bool ValidYear();
        List<ISubject> AllSubjects { get; }

        void AddComplementary(ISubject subject);
        int NrOfSubjects { get; set; }
        int Size { get; set; }

        string Credits { get; set; }
    }
}
