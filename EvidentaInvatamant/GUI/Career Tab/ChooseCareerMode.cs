using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class ChooseCareerMode:ICareerMode
    {
        ICareerModeVIew view;
        ICareerTabController controller;

        public ChooseCareerMode(ICareeTabView view,ICareerTabController controller)
        {
            this.view = (ICareerModeVIew) view;
            this.controller =  controller;
        }
        
        public void Enable()
        {
            view.EnableChooseCareerMode();
        }

        public void SetCurrentCareer()
        {
            controller.SetChosenCareer();
        }
        public override string ToString()
        {
            return "Choose a career";
        }
    }
}
