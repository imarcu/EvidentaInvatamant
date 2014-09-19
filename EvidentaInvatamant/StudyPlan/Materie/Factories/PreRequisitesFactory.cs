using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvidentaInvatamant.Materie.Factories;

namespace EvidentaInvatamant
{
    class PreRequisitesFactory:IPreRequisitesFactory
    {


        public IPreRequisites Make()
        {
            return new PreRequisites();
        }
    }
}
