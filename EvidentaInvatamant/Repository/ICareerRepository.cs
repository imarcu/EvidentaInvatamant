using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
   public interface ICareerRepository
    {
        void Add(ICareer career);
        void Remove(ICareer career);
        ICareer GetAt(int index);
        ICareer SearchByName(string name);
        int GetSize();
    }
}
