using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface IMainMenuView
    {
         void DisplayStudentInterface();
         void DisplayFacultyMemberInterface();
         void DisplayAdminInterface();
         void DisplayErrorMessage();
         string GrabUserName();
         string GrabPassword();
         void EnterMainMenu();
         void ExitMainMenu();
         void SetEnterToLogInButton();
    }
}
