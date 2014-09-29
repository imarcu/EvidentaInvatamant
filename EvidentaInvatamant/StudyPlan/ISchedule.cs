using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISchedule
    {
        void AddInYear(ISubject materie);
        void NextYear();
        int GetYearNumber();
        void AddAatYear(ISubject subject, int year);

        IEnumerable<IYearOfStudy> Years { get; set; }
        int NrOfYears { get; }
        IYearOfStudy GetYearindex(int index);
    }
}
