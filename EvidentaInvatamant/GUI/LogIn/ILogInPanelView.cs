using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    public interface ILogInPanelView
    {

         string GrabUserName();
         string GrabPassword();
         void EnterMainMenu();
         void ExitMainMenu();
         void SetEnterToLogInButton();
    }
}
