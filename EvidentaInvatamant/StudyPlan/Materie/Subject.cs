using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Subject:ISubject
    {
        IPreRequisites preRequisites;
        
        string name;
        string topic;
        ICredit credit;

        
        public Subject(IPreRequisites preRequisites, string name, string Topic, ICredit credit)
        {
            this.preRequisites = preRequisites;
            this.name = name;
            this.topic = Topic;
            this.credit = credit;
        }

       
        public override string ToString()
        {
            return name + topic + credit;
        }

        public int GetLargestSubjectLine()
        {
            return preRequisites.GetlargestSubjectLine();
        }


        public bool MatchesName(string name)
        {
            return this.name.Contains(name);
        }
    }
}
