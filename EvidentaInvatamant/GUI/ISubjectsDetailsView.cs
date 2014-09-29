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

    }
}
