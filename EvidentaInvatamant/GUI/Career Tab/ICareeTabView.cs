using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    interface ICareeTabView
    {
        void DisplayStudentUI();
        void DisplayFacultyUI();
        void AddCareerToSelection(ICareer career);
        void AddSkillToSelection(ISkill skill);
        void PrintCareerDescription(string description);
        void EnablePlanButton();
        void ShowStudyPlanTab();
        string GetSelectedCareerName();
        void ClearSkills();

        void ClearSkillSelect();

        void AddMode(ICareerMode careerMode);

        IEnumerable<ISkill> SelectedSkills();

        string GrabNewCareerDescription();

        string GrabNewCareerName();

        void ClearNewCareerData();

        ICareer GetSelectedCareer();

        void ShowMessage(string p);
    }
}
