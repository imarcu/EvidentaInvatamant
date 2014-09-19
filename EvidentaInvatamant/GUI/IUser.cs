using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
     public  interface IUser
    {
        bool MatchesCredentials(string name, string password);
        void DisplayInterface();
    }
}
