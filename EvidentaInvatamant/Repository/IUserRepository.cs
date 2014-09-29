using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface IUserRepository
    {
        void Add(IUser user);
        IUser Search(string name, string password);
        void SetView(IUserInterface userinterface);
    }
}
