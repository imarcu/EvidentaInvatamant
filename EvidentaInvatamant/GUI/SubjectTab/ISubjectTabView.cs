using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISubjectTabView
    {
       void AddSubjectToTable(ISubject subject);

       void ClearDataGrid();

       void RefreshDataGrid();
       ISubject GetSelectedSubject();
    }
}
