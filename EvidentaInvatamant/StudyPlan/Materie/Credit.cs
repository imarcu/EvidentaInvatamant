using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Credit:ICredit
    {
        int number;



        public int compareTo(ICredit credit)
        {
            throw new NotImplementedException();
        }


        public bool IsSmallerThan(ICredit credit)
        {
            return credit.isLargerThan(number);
        }


        public bool isLargerThan(int number)
        {
            return this.number > number;
        }
    }
}
