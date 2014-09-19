using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class YearOfStudy:IYearOfStudy
    {
        List<ISubject> year;
        ICredit credit;



        public void Add(ISubject materie)
        {
            year.Add(materie);
        }
    }
}
