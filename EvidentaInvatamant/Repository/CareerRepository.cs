using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    [Serializable]
    public class CareerRepository:ICareerRepository
    {
        List<ICareer> careers;

        public CareerRepository()
        {
            careers = new List<ICareer>();
        }

        public void Add(ICareer career)
        {
            if(this.DoesNotContain(career))
            {
                careers.Add(career);
            }
        }

        public void Remove(ICareer career)
        {
            careers.Remove(career);
        }

        public ICareer SearchByName(string name)
        {
            foreach (ICareer career in careers)
            {
                if (career.ToString() == name)
                    return career;
            }
            return null;
        }
        public int Size
        {
            get{return careers.Count;}
        }
        private bool DoesNotContain(ICareer career)
        {
            return !this.careers.Contains(career);
        }

        public int GetSize()
        {
            return careers.Count;
        }


        public ICareer GetAt(int index)
        {
            return careers[index];
        }
    }
}
