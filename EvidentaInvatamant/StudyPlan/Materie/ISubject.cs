using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISubject:IComparable<ISubject>
    {
        int GetLargestSubjectLine();
        bool MatchesName(string name);
        int GetHrs();
        string Name { get; set; }
        string Topic { get; set; }
        int Credits { get; set; }
        int LaboratoryHrs { get; set; }
        int SeminaryHrs { get; set; }
        int CourseHrs { get; set; }
        int ProjectHrs { get; set; }
        IPreRequisites PreRequisites { get; set; }


        int AddCreditsTo(int temp);

        int AddHrsTo(int temp);
    }
}
