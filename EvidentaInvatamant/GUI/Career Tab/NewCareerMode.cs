using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class NewCareerMode:ICareerMode
    {
        ICareerModeVIew view;
        ICareerTabController controller;
        public NewCareerMode(ICareeTabView careerTabView,ICareerTabController controller)
        {
             this.view = (ICareerModeVIew) careerTabView;
             this.controller = controller;
        }

        public void Enable()
        {
            view.EnableNewCareerMode();
        }

        public void SetCurrentCareer()
        {
            controller.SetNewCareer();
        }
        public override string ToString()
        {
            return "Make your own career";
        }
    }
}
