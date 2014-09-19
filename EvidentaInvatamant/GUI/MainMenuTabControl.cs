using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaInvatamant
{
    public partial class MainMenu : Form
    {
        ILogInPanelController logInPanelController;

        public MainMenu()
        {
            InitializeComponent();

        }


        #region StudentTab



        #endregion

        #region Log In Panel

        public ILogInPanelController LogInPanelController
        {
            set { this.logInPanelController = value; }
        }
        public void SetEnterToLogInButton()
        {
            this.AcceptButton = LogInButton;
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            logInPanelController.LogInButton_Click();

        }
        public void EnterMainMenu()
        {
            LogInPanelDisappear();

            MainMenuAppear();
        }
        public string GrabUserName()
        {
            return UserNameTextBox.Text;
        }
        public string GrabPassword()
        {
            return PasswordTextBox.Text;
        }
        /// <summary>
        /// Sets the shortucut Ctrl + X to the same function as the Log Out menu
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.X))
            {
                logInPanelController.LogOut_Click();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void ExitMainMenu()
        {
            MainMenuDisappear();
            LogInPanelAppear();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInPanelController.LogOut_Click();
        }


        #endregion






        private void AddNewSubjectButton_Click(object sender, EventArgs e)
        {
            SubjectDetails sub = new SubjectDetails();
            sub.Show();

        }

        private void EnterPressedInPassword(object sender, EventArgs e)
        {
            LogInButton_Click(sender, e);
        }


        private void SkillSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
