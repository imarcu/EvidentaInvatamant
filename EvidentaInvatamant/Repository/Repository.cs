using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class Repository<Entity>:IRepository<Entity> where Entity: class
    {
        List<Entity> repository;

        public Repository()
        {
            repository = new List<Entity>();
        }    
        public void Add(Entity entity)
        {
 	        repository.Add(entity);
        }

        public void AddAt(Entity entity,int index)
        {
 	        repository[index] = entity;
        }

        public void Remove(Entity entity)
        {
 	       repository.Remove(entity);
        }

        public void RemoveAt(int index)
        {
 	        repository.RemoveAt(index);
        }

        public IRepository<Entity> Search(Func<string,bool> SearchMethod)
        {
 	        IRepository<Entity> tempRepository = new Repository<Entity>();

            foreach(Entity entity in repository)
            {
                //what to do here ?
            }

            return tempRepository;
        }
        public Entity GetAt(int index)
        {
            return repository[index];
        }

        public int GetSize()
        {
            return repository.Count;
        }
    }   
}
