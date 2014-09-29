using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    interface ISubjectsDetailsView
    {
         void EnableCourse();
         void DisableCourse();
         int GetCourseNumber();
         void EnableSeminary();
         void DisableSeminary();
         int GetSeminaryNumber();
         void EnableLab();
         void DisableLab();
         int GetLabNumber();
         void EnableProject();
         void DisableProject();
         int GetProjectNumber();

         void AddSkillToView(ISkill skill);
         void AddSubjectToView(ISubject subject);

         List<ISkill> GrabSelectedSkills();
         List<ISkill> GrabDeselectedSkills();
         IPreRequisites GrabPreRquisites();
         void ShowErrorMessage(string message);

         void EnableNewSkillInput();

         void ClearSkillList();

         void ClearSubjectList();

         string GrabNewSubjectName();

         string GrabSubjectTopic();

         int GrabLabHrs();

         int GrabSeminaryHrs();

         int GrabCourseHrs();

         int GrabProjectHrs();

         string GrabNewSkillName();

         void ClearNewSkillTextBox();

         void ClearName();

         bool NoHrsSelected();

         void Show(ISubject subject);

         int GrabCreditNr();

         void ClearEverything();

         void CloseWindow();

         void NotifyNewSkills();

         void UpdateViews();

         void EditSubject(ISubject subject);

         void AddName(string p);

         void AddTopic(string p);

         void setCredit(int p);
    }
}
