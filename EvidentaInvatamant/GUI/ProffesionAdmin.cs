using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class ProffesionAdmin:IProffesion
    {
        IMainMenuView mainMenuView;

        public ProffesionAdmin(IMainMenuView view)
        {
            mainMenuView = view;
        }
        public void DisplayInterface()
        {
            mainMenuView.DisplayAdminInterface();
        }
        public override string ToString()
        {
            return "Admin/Tester";
        }
    }
}
