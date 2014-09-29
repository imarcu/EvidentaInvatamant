using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class Skill:ISkill
    {
        string name;
        string description;
        ISubjectRepository subjectRepository;

        public Skill(string name, string description)
        {
            this.name = name;
            this.description = description;
            subjectRepository = new SubjectRepository();
        }
        public void AddSubject(ISubject subject)
        {
            subjectRepository.Add(subject);

        }
        public void RemoveSubject(ISubject subject)
        {
            subjectRepository.Remove(subject);
        }

        public void SendSubjectsTo(ISubjectRepository subjectRepository)
        {
            for (int i = 1; i < this.subjectRepository.GetSize(); i++)
            {
                subjectRepository.Add(this.subjectRepository.GetAt(i));
            }
        }
        public override string ToString()
        {
            return name + "(" + description + ")";
        }

        public bool MatchesName(string name)
        {
            return this.name.Equals(name);
        }

        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }


        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }


        public ISubjectRepository Subjects
        {
            get { return this.subjectRepository; }
        }
    #endregion
    }
}
