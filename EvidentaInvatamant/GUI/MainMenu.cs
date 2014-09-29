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
 
    public partial class MainMenu : Form,IStudyPlanView,ISkillTabVIew, IUserInterface, ILogInPanelView, ICareeTabView,ISubjectTabView,ICareerModeVIew

    {
        ILogInPanelController logInPanelController;
        ICareerTabController careerTabController;
        ISubjectTabController subjectTabController;
        ISkillTabController skillTabController;
        IStudyPlanController studyPlanController;

        public IStudyPlanController StudyPlanController
        {
            set { this.studyPlanController = value; }
        }
        ApplicationData applicationData;

        public MainMenu()
        {
            InitializeComponent();
            InitialCareerTab();

        }
        public ApplicationData ApplicationData
        {
            set { this.applicationData = value; }
        }


        #region Stuff



        #endregion

        #region CareerTab

        public ICareerTabController CareerTabController
        {
            set { this.careerTabController = value; }
        }
        private void InitialCareerTab()
        {
            CareerSelectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            careerModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void DisplayStudentUI()
        {
            careerModeInfoLabel.Visible = true;
            careerModeComboBox.Visible = true;
            FindStudyPlanButton.Visible = true;
            CareerSelectGroupBox.Visible = true;
            SkillSelectGroupBox.Visible = true;
        }
        public void AddSkillToSelection(ISkill skill)
        {
            SkillSelectList.Items.Add(skill);
        }
        public void AddCareerToSelection(ICareer career)
        {
            CareerSelectComboBox.Items.Add(career);
        }

        private void CareerSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            careerTabController.CareerSelected((ICareer)CareerSelectComboBox.SelectedItem);
        }

        private void CareerSelected(object sender, EventArgs e)
        {
            careerTabController.CareerSelected((ICareer)CareerSelectComboBox.SelectedItem);
        }
        public string GetSelectedCareerName()
        {
            return this.CareerSelectComboBox.SelectedText;
        }
        public void PrintCareerDescription(string description)
        {
            CareerDetailsTextBox.Text = description;
        }

        public void DisplayFacultyUI()
        {
            this.SkillSelectGroupBox.Visible = true;
            this.SkillSelectGroupBox.Enabled = true;
        }
        public void EnablePlanButton()
        {
            this.FindStudyPlanButton.Enabled = true;
        }
        private void FindStudyPlanButton_Click(object sender, EventArgs e)
        {
            careerTabController.StudyPlanButton_Clicked();
        }
        public void ShowStudyPlanTab()
        {
            MainMenuTabControl.SelectedTab = StudyPlansTab;
         
        }
        public void AddMode(ICareerMode careerMode)
        {
            this.careerModeComboBox.Items.Add(careerMode);
        }

        #endregion

        #region Log In Panel

        public void InvalidUserInterface()
        {
            System.Windows.Forms.MessageBox.Show("Invalid User and password");
        }
        private void EnterPressedInPassword(object sender, EventArgs e)
        {
            LogInButton_Click(sender, e);
        }
        private void LogInPanelDisappear()
        {
            LogInPanel.Visible = false;
        }
        private void MainMenuAppear()
        {
            MainPanel.Visible = true;
            MainMenuTabControl.TabPages.Clear();
        }
        public void SetStudentTabs()
        {
            MainMenuTabControl.TabPages.Add(CareerTab);
            DisplayStudentUI();
            MainMenuTabControl.TabPages.Add(StudyPlansTab);

        }
        public void SetAdminTabs()
        {
            MainMenuTabControl.TabPages.Add(CareerTab);
            MainMenuTabControl.TabPages.Add(SubjectsTab);
            MainMenuTabControl.TabPages.Add(SkillsTab);
            MainMenuTabControl.TabPages.Add(StudyPlansTab);

        }
        public void SetFacultyTabs()
        {
            MainMenuTabControl.TabPages.Add(CareerTab);
            MainMenuTabControl.TabPages.Add(SubjectsTab);
            MainMenuTabControl.TabPages.Add(SkillsTab);
            DisplayFacultyUI();
        }
        public void LogInPanelAppear()
        {
            LogInPanel.Show();
        }
        public void MainMenuDisappear()
        {
            MainPanel.Hide();
            ResetTabs();
        }
        private void ResetTabs()
        {
            MainMenuTabControl.TabPages.Clear();
            MainMenuTabControl.TabPages.Add(CareerTab);
            MainMenuTabControl.TabPages.Add(SubjectsTab);
            MainMenuTabControl.TabPages.Add(StudyPlansTab);
        }

        public void DisplayStudentInterface()
        {
            EnterMainMenu();
            SetStudentTabs();
            NewCareerGroupBox.Visible = false;
            CareerSelectGroupBox.Visible = true;

        }

        public void DisplayFacultyMemberInterface()
        {
            EnterMainMenu();
            SetFacultyTabs();
            NewCareerGroupBox.Visible = true;
            CareerSelectGroupBox.Visible = false;
            SkillSelectGroupBox.Visible = true;

        }

        public void DisplayAdminInterface()
        {
            EnterMainMenu();
            SetAdminTabs();

        }
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
        public void ExitMainMenu()
        {
            MainMenuDisappear();
            LogInPanelAppear();
            this.Refresh();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logInPanelController.LogOut_Click();
        }


        #endregion


        #region SubjectTab
        public ISubjectTabController SubjectTabController
        {
            set { this.subjectTabController = value; }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            this.subjectTabController.EditButton_Click();
        }
        private void AddNewSubjectButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to add a new subject?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                subjectTabController.AddNewSubject_Click();
            }

        }
        public void AddSubjectToTable(ISubject subject)
        {
            this.SubjectsDataGrid.Rows.Add(subject, subject.Topic, subject.Credits);
        }
        public void ClearDataGrid()
        {
            this.SubjectsDataGrid.Rows.Clear();
        }

        public void RefreshDataGrid()
        {
            this.SubjectsDataGrid.Refresh();
        }
        #endregion

        #region Skill Tab

        public ISkillTabController SkillTabController
        {
            set { this.skillTabController = value; }
        }
        public void AddSkill(ISkill skill)
        {
            this.SkillsComboBox.Items.Add(skill);
        }
        private void SkillsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ISkill skill = (ISkill)SkillsComboBox.SelectedItem;
            this.skillTabController.SkillSelected(skill);
        }       
        
        public void UpdateSkillName(string p)
        {
            this.SkillNameTextBox.Text = p;
        }

        public void UpdateSkillDescription(string p)
        {
            this.SkillDescriptionTextBox.Text = p;
        }


        public void AddSkillSubject(ISubject subject)
        {
            this.SkillSubjectsListBox.Items.Add(subject);
            this.SkillSubjectsListBox.Refresh();
        }

        public void SubjectsClear()
        {
            this.SkillSubjectsListBox.Items.Clear();
        }

        internal void notifyNewSkills()
        {
            skillTabController.PopulateSkills();
            careerTabController.ShowAllSkills();
        }


        public void ClearSkills()
        {
            this.SkillsComboBox.Items.Clear();
        }


        public void ClearSkillSelect()
        {
            this.SkillSelectList.Items.Clear();
        }

        internal void UpdateSubjectLists()
        {
            this.subjectTabController.RebuildDataGrid();
        }

        private void RemoveSubjectButton_Click(object sender, EventArgs e)
        {
            this.subjectTabController.RemoveSubjectButton_Click();
        }
        public ISubject GetSelectedSubject()
        {
            ISubject subject;

            subject =(ISubject) SubjectsDataGrid.SelectedRows[0].Cells[0].Value;

            return subject;
        }

        public void AddRow(ISubject currentSubject, int rowIndex)
        {
            this.StudyPlanDataGrid.Rows.Add(currentSubject, rowIndex);
        }


        public void EnableNewCareerMode()
        {
            CareerSelectGroupBox.Enabled = false;
            SkillSelectGroupBox.Enabled = true;
        }
        private void Mode_Selected(object sender, EventArgs e)
        {
            ICareerMode current = (ICareerMode) this.careerModeComboBox.SelectedItem;
            this.careerTabController.ModeChanged(current);
        }

        public void EnableChooseCareerMode()
        {
            CareerSelectGroupBox.Enabled = true;
            SkillSelectGroupBox.Enabled = false;
        }
        public void ShowErrorMessage(string p)
        {
            MessageBox.Show(p);
        }
        #endregion




        public IEnumerable<ISkill> SelectedSkills()
        {
            List<ISkill> skills = new List<ISkill>();
            foreach(object skill in this.SkillSelectList.CheckedItems)
            {
                skills.Add((ISkill)skill);
            }
            return skills;
        }


        public void AddYearInfo(string p)
        {
            this.StudyPlanDataGrid.Rows.Add(p);
        }

        private void NewCareerSaveButton_Click(object sender, EventArgs e)
        {
            this.careerTabController.SaveNewCareer();
        }


        public string GrabNewCareerDescription()
        {
            return this.NewCareerDescriptionTextBox.Text;
        }

        public string GrabNewCareerName()
        {
            return this.NewCareerNameTextBox.Text;
        }


        public void ClearNewCareerData()
        {
            this.NewCareerNameTextBox.Clear();
            this.NewCareerDescriptionTextBox.Clear();
        }


        public ICareer GetSelectedCareer()
        {
            return (ICareer)this.CareerSelectComboBox.SelectedItem;
        }


        public void ClearStudyPlan()
        {
            this.StudyPlanDataGrid.Rows.Clear();
        }


        public void ShowMessage(string p)
        {
            MessageBox.Show(p);
        }
    }
}
