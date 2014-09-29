using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISubjectDetailsController
    {
        void CourseCheckBox_CheckedChanged(bool state);
        void seminaryCheckBox_CheckedChanged(bool state);
        void LaboratoryCheckBox_CheckedChanged(bool state);
        void ProjectCheckBox_CheckedChanged(bool state);
        void AddNewSkill_Click();
        void OkButton_Click();
        void NewSkillOKButton_Click();

        ISubject Subject { get; set; }

        ISkill GetSkillAt(int i);

        void ShowSubjectData();
    }
}
