using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class ProffesionFacultyMember:IProffesion
    {
        IMainMenuView mainMenuView;

        public ProffesionFacultyMember(IMainMenuView view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayFacultyMemberInterface();
        }
        public override string ToString()
        {
            return "Faculty Member";
        }
    }
}
