using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
   public interface ISubjectTabController
    {
        void AddNewSubject_Click();



        void RebuildDataGrid();

        void RemoveSubjectButton_Click();

        void EditButton_Click();
    }
}
