using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class SkillTabController:ISkillTabController
    {
         ISkillTabVIew skillTabView;
        ISkillRepository skillRepository;

        public SkillTabController(ISkillTabVIew skillTabView, ISkillRepository skillRepository)
        {
            this.skillRepository = skillRepository;
            this.skillTabView = skillTabView;
            UpdateUI();
        }

        private void UpdateUI()
        {
            PopulateSkillList();
        }

        private void PopulateSkillList()
        {
            for (int i = 0; i < skillRepository.GetSize(); i++)
            {
                this.skillTabView.AddSkill(skillRepository.GetAt(i));
            }
           
        }

        public void SkillSelected(ISkill skill)
        {
            this.skillTabView.UpdateSkillName(skill.Name);
            this.skillTabView.UpdateSkillDescription(skill.Description);
            UpdateSubjects(skill);
        }

        private void UpdateSubjects(ISkill skill)
        {
            this.skillTabView.SubjectsClear();

            ISubjectRepository subjectRepository = skill.Subjects;
            for (int i = 0; i < subjectRepository.GetSize();i++)
            {               
                this.skillTabView.AddSkillSubject(subjectRepository.GetAt(i));
           }
        }


        public void PopulateSkills()
        {
            this.skillTabView.ClearSkills();
            this.PopulateSkillList();
        }
    }
}
