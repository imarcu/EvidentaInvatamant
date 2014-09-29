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

        public SubjectDetailsController(ISubjectsDetailsView subjectDetailsview, ISubjectRepository repository)
        {
            this.subjectDetailsView = subjectDetailsview;
            this.subjectRepository = repository;
        }


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
    }
}
