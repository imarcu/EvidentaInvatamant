using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaInvatamant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //testing 
            MainMenu mainMenu = new MainMenu();
            IUserRepository users = new UserRepository(new User("","",new InvalidProffession((IMainMenuView)mainMenu )));
            users.Add(new User("admin", "admin", new ProffesionAdmin((IMainMenuView)mainMenu)));
            users.Add(new User("student", "student",new ProffesionStudent((IMainMenuView)mainMenu)));
            users.Add(new User("faculty","faculty",new ProffesionFacultyMember((IMainMenuView)mainMenu)));
            ILogInPanelController logInPanelController = new LogInPanelController(mainMenu, users);
            mainMenu.LogInPanelController = logInPanelController;
            
           
            Application.Run(mainMenu);
        }
    }
}
