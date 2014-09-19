using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class User:IUser
    {
        string name;
        string password;
        IProffesion proffesion;

        public User(string name, string password,IProffesion proffesion)
        {
            this.name = name;
            this.password = password;
            this.proffesion = proffesion;
        }

        public bool MatchesCredentials(string name, string password)
        {
            return this.name == name && this.password == password;
        }
        public void DisplayInterface()
        {
            proffesion.DisplayInterface();
        }
    }
}
