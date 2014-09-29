using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class StudyPlanController:IStudyPlanController
    {
        IStudyPlan studyPlan;
        IStudyPlanView studyPlanView;
        ISubjectRepository subjectRepository;


        public StudyPlanController(IStudyPlanView studyPlanView,ISubjectRepository subjectRepository)
        {
            this.studyPlanView = studyPlanView;
            this.subjectRepository = subjectRepository;
        }

        public void SetCareer(ICareer career)
        {
            career.ComputePlan();
            this.studyPlan = career.StudyPlan;
            PopulateStudyPlan();
        }

        private void PopulateStudyPlan()
        {
            this.studyPlanView.ClearStudyPlan();
          for(int i =0;i<studyPlan.Years;i++)
          {
              IYearOfStudy currentYear = studyPlan.GetYearAt(i);

              foreach(ISubject subject in currentYear.AllSubjects)
              {
                  this.studyPlanView.AddRow(subject, i+1);
              }
              this.studyPlanView.AddYearInfo("This year has " + currentYear.Credits + " credits ");
          }
        }



        public ISubjectRepository SubjectRepository
        {
            get
            {
                return this.subjectRepository;
            }
            set
            {
                this.subjectRepository = value;
            }
        }
    }
}
