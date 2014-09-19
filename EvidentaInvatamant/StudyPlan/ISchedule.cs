using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISchedule
    {
        void AddInYear(ISubject materie);
        void NextYear();
    }
}
