using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Skill:ISkill
    {
        string name;
        string description;
        List<ISubject> subjects;

        public Skill(string name, string description)
        {
            this.name = name;
            this.description = description;
            subjects = new List<ISubject>();
        }
        public void AddSubject(ISubject subject)
        {
            subjects.Add(subject);
        }
        public void RemoveSubject(ISubject subject)
        {
            subjects.Remove(subject);
        }

        public void PutSubjectsIn(List<ISubject> list)
        {
            list.AddRange(subjects);
        }
        public override string ToString()
        {
            return name + "(" + description + ")";
        }

        public bool MatchesName(string name)
        {
            return this.name.Contains(name);
        }
    }
}
