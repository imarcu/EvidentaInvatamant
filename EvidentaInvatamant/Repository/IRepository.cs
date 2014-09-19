using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface IRepository<Entity> where Entity: class
    {
        void Add(Entity entity);
        void AddAt(Entity entity,int index);
        void Remove(Entity entity);
        void RemoveAt(int index);
        IRepository<Entity> Search(Func<string,bool> SearchMethod);
        Entity GetAt(int index);
        int GetSize();


    }
}
