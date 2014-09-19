using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaInvatamant
{
    class LogInPanelController:ILogInPanelController
    {
        IMainMenuView mainMenuView;
        IUserRepository userRepository;

        public LogInPanelController(IMainMenuView mainMenuView, IUserRepository userRepository)
        {
            this.mainMenuView = mainMenuView;
            this.userRepository = userRepository;
            mainMenuView.SetEnterToLogInButton();
        }

        public void LogInButton_Click()
        {
            string name = mainMenuView.GrabUserName();
            string password = mainMenuView.GrabPassword();
            IUser user = SearchUserDetails(name, password);
            user.DisplayInterface();
        }
        private IUser SearchUserDetails(string name, string password)
        {
            return userRepository.Search(name, password);
        }
        public void LogOut_Click()
        {
            mainMenuView.ExitMainMenu();
        }
    }
}
