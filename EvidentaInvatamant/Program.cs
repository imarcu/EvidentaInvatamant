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

            MainMenu mainMenu = new MainMenu();
            SubjectDetails subjectDetails = new SubjectDetails();

            ApplicationData context = new ApplicationData();
            
            context = context.LoadData();
            context.UserInterface = mainMenu;
            context.EnableUsers();

            //context.SubjectRepository = new SubjectRepository();
           //context.SkillRepository = new SkillRepository();
            //context.CareerRepository = new CareerRepository();
           // context.UserRepository.Add(new User("invalid","invalid",new InvalidProffession(mainMenu)));
            ILogInPanelController logInPanelController = new LogInPanelController(mainMenu, context.UserRepository);
            ICareerTabController careerControl = new CareerTabController(context.CareerRepository, mainMenu, context.SkillRepository);
            ISubjectDetailsController subjectDetailsControl  = new SubjectDetailsController(subjectDetails,context.SubjectRepository,context.SkillRepository);
            ISubjectTabController subjectTabController = new SubjectTabController(mainMenu, context.SubjectRepository, subjectDetails);
            ISkillTabController skillTabController = new SkillTabController(mainMenu, context.SkillRepository);
            IStudyPlanController studyPlanController = new StudyPlanController(mainMenu,context.SubjectRepository);

            careerControl.StudyPlanController = studyPlanController;
            mainMenu.CareerTabController = careerControl;
            mainMenu.LogInPanelController = logInPanelController;
            subjectDetails.SubjectDetailsController = subjectDetailsControl;
            mainMenu.SubjectTabController = subjectTabController;
            mainMenu.SkillTabController = skillTabController;
            mainMenu.StudyPlanController = studyPlanController;
            // change

            subjectDetails.MainMenu = mainMenu;
            Application.Run(mainMenu);
            context.SaveData();
        }
    }
}
