using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    class YearOfStudy:IYearOfStudy
    {
        List<ISubject> primary;
        List<ISubject> complementary;
        int credit;
        int minimumHrs; 

        public YearOfStudy(int minimCredit,int minimHrs)
        {
            this.credit = minimCredit;
            this.minimumHrs = minimHrs;
            primary = new List<ISubject>();
            complementary = new List<ISubject>();
        }


        public void AddPrimary(ISubject materie)
        {
            primary.Add(materie);
        }
        private bool HrsRespected()
        {
            int tempSum = 0;
            
            tempSum += Hours(primary);
            tempSum += Hours(complementary);

            return tempSum > minimumHrs;
        }

        private int Hours(List<ISubject> list)
        {
            int temp = 0;
            foreach(ISubject subject in list)
            {
                if (subject != null)
                {
                    temp += subject.AddHrsTo(temp);
                }
            }
            return temp;
        }       

        private bool CreditsRespected()
        {
            int tempCredit = 0;
            tempCredit += Credits(primary);
            tempCredit += Credits(complementary);

            return tempCredit>credit;
        }


        private int Credits(List<ISubject> list)
        {
            int temp = 0;

            foreach (ISubject subject in list)
            {
                if (subject != null)
                {
                    temp += subject.AddCreditsTo(temp);
                }
            }

            return temp;
        }

        public bool ValidYear()
        {
            return HrsRespected() && CreditsRespected();
        }




        public ISubject GetSubjectAt(int index)
        {
            return primary[index];
        }


        public List<ISubject> AllSubjects
        {
            get 
            {
                List<ISubject> everything = new List<ISubject>();

                everything.AddRange(primary);
                everything.AddRange(complementary);

                return everything;
            }
        }


        public void AddComplementary(ISubject subject)
        {
            complementary.Add(subject);
        }


        public int Size
        {
            get
            {
                return 0;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public int NrOfSubjects
        {
            get
            {
                return primary.Count;
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        string IYearOfStudy.Credits
        {
            get
            {
                return Convert.ToString((Credits(primary) + Credits(complementary)));
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
