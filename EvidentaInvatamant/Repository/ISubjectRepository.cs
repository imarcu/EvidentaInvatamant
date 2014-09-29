using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ISubjectRepository
    {
        void Add(ISubject subject);

        void Remove(ISubject subject);

        ISubject SearchByName(string name);

        bool DoesNotContain(ISubject subject);

        ISubject GetAt(int index);

        void CloneRepositoryTo(ISubjectRepository target);

        void RemoveRepository(ISubjectRepository target);

        int GetSize();

        void Clear();

        void AddRange(List<ISubject> list);

        void SortBySubjectLine();

        bool IsNotEmpty();
    }
}
