using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    public   interface  ICareerTabController
    {

        void ShowAllSkills();
        void CareerSelected(ICareer career);
        void SetStudyPlanController(IStudyPlanController studyPlanController);
        void StudyPlanButton_Clicked();
        IStudyPlanController StudyPlanController { set; }

        void ModeChanged(ICareerMode current);

        void SetNewCareer();

        void SetChosenCareer();

        void SaveNewCareer();
    }
}
