using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class InvalidProffession:IProffesion
    {
        IMainMenuView mainMenuView;

        public InvalidProffession(IMainMenuView mainMenuView)
        {
            this.mainMenuView = mainMenuView;
        }


        public void DisplayInterface()
        {
            mainMenuView.DisplayErrorMessage();
        }
    }
}
