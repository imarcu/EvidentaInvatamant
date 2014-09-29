using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class CareerTabController:ICareerTabController
    {
        ICareerRepository careerRepository;
        ISkillRepository skillRepository;
        ICareeTabView careerTabView;
        IStudyPlanController studyPlanController;
        ICareerMode currentMode;
        ICareerMode chooseCareerMode;
        ICareerMode newCareerMode;

        public CareerTabController(ICareerRepository careerRepository, ICareeTabView careerTabView,ISkillRepository skillRepository)
        {
            this.careerRepository = careerRepository;
            this.careerTabView = careerTabView;
            this.skillRepository = skillRepository;
            newCareerMode = new NewCareerMode(careerTabView,this);
            chooseCareerMode = new ChooseCareerMode(careerTabView, this);            
            InitialInterface();
        }
        private void InitialInterface()
        {
            ShowAllCareers();
            ShowAllSkills();
            AddCareerModes();
            EnableCurrentMode();
        }

        private void AddCareerModes()
        {
            this.currentMode = newCareerMode;
            this.careerTabView.AddMode(this.newCareerMode);
            this.careerTabView.AddMode(this.chooseCareerMode);
        }
        private void ShowAllCareers()
        {
           for(int i=0;i<careerRepository.GetSize();i++)
           {
               ICareer current= careerRepository.GetAt(i);
               careerTabView.AddCareerToSelection(current);
           }
        }

        public void ShowAllSkills()
        {
            this.careerTabView.ClearSkillSelect();
            PopulateSkillList();

          
        }
        private void PopulateSkillList()
        {
            for (int i = 0; i < skillRepository.GetSize(); i++)
            {
                ISkill current = skillRepository.GetAt(i);
                careerTabView.AddSkillToSelection(current);
            }
        }

        public void CareerSelected(ICareer career)
        {
            careerTabView.PrintCareerDescription(career.Description);                
        }


        public void SetStudyPlanController(IStudyPlanController studyPlanController)
        {
            this.studyPlanController = studyPlanController;
        }


        public void StudyPlanButton_Clicked()
        {
            careerTabView.ShowStudyPlanTab();
            currentMode.SetCurrentCareer();
        }


        public IStudyPlanController StudyPlanController
        {
            set { this.studyPlanController = value; }
        }


        public void ModeChanged(ICareerMode current)
        {
            currentMode = current;
            EnableCurrentMode();
        }

        private void EnableCurrentMode()
        {
            currentMode.Enable();
        }


        public void SetNewCareer()
        {
            ICareer newCareer = new Career("chosen by student", "no description",this.studyPlanController.SubjectRepository);
            
            foreach(ISkill skill in this.careerTabView.SelectedSkills())
            {
                newCareer.AddSkill(skill);
            }
            this.studyPlanController.SetCareer(newCareer);
        }

        public void SetChosenCareer()
        {
            ICareer chosenCareer = this.careerTabView.GetSelectedCareer();
            this.studyPlanController.SetCareer(chosenCareer);
        }


        public void SaveNewCareer()
        {
            string name = this.careerTabView.GrabNewCareerName();
            string description = this.careerTabView.GrabNewCareerDescription();
           ICareer savingCareer = new Career(name,description,this.studyPlanController.SubjectRepository);
           foreach (ISkill skill in this.careerTabView.SelectedSkills())
           {
               savingCareer.AddSkill(skill);
           }
           this.careerRepository.Add(savingCareer);
           this.careerTabView.ClearSkillSelect();
           PopulateSkillList();
           ShowAllCareers();
           this.careerTabView.ClearNewCareerData();
           this.careerTabView.ShowMessage("Career added to vault");

        }
    }
}
