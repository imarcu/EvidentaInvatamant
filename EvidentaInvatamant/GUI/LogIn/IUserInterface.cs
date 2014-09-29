using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvidentaInvatamant
{
    public interface IUserInterface
    {
        void DisplayStudentInterface();
        void DisplayFacultyMemberInterface();
        void DisplayAdminInterface();
        void InvalidUserInterface();
    }
}
