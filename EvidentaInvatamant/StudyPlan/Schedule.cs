using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Schedule:ISchedule
    {
        List<IYearOfStudy> years;
        int currentYear;


        public void NextYear()
        {
            currentYear++;
        }

        public void AddInYear(ISubject materie)
        {
            years[currentYear].Add(materie);
        }
    }
}
