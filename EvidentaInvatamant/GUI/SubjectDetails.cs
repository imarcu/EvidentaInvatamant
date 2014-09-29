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
    public partial class SubjectDetails : Form,ISubjectsDetailsView
    {
        ISubjectDetailsController controller;
        MainMenu mainMenu;

        public MainMenu MainMenu
        {
            set { this.mainMenu = value; }
        }


        public SubjectDetails()
        {
            InitializeComponent();
        }

        public ISubjectDetailsController SubjectDetailsController
        {
            set { this.controller = value; }
        }
        #region numericMethods

                public void EnableLab()
                {
                    EnableNumeric(laboratoryNumeric);
                }

                public void DisableLab()
                {
                    DisableNumeric(laboratoryNumeric);
                }

                public int GetLabNumber()
                {
                    return GetNumber(laboratoryNumeric);
                }

                public void EnableProject()
                {
                    EnableNumeric(projectNumeric);
                }

                public void DisableProject()
                {
                    DisableNumeric(projectNumeric);
                }

                public int GetProjectNumber()
                {
                    return GetNumber(projectNumeric);
                }
                public void EnableCourse()
                {
                    EnableNumeric(courseNumeric);
                }
                public void DisableCourse()
                {
                    DisableNumeric(courseNumeric);
                }
                public int GetCourseNumber()
                {
                    return GetNumber(courseNumeric);
                }
                public void EnableSeminary()
                {
                    EnableNumeric(seminaryNumeric);
                }
                public void DisableSeminary()
                {
                    DisableNumeric(seminaryNumeric);
                }
                public int GetSeminaryNumber()
                {
                    return GetNumber(seminaryNumeric);
                }
                #region generic
                private void EnableNumeric(NumericUpDown numeric)
                {
                    numeric.Visible = true;
                    numeric.Value = 1;
                    numeric.Minimum = 1;
                }
                private void DisableNumeric(NumericUpDown numeric)
                {
                    numeric.Visible = false;
                    numeric.Minimum = 0;
                    numeric.Value = 0;
                }
                private int GetNumber(NumericUpDown numeric)
                {
                    return Convert.ToInt32(numeric.Value);
                }

                #endregion
        #endregion 

        private void CourseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.CourseCheckBox_CheckedChanged(CourseCheckBox.Checked);
        }

        private void seminaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.seminaryCheckBox_CheckedChanged(seminaryCheckBox.Checked);
        }

        private void LaboratoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.LaboratoryCheckBox_CheckedChanged(LaboratoryCheckBox.Checked);
        }        

        private void ProjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.ProjectCheckBox_CheckedChanged(ProjectCheckBox.Checked);
        }

        private void AddNewSkill_Click(object sender, EventArgs e)
        {
            this.controller.AddNewSkill_Click();
        }
        public void EnableNewSkillInput()
        {
            NewSkillNameTextBox.Visible = true;
            NewSkillOkButton.Visible = true;
        }
        public void DisableNewSkillInput()
        {
            NewSkillOkButton.Visible = false;
            NewSkillNameTextBox.Visible = false;
        }
        private void OKButton_Click(object sender, System.EventArgs e)
        {
            this.controller.OkButton_Click();
        }
        public void AddSkillToView(ISkill skill)
        {
            SkillsListBox.Items.Add(skill);
        }
        public void AddSubjectToView(ISubject subject)
        {
            this.PreRequisitesListBox.Items.Add(subject);
        }

        public void ClearSkillList()
        {
            this.SkillsListBox.Items.Clear();
        }
        public void ClearSubjectList()
        {
            this.PreRequisitesListBox.Items.Clear();
        }
        public string GrabNewSubjectName()
        {
            return this.NameTextBox.Text;
        }
        public string GrabSubjectTopic()
        {
            return this.NewTopicTextBox.Text;
        }
        public int GrabLabHrs()
        {
            return GetLabNumber();
        }

        public int GrabSeminaryHrs()
        {
            return GetSeminaryNumber();
        }

        public int GrabCourseHrs()
        {
            return GetCourseNumber();
        }

        public int GrabProjectHrs()
        {
            return GetProjectNumber();
        }
        public List<ISkill> GrabSelectedSkills()
        {
            List<ISkill> selectedSkills = new List<ISkill>();
            for (int i = 0; i < SkillsListBox.Items.Count; i++)
            {
                if (SkillsListBox.GetItemChecked(i))
                {
                    selectedSkills.Add(controller.GetSkillAt(i));
                }
            }
            return selectedSkills;

        }
        public List<ISkill> GrabDeselectedSkills()
        {
            List<ISkill> deselectedSkills = new List<ISkill>();
            for(int i=0;i< SkillsListBox.Items.Count;i++)
            {
                if (SkillsListBox.GetItemChecked(i))
                {

                }
                else
                {
                    deselectedSkills.Add(this.controller.GetSkillAt(i));
                }
            }
            return deselectedSkills;

        }
        public IPreRequisites GrabPreRquisites()
        {
            IPreRequisites preRequisites = new PreRequisites();
            foreach(object subject in PreRequisitesListBox.CheckedItems)
            {
                preRequisites.Add((ISubject)subject);
            }

            return preRequisites;

        }

        private void NewSkillOkButton_Click(object sender, EventArgs e)
        {
            controller.NewSkillOKButton_Click();
        }
        public string GrabNewSkillName()
        {
            return this.NewSkillNameTextBox.Text;
        }



        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }


        public void ClearNewSkillTextBox()
        {
            this.NewSkillNameTextBox.Clear();
        }


        public void ClearName()
        {
            NameTextBox.Clear();
        }


        public bool NoHrsSelected()
        {
            return GrabCourseHrs() + GrabProjectHrs() + GrabSeminaryHrs() + GrabLabHrs() == 0;
        }


        public void Show(ISubject subject)
        {
            this.Show();
            this.controller.Subject = subject;
        }


        public int GrabCreditNr()
        {
            return Convert.ToInt32( creditsNumeric.Value);
        }


        public void ClearEverything()
        {
            this.NameTextBox.Clear();
            this.NewTopicTextBox.Clear();
            this.CourseCheckBox.Checked = false;
            this.ProjectCheckBox.Checked = false;
            this.seminaryCheckBox.Checked = false;
            this.LaboratoryCheckBox.Checked = false;
            DisableCourse();
            DisableLab();
            DisableProject();
            DisableSeminary();
            this.PreRequisitesListBox.Items.Clear();
            this.SkillsListBox.Items.Clear();
            this.creditsNumeric.Value = 1;
        }

        public void CloseWindow()
        {
            this.Hide();
        }


        public void NotifyNewSkills()
        {
            mainMenu.notifyNewSkills();
        }


        public void UpdateViews()
        {
            mainMenu.UpdateSubjectLists();
        }


        public void EditSubject(ISubject subject)
        {
            this.Show(subject);
            this.controller.ShowSubjectData();
        }


        public void AddName(string p)
        {
            this.NameTextBox.Text = p;
        }

        public void AddTopic(string p)
        {
            this.NewTopicTextBox.Text = p;
        }

        public void setCredit(int p)
        {
            this.creditsNumeric.Value = p;
        }
    }
}
