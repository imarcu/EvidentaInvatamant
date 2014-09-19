using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class ProffesionStudent:IProffesion
    {
        IMainMenuView mainMenuView;

        public ProffesionStudent (IMainMenuView view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayStudentInterface();
        }
        public override string ToString()
        {
            return "Student";
        }
    }
}
