using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISkill
    {
        void SendSubjectsTo(ISubjectRepository subjectRepository);
        void AddSubject(ISubject subject);
        void RemoveSubject(ISubject subject);
        bool MatchesName(string name);
        //Gui
        string Name { get; set; }
        ISubjectRepository Subjects { get;}
        string Description { get;}
    }
}
