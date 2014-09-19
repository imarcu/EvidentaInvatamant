using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ICredit
    {
        int compareTo(ICredit credit);
        bool IsSmallerThan(ICredit credit);
        bool isLargerThan(int number);
    }
}
