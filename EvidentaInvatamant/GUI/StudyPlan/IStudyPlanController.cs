using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface IStudyPlanController
    {
        void SetCareer(ICareer career);



        ISubjectRepository SubjectRepository { get; set; }
    }
}
