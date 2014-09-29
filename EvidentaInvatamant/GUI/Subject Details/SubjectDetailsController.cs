using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class SubjectDetailsController:ISubjectDetailsController
    {
        ISubjectsDetailsView subjectDetailsView;
        ISubjectRepository subjectRepository;
        ISkillRepository skillRepository;
        ISubject subject;

        public SubjectDetailsController(ISubjectsDetailsView subjectDetailsview, ISubjectRepository repository,ISkillRepository skillRespository)
        {
            this.subjectDetailsView = subjectDetailsview;
            this.subjectRepository = repository;
            this.skillRepository = skillRespository;
            
        }

        private void InitialValues()
        {
            PopulateSkillList();
            PopulateSubjectsList();
        }
        private void PopulateSkillList()
        {
            this.subjectDetailsView.ClearSkillList();
            for (int i = 0; i < skillRepository.GetSize(); i++)
            {
                subjectDetailsView.AddSkillToView(skillRepository.GetAt(i));
            }
        }
        private void PopulateSubjectsList()
        {
            this.subjectDetailsView.ClearSubjectList();
            for (int i = 0; i < subjectRepository.GetSize(); i++)
            {
               subjectDetailsView.AddSubjectToView(subjectRepository.GetAt(i));
            }
        }
        #region hours

        public void CourseCheckBox_CheckedChanged(bool state)
        {
            if (state)
            {
                subjectDetailsView.EnableCourse();
            }
            else
            {
                subjectDetailsView.DisableCourse();
            }
        }

        public void seminaryCheckBox_CheckedChanged(bool state)
        {
            if (state)
            {
                subjectDetailsView.EnableSeminary();
            }
            else
            {
                subjectDetailsView.DisableSeminary();
            }
        }

        public void LaboratoryCheckBox_CheckedChanged(bool state)
        {
            if (state)
            {
                subjectDetailsView.EnableLab();
            }
            else
            {
                subjectDetailsView.DisableLab();
            }
        }

        public void ProjectCheckBox_CheckedChanged(bool state)
        {
            if (state)
            {
                subjectDetailsView.EnableProject();
            }
            else
            {
                subjectDetailsView.DisableProject();
            }
        }

        #endregion

        public void AddNewSkill_Click()
        {
            this.subjectDetailsView.EnableNewSkillInput();
        }


        public void OkButton_Click()
        {
            if (ValidData())
            {
                UpdateSubject();
                this.subjectDetailsView.ClearEverything();
                this.subject = null;
                this.subjectDetailsView.CloseWindow();
            }
            

        }

        private bool ValidData()
        {
            return NameIsValid() && ValidHrs();
        }

        private void UpdateSubject()
        {
            UpdateName();
            UpdateHours();
            UpdateSkills();
            UpdateTopic();
            UpdatePreRequisites();
            UpdateCredit();
            UpdateViews();
        }

        private void UpdateViews()
        {
            this.subjectDetailsView.UpdateViews();
        }

        private void UpdateCredit()
        {
            subject.Credits = subjectDetailsView.GrabCreditNr();
        }
        private void UpdateTopic()
        {
            subject.Topic = subjectDetailsView.GrabSubjectTopic();
            
        }
        private void UpdateName()
        {                         
                string newName = subjectDetailsView.GrabNewSubjectName();
                subject.Name = newName;         
        }

        private bool NameIsValid()
        {
            string newName = subjectDetailsView.GrabNewSubjectName();
            if( subjectRepository.SearchByName(newName) == null)
            {
               return true;
            }
                this.subjectDetailsView.ShowErrorMessage("Name is already in use or invalid ! Please choose a different one");
                subjectDetailsView.ClearName();
                return false;
        }
        private bool ValidHrs()
        {
            if (subjectDetailsView.NoHrsSelected())
            {
                subjectDetailsView.ShowErrorMessage("No hours selected!");
                return false;
            }
            return true;
        }

        private void UpdateHours()
        {
           
            subject.LaboratoryHrs = subjectDetailsView.GrabLabHrs();
            subject.SeminaryHrs = subjectDetailsView.GrabSeminaryHrs();
            subject.CourseHrs = subjectDetailsView.GrabCourseHrs();
            subject.ProjectHrs = subjectDetailsView.GrabProjectHrs();
            
          
            
        }

        private void UpdatePreRequisites()
        {
            this.subject.PreRequisites = this.subjectDetailsView.GrabPreRquisites();
        }

        private void UpdateSkills()
        {
            AddSubjectToSelectedSKills();
            //RemoveSubjectFromUncheckedSKills();
            this.subjectDetailsView.NotifyNewSkills();
            
        }
        private void AddSubjectToSelectedSKills()
        {
            foreach (ISkill skill in subjectDetailsView.GrabSelectedSkills())
            {
                skill.AddSubject(this.subject);
            }
        }
        private void RemoveSubjectFromUncheckedSKills()
        {
            foreach(ISkill skill in subjectDetailsView.GrabDeselectedSkills())
            {
                skill.RemoveSubject(this.subject);
            }
        }



        public void NewSkillOKButton_Click()
        {
            ISkill newSkill = new Skill(this.subjectDetailsView.GrabNewSkillName(),"No description available");
            if(skillRepository.Add(newSkill))
            {
                PopulateSkillList();
            }
            else
            {
                this.subjectDetailsView.ShowErrorMessage("Skill name already exists! Please pick a different name.");
            }
            this.subjectDetailsView.ClearNewSkillTextBox();
           
        }


        public ISubject Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
                InitialValues();
            }
        }


        public ISkill GetSkillAt(int i)
        {
            return skillRepository.GetAt(i);
         }


        public void ShowSubjectData()
        {
           
            subjectDetailsView.AddName(subject.Name);
            subjectDetailsView.AddTopic(subject.Topic);
            subjectDetailsView.setCredit(subject.Credits);
          //  subjectDetailsView.
        }
    }
}
