using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class Subject:ISubject,IComparable<ISubject>

    {
        IPreRequisites preRequisites ;
        
        string name; 
        string topic;
        int credits = 0;
        int labHrs;
        int seminaryHrs;
        int courseHrs;
        int projectHrs;    
               
        public Subject()
        {
            name = "noName";
            topic = "noTopic";
            credits = 0;
            labHrs = 0;
            seminaryHrs = 0;
            courseHrs = 0;
            projectHrs = 0;
        }
        public override string ToString()
        {
            return name;
        }

        public int GetLargestSubjectLine()
        {
           return  preRequisites.GetlargestSubjectLine();
        }


        public bool MatchesName(string name)
        {
            return this.name.Contains(name);
        }
        public int GetHrs()
        {
            return labHrs + seminaryHrs + courseHrs + projectHrs;
        }

        #region properties
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


        public string Topic
        {
            get
            {
                return this.topic;
            }
            set
            {
                this.topic = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }
            set
            {
                this.credits = value;
            }
        }

        public int LaboratoryHrs
        {
            get
            {
                return labHrs;
            }
            set
            {
                this.labHrs = value;
            }
        }

        public int SeminaryHrs
        {
            get
            {
                return seminaryHrs;
            }
            set
            {
                this.seminaryHrs = value;
            }
        }

        public int CourseHrs
        {
            get
            {
                return courseHrs;
            }
            set
            {
                this.courseHrs = value;
            }
        }

        public int ProjectHrs
        {
            get
            {
                return projectHrs;
            }
            set
            {
                this.projectHrs = value;
            }
        }

        public IPreRequisites PreRequisites
        {
            get
            {
                return this.preRequisites;
            }
            set
            {
                this.preRequisites = value;
            }
        }
        #endregion
        
        public int CompareTo(ISubject other)
        {
            return this.GetLargestSubjectLine() - other.GetLargestSubjectLine();
        }

        ~Subject ()
        {

        }




        public int AddCreditsTo(int temp)
        {
            return this.credits + temp;
        }


        public int AddHrsTo(int temp)
        {
            return this.GetHrs() + temp;
        }
    }
}
