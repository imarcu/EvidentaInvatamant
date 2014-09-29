namespace EvidentaInvatamant
{
    partial class MainMenu 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenuTabControl = new System.Windows.Forms.TabControl();
            this.CareerTab = new System.Windows.Forms.TabPage();
            this.careerModeInfoLabel = new System.Windows.Forms.Label();
            this.careerModeComboBox = new System.Windows.Forms.ComboBox();
            this.FindStudyPlanButton = new System.Windows.Forms.Button();
            this.SkillSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SkillSelectList = new System.Windows.Forms.CheckedListBox();
            this.NewCareerGroupBox = new System.Windows.Forms.GroupBox();
            this.NewCareerSaveButton = new System.Windows.Forms.Button();
            this.NewCareerDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NewCareerDescriptionLabel = new System.Windows.Forms.Label();
            this.NewCareerNameTextBox = new System.Windows.Forms.TextBox();
            this.NewCareerNameLabel = new System.Windows.Forms.Label();
            this.CareerSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.CareerDetailsTextBox = new System.Windows.Forms.TextBox();
            this.CareerDetailsLabel = new System.Windows.Forms.Label();
            this.CareerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectsTab = new System.Windows.Forms.TabPage();
            this.SubjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.SubjectNameTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectTopicTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCreditTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSubjectButton = new System.Windows.Forms.Button();
            this.EditSubjectButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.StudyPlansTab = new System.Windows.Forms.TabPage();
            this.AddSubjectInfoLabel = new System.Windows.Forms.Label();
            this.SubjectYearComboBox = new System.Windows.Forms.ComboBox();
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.StudyPlanDataGrid = new System.Windows.Forms.DataGridView();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectYearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillsTab = new System.Windows.Forms.TabPage();
            this.SkillSubjectsLabel = new System.Windows.Forms.Label();
            this.SkillSubjectsListBox = new System.Windows.Forms.ListBox();
            this.SkillDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SkillDescriptionLabel = new System.Windows.Forms.Label();
            this.SkillNameTextBox = new System.Windows.Forms.TextBox();
            this.SkillNameLabel = new System.Windows.Forms.Label();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.SkillsComboBox = new System.Windows.Forms.ComboBox();
            this.SubjectsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.LogInGroupBox = new System.Windows.Forms.GroupBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.MainMenuTabControl.SuspendLayout();
            this.CareerTab.SuspendLayout();
            this.SkillSelectGroupBox.SuspendLayout();
            this.NewCareerGroupBox.SuspendLayout();
            this.CareerSelectGroupBox.SuspendLayout();
            this.SubjectsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).BeginInit();
            this.StudyPlansTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudyPlanDataGrid)).BeginInit();
            this.SkillsTab.SuspendLayout();
            this.SubjectsMenuStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.LogInPanel.SuspendLayout();
            this.LogInGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuTabControl
            // 
            this.MainMenuTabControl.Controls.Add(this.CareerTab);
            this.MainMenuTabControl.Controls.Add(this.SubjectsTab);
            this.MainMenuTabControl.Controls.Add(this.StudyPlansTab);
            this.MainMenuTabControl.Controls.Add(this.SkillsTab);
            this.MainMenuTabControl.Location = new System.Drawing.Point(5, 1);
            this.MainMenuTabControl.Name = "MainMenuTabControl";
            this.MainMenuTabControl.SelectedIndex = 0;
            this.MainMenuTabControl.Size = new System.Drawing.Size(686, 424);
            this.MainMenuTabControl.TabIndex = 0;
            // 
            // CareerTab
            // 
            this.CareerTab.Controls.Add(this.careerModeInfoLabel);
            this.CareerTab.Controls.Add(this.careerModeComboBox);
            this.CareerTab.Controls.Add(this.FindStudyPlanButton);
            this.CareerTab.Controls.Add(this.SkillSelectGroupBox);
            this.CareerTab.Controls.Add(this.NewCareerGroupBox);
            this.CareerTab.Controls.Add(this.CareerSelectGroupBox);
            this.CareerTab.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CareerTab.Location = new System.Drawing.Point(4, 22);
            this.CareerTab.Name = "CareerTab";
            this.CareerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CareerTab.Size = new System.Drawing.Size(678, 398);
            this.CareerTab.TabIndex = 0;
            this.CareerTab.Text = "Career";
            this.CareerTab.UseVisualStyleBackColor = true;
            // 
            // careerModeInfoLabel
            // 
            this.careerModeInfoLabel.AutoSize = true;
            this.careerModeInfoLabel.Location = new System.Drawing.Point(33, 20);
            this.careerModeInfoLabel.Name = "careerModeInfoLabel";
            this.careerModeInfoLabel.Size = new System.Drawing.Size(47, 13);
            this.careerModeInfoLabel.TabIndex = 8;
            this.careerModeInfoLabel.Text = "You can";
            this.careerModeInfoLabel.Visible = false;
            // 
            // careerModeComboBox
            // 
            this.careerModeComboBox.FormattingEnabled = true;
            this.careerModeComboBox.Location = new System.Drawing.Point(86, 15);
            this.careerModeComboBox.Name = "careerModeComboBox";
            this.careerModeComboBox.Size = new System.Drawing.Size(159, 21);
            this.careerModeComboBox.TabIndex = 7;
            this.careerModeComboBox.Visible = false;
            this.careerModeComboBox.SelectedIndexChanged += new System.EventHandler(this.Mode_Selected);
            this.careerModeComboBox.SelectionChangeCommitted += new System.EventHandler(this.Mode_Selected);
            this.careerModeComboBox.SelectedValueChanged += new System.EventHandler(this.Mode_Selected);
            // 
            // FindStudyPlanButton
            // 
            this.FindStudyPlanButton.Location = new System.Drawing.Point(533, 13);
            this.FindStudyPlanButton.Name = "FindStudyPlanButton";
            this.FindStudyPlanButton.Size = new System.Drawing.Size(107, 23);
            this.FindStudyPlanButton.TabIndex = 2;
            this.FindStudyPlanButton.Text = "View StudyPlan";
            this.FindStudyPlanButton.UseVisualStyleBackColor = true;
            this.FindStudyPlanButton.Visible = false;
            this.FindStudyPlanButton.Click += new System.EventHandler(this.FindStudyPlanButton_Click);
            // 
            // SkillSelectGroupBox
            // 
            this.SkillSelectGroupBox.Controls.Add(this.label1);
            this.SkillSelectGroupBox.Controls.Add(this.SkillSelectList);
            this.SkillSelectGroupBox.Location = new System.Drawing.Point(371, 47);
            this.SkillSelectGroupBox.Name = "SkillSelectGroupBox";
            this.SkillSelectGroupBox.Size = new System.Drawing.Size(269, 290);
            this.SkillSelectGroupBox.TabIndex = 5;
            this.SkillSelectGroupBox.TabStop = false;
            this.SkillSelectGroupBox.Text = "Select the skills";
            this.SkillSelectGroupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // SkillSelectList
            // 
            this.SkillSelectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillSelectList.CheckOnClick = true;
            this.SkillSelectList.FormattingEnabled = true;
            this.SkillSelectList.Location = new System.Drawing.Point(16, 28);
            this.SkillSelectList.Name = "SkillSelectList";
            this.SkillSelectList.ScrollAlwaysVisible = true;
            this.SkillSelectList.Size = new System.Drawing.Size(226, 195);
            this.SkillSelectList.TabIndex = 4;
            this.SkillSelectList.SelectedIndexChanged += new System.EventHandler(this.SkillSelectList_SelectedIndexChanged);
            // 
            // NewCareerGroupBox
            // 
            this.NewCareerGroupBox.Controls.Add(this.NewCareerSaveButton);
            this.NewCareerGroupBox.Controls.Add(this.NewCareerDescriptionTextBox);
            this.NewCareerGroupBox.Controls.Add(this.NewCareerDescriptionLabel);
            this.NewCareerGroupBox.Controls.Add(this.NewCareerNameTextBox);
            this.NewCareerGroupBox.Controls.Add(this.NewCareerNameLabel);
            this.NewCareerGroupBox.Location = new System.Drawing.Point(22, 47);
            this.NewCareerGroupBox.Name = "NewCareerGroupBox";
            this.NewCareerGroupBox.Size = new System.Drawing.Size(284, 290);
            this.NewCareerGroupBox.TabIndex = 2;
            this.NewCareerGroupBox.TabStop = false;
            this.NewCareerGroupBox.Text = "Make a new Career";
            // 
            // NewCareerSaveButton
            // 
            this.NewCareerSaveButton.Location = new System.Drawing.Point(17, 245);
            this.NewCareerSaveButton.Name = "NewCareerSaveButton";
            this.NewCareerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.NewCareerSaveButton.TabIndex = 7;
            this.NewCareerSaveButton.Text = "Save";
            this.NewCareerSaveButton.UseVisualStyleBackColor = true;
            this.NewCareerSaveButton.Click += new System.EventHandler(this.NewCareerSaveButton_Click);
            // 
            // NewCareerDescriptionTextBox
            // 
            this.NewCareerDescriptionTextBox.Location = new System.Drawing.Point(80, 85);
            this.NewCareerDescriptionTextBox.Multiline = true;
            this.NewCareerDescriptionTextBox.Name = "NewCareerDescriptionTextBox";
            this.NewCareerDescriptionTextBox.Size = new System.Drawing.Size(175, 138);
            this.NewCareerDescriptionTextBox.TabIndex = 3;
            // 
            // NewCareerDescriptionLabel
            // 
            this.NewCareerDescriptionLabel.AutoSize = true;
            this.NewCareerDescriptionLabel.Location = new System.Drawing.Point(14, 86);
            this.NewCareerDescriptionLabel.Name = "NewCareerDescriptionLabel";
            this.NewCareerDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.NewCareerDescriptionLabel.TabIndex = 2;
            this.NewCareerDescriptionLabel.Text = "Description";
            // 
            // NewCareerNameTextBox
            // 
            this.NewCareerNameTextBox.Location = new System.Drawing.Point(80, 48);
            this.NewCareerNameTextBox.Name = "NewCareerNameTextBox";
            this.NewCareerNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.NewCareerNameTextBox.TabIndex = 1;
            // 
            // NewCareerNameLabel
            // 
            this.NewCareerNameLabel.AutoSize = true;
            this.NewCareerNameLabel.Location = new System.Drawing.Point(14, 51);
            this.NewCareerNameLabel.Name = "NewCareerNameLabel";
            this.NewCareerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.NewCareerNameLabel.TabIndex = 0;
            this.NewCareerNameLabel.Text = "Name";
            // 
            // CareerSelectGroupBox
            // 
            this.CareerSelectGroupBox.Controls.Add(this.CareerDetailsTextBox);
            this.CareerSelectGroupBox.Controls.Add(this.CareerDetailsLabel);
            this.CareerSelectGroupBox.Controls.Add(this.CareerSelectComboBox);
            this.CareerSelectGroupBox.Location = new System.Drawing.Point(22, 47);
            this.CareerSelectGroupBox.Name = "CareerSelectGroupBox";
            this.CareerSelectGroupBox.Size = new System.Drawing.Size(284, 290);
            this.CareerSelectGroupBox.TabIndex = 6;
            this.CareerSelectGroupBox.TabStop = false;
            this.CareerSelectGroupBox.Text = "Choose a Career you want to follow";
            // 
            // CareerDetailsTextBox
            // 
            this.CareerDetailsTextBox.Enabled = false;
            this.CareerDetailsTextBox.Location = new System.Drawing.Point(11, 103);
            this.CareerDetailsTextBox.Multiline = true;
            this.CareerDetailsTextBox.Name = "CareerDetailsTextBox";
            this.CareerDetailsTextBox.Size = new System.Drawing.Size(255, 126);
            this.CareerDetailsTextBox.TabIndex = 2;
            // 
            // CareerDetailsLabel
            // 
            this.CareerDetailsLabel.AutoSize = true;
            this.CareerDetailsLabel.Location = new System.Drawing.Point(11, 67);
            this.CareerDetailsLabel.Name = "CareerDetailsLabel";
            this.CareerDetailsLabel.Size = new System.Drawing.Size(171, 13);
            this.CareerDetailsLabel.TabIndex = 1;
            this.CareerDetailsLabel.Text = "Details About The Career Selected";
            // 
            // CareerSelectComboBox
            // 
            this.CareerSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CareerSelectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CareerSelectComboBox.FormattingEnabled = true;
            this.CareerSelectComboBox.Location = new System.Drawing.Point(11, 39);
            this.CareerSelectComboBox.Name = "CareerSelectComboBox";
            this.CareerSelectComboBox.Size = new System.Drawing.Size(236, 21);
            this.CareerSelectComboBox.TabIndex = 0;
            this.CareerSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.CareerSelectComboBox_SelectedIndexChanged);
            this.CareerSelectComboBox.SelectionChangeCommitted += new System.EventHandler(this.CareerSelected);
            // 
            // SubjectsTab
            // 
            this.SubjectsTab.Controls.Add(this.SubjectsDataGrid);
            this.SubjectsTab.Controls.Add(this.RemoveSubjectButton);
            this.SubjectsTab.Controls.Add(this.EditSubjectButton);
            this.SubjectsTab.Controls.Add(this.button2);
            this.SubjectsTab.Location = new System.Drawing.Point(4, 22);
            this.SubjectsTab.Name = "SubjectsTab";
            this.SubjectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsTab.Size = new System.Drawing.Size(678, 398);
            this.SubjectsTab.TabIndex = 1;
            this.SubjectsTab.Text = "Subjects";
            this.SubjectsTab.UseVisualStyleBackColor = true;
            // 
            // SubjectsDataGrid
            // 
            this.SubjectsDataGrid.AllowUserToAddRows = false;
            this.SubjectsDataGrid.AllowUserToResizeColumns = false;
            this.SubjectsDataGrid.AllowUserToResizeRows = false;
            this.SubjectsDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SubjectsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectNameTab,
            this.SubjectTopicTab,
            this.SubjectCreditTab});
            this.SubjectsDataGrid.Location = new System.Drawing.Point(26, 46);
            this.SubjectsDataGrid.MultiSelect = false;
            this.SubjectsDataGrid.Name = "SubjectsDataGrid";
            this.SubjectsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectsDataGrid.Size = new System.Drawing.Size(619, 299);
            this.SubjectsDataGrid.TabIndex = 7;
            // 
            // SubjectNameTab
            // 
            this.SubjectNameTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectNameTab.HeaderText = "Name";
            this.SubjectNameTab.Name = "SubjectNameTab";
            this.SubjectNameTab.ReadOnly = true;
            // 
            // SubjectTopicTab
            // 
            this.SubjectTopicTab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectTopicTab.HeaderText = "Topic";
            this.SubjectTopicTab.Name = "SubjectTopicTab";
            this.SubjectTopicTab.ReadOnly = true;
            // 
            // SubjectCreditTab
            // 
            this.SubjectCreditTab.HeaderText = "Credit";
            this.SubjectCreditTab.Name = "SubjectCreditTab";
            this.SubjectCreditTab.ReadOnly = true;
            // 
            // RemoveSubjectButton
            // 
            this.RemoveSubjectButton.Location = new System.Drawing.Point(250, 351);
            this.RemoveSubjectButton.Name = "RemoveSubjectButton";
            this.RemoveSubjectButton.Size = new System.Drawing.Size(106, 23);
            this.RemoveSubjectButton.TabIndex = 6;
            this.RemoveSubjectButton.Text = "Remove";
            this.RemoveSubjectButton.UseVisualStyleBackColor = true;
            this.RemoveSubjectButton.Click += new System.EventHandler(this.RemoveSubjectButton_Click);
            // 
            // EditSubjectButton
            // 
            this.EditSubjectButton.Location = new System.Drawing.Point(138, 351);
            this.EditSubjectButton.Name = "EditSubjectButton";
            this.EditSubjectButton.Size = new System.Drawing.Size(106, 23);
            this.EditSubjectButton.TabIndex = 5;
            this.EditSubjectButton.Text = "Edit";
            this.EditSubjectButton.UseVisualStyleBackColor = true;
            this.EditSubjectButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add New Subject";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddNewSubjectButton_Click);
            // 
            // StudyPlansTab
            // 
            this.StudyPlansTab.Controls.Add(this.AddSubjectInfoLabel);
            this.StudyPlansTab.Controls.Add(this.SubjectYearComboBox);
            this.StudyPlansTab.Controls.Add(this.subjectNameComboBox);
            this.StudyPlansTab.Controls.Add(this.AddSubjectButton);
            this.StudyPlansTab.Controls.Add(this.StudyPlanDataGrid);
            this.StudyPlansTab.Location = new System.Drawing.Point(4, 22);
            this.StudyPlansTab.Name = "StudyPlansTab";
            this.StudyPlansTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudyPlansTab.Size = new System.Drawing.Size(678, 398);
            this.StudyPlansTab.TabIndex = 2;
            this.StudyPlansTab.Text = "Study Plans";
            this.StudyPlansTab.UseVisualStyleBackColor = true;
            // 
            // AddSubjectInfoLabel
            // 
            this.AddSubjectInfoLabel.AutoSize = true;
            this.AddSubjectInfoLabel.Location = new System.Drawing.Point(33, 23);
            this.AddSubjectInfoLabel.Name = "AddSubjectInfoLabel";
            this.AddSubjectInfoLabel.Size = new System.Drawing.Size(194, 13);
            this.AddSubjectInfoLabel.TabIndex = 4;
            this.AddSubjectInfoLabel.Text = "You can add a subject to the plan here ";
            this.AddSubjectInfoLabel.Visible = false;
            // 
            // SubjectYearComboBox
            // 
            this.SubjectYearComboBox.FormattingEnabled = true;
            this.SubjectYearComboBox.Location = new System.Drawing.Point(440, 20);
            this.SubjectYearComboBox.Name = "SubjectYearComboBox";
            this.SubjectYearComboBox.Size = new System.Drawing.Size(76, 21);
            this.SubjectYearComboBox.TabIndex = 3;
            this.SubjectYearComboBox.Visible = false;
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(245, 20);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.subjectNameComboBox.TabIndex = 2;
            this.subjectNameComboBox.Visible = false;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(563, 18);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(75, 23);
            this.AddSubjectButton.TabIndex = 1;
            this.AddSubjectButton.Text = "Add";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Visible = false;
            // 
            // StudyPlanDataGrid
            // 
            this.StudyPlanDataGrid.AllowUserToAddRows = false;
            this.StudyPlanDataGrid.AllowUserToResizeColumns = false;
            this.StudyPlanDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudyPlanDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectNameColumn,
            this.SubjectYearColumn});
            this.StudyPlanDataGrid.Location = new System.Drawing.Point(18, 56);
            this.StudyPlanDataGrid.Name = "StudyPlanDataGrid";
            this.StudyPlanDataGrid.Size = new System.Drawing.Size(638, 318);
            this.StudyPlanDataGrid.TabIndex = 0;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectNameColumn.HeaderText = "Name";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            // 
            // SubjectYearColumn
            // 
            this.SubjectYearColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectYearColumn.HeaderText = "Year";
            this.SubjectYearColumn.Name = "SubjectYearColumn";
            this.SubjectYearColumn.ReadOnly = true;
            // 
            // SkillsTab
            // 
            this.SkillsTab.Controls.Add(this.SkillSubjectsLabel);
            this.SkillsTab.Controls.Add(this.SkillSubjectsListBox);
            this.SkillsTab.Controls.Add(this.SkillDescriptionTextBox);
            this.SkillsTab.Controls.Add(this.SkillDescriptionLabel);
            this.SkillsTab.Controls.Add(this.SkillNameTextBox);
            this.SkillsTab.Controls.Add(this.SkillNameLabel);
            this.SkillsTab.Controls.Add(this.SkillLabel);
            this.SkillsTab.Controls.Add(this.SkillsComboBox);
            this.SkillsTab.Location = new System.Drawing.Point(4, 22);
            this.SkillsTab.Name = "SkillsTab";
            this.SkillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SkillsTab.Size = new System.Drawing.Size(678, 398);
            this.SkillsTab.TabIndex = 3;
            this.SkillsTab.Text = "Skills";
            this.SkillsTab.UseVisualStyleBackColor = true;
            // 
            // SkillSubjectsLabel
            // 
            this.SkillSubjectsLabel.AutoSize = true;
            this.SkillSubjectsLabel.Location = new System.Drawing.Point(378, 95);
            this.SkillSubjectsLabel.Name = "SkillSubjectsLabel";
            this.SkillSubjectsLabel.Size = new System.Drawing.Size(48, 13);
            this.SkillSubjectsLabel.TabIndex = 7;
            this.SkillSubjectsLabel.Text = "Subjects";
            // 
            // SkillSubjectsListBox
            // 
            this.SkillSubjectsListBox.FormattingEnabled = true;
            this.SkillSubjectsListBox.Location = new System.Drawing.Point(378, 118);
            this.SkillSubjectsListBox.Name = "SkillSubjectsListBox";
            this.SkillSubjectsListBox.Size = new System.Drawing.Size(195, 147);
            this.SkillSubjectsListBox.TabIndex = 6;
            // 
            // SkillDescriptionTextBox
            // 
            this.SkillDescriptionTextBox.Location = new System.Drawing.Point(118, 162);
            this.SkillDescriptionTextBox.Multiline = true;
            this.SkillDescriptionTextBox.Name = "SkillDescriptionTextBox";
            this.SkillDescriptionTextBox.Size = new System.Drawing.Size(127, 103);
            this.SkillDescriptionTextBox.TabIndex = 5;
            // 
            // SkillDescriptionLabel
            // 
            this.SkillDescriptionLabel.AutoSize = true;
            this.SkillDescriptionLabel.Location = new System.Drawing.Point(33, 162);
            this.SkillDescriptionLabel.Name = "SkillDescriptionLabel";
            this.SkillDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.SkillDescriptionLabel.TabIndex = 4;
            this.SkillDescriptionLabel.Text = "Description";
            // 
            // SkillNameTextBox
            // 
            this.SkillNameTextBox.Location = new System.Drawing.Point(118, 118);
            this.SkillNameTextBox.Name = "SkillNameTextBox";
            this.SkillNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.SkillNameTextBox.TabIndex = 3;
            // 
            // SkillNameLabel
            // 
            this.SkillNameLabel.AutoSize = true;
            this.SkillNameLabel.Location = new System.Drawing.Point(33, 118);
            this.SkillNameLabel.Name = "SkillNameLabel";
            this.SkillNameLabel.Size = new System.Drawing.Size(35, 13);
            this.SkillNameLabel.TabIndex = 2;
            this.SkillNameLabel.Text = "Name";
            // 
            // SkillLabel
            // 
            this.SkillLabel.AutoSize = true;
            this.SkillLabel.Location = new System.Drawing.Point(29, 62);
            this.SkillLabel.Name = "SkillLabel";
            this.SkillLabel.Size = new System.Drawing.Size(66, 13);
            this.SkillLabel.TabIndex = 1;
            this.SkillLabel.Text = "Select a skill";
            // 
            // SkillsComboBox
            // 
            this.SkillsComboBox.DropDownHeight = 200;
            this.SkillsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkillsComboBox.FormattingEnabled = true;
            this.SkillsComboBox.IntegralHeight = false;
            this.SkillsComboBox.Location = new System.Drawing.Point(182, 59);
            this.SkillsComboBox.Name = "SkillsComboBox";
            this.SkillsComboBox.Size = new System.Drawing.Size(261, 21);
            this.SkillsComboBox.TabIndex = 0;
            this.SkillsComboBox.SelectedIndexChanged += new System.EventHandler(this.SkillsComboBox_SelectedIndexChanged);
            // 
            // SubjectsMenuStrip
            // 
            this.SubjectsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.SubjectsMenuStrip.Name = "SubjectsMenuStrip";
            this.SubjectsMenuStrip.Size = new System.Drawing.Size(138, 48);
            // 
            // viewDetailsToolStripMenuItem1
            // 
            this.viewDetailsToolStripMenuItem1.Name = "viewDetailsToolStripMenuItem1";
            this.viewDetailsToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.viewDetailsToolStripMenuItem1.Text = "View Details";
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(50, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "User";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MainMenuTabControl);
            this.MainPanel.Location = new System.Drawing.Point(7, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(702, 433);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Visible = false;
            // 
            // LogInPanel
            // 
            this.LogInPanel.Controls.Add(this.LogInGroupBox);
            this.LogInPanel.Location = new System.Drawing.Point(90, 12);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(553, 448);
            this.LogInPanel.TabIndex = 5;
            // 
            // LogInGroupBox
            // 
            this.LogInGroupBox.Controls.Add(this.LogInButton);
            this.LogInGroupBox.Controls.Add(this.PasswordTextBox);
            this.LogInGroupBox.Controls.Add(this.PasswordLabel);
            this.LogInGroupBox.Controls.Add(this.UserNameTextBox);
            this.LogInGroupBox.Controls.Add(this.LogInLabel);
            this.LogInGroupBox.Location = new System.Drawing.Point(108, 133);
            this.LogInGroupBox.Name = "LogInGroupBox";
            this.LogInGroupBox.Size = new System.Drawing.Size(334, 187);
            this.LogInGroupBox.TabIndex = 0;
            this.LogInGroupBox.TabStop = false;
            this.LogInGroupBox.Text = "Log In";
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(130, 144);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(75, 23);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(91, 90);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "Password";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(34, 93);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(91, 64);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(153, 20);
            this.UserNameTextBox.TabIndex = 1;
            this.UserNameTextBox.Text = "Name";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Location = new System.Drawing.Point(34, 67);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(29, 13);
            this.LogInLabel.TabIndex = 0;
            this.LogInLabel.Text = "User";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LogInPanel);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.MainMenuTabControl.ResumeLayout(false);
            this.CareerTab.ResumeLayout(false);
            this.CareerTab.PerformLayout();
            this.SkillSelectGroupBox.ResumeLayout(false);
            this.SkillSelectGroupBox.PerformLayout();
            this.NewCareerGroupBox.ResumeLayout(false);
            this.NewCareerGroupBox.PerformLayout();
            this.CareerSelectGroupBox.ResumeLayout(false);
            this.CareerSelectGroupBox.PerformLayout();
            this.SubjectsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).EndInit();
            this.StudyPlansTab.ResumeLayout(false);
            this.StudyPlansTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudyPlanDataGrid)).EndInit();
            this.SkillsTab.ResumeLayout(false);
            this.SkillsTab.PerformLayout();
            this.SubjectsMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.LogInPanel.ResumeLayout(false);
            this.LogInGroupBox.ResumeLayout(false);
            this.LogInGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SkillSelectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
        }

        private void SubjectsViewList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
          
        }



        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.ContextMenuStrip.Show();
        }



        #endregion

        private System.Windows.Forms.TabControl MainMenuTabControl;
        private System.Windows.Forms.TabPage CareerTab;
        private System.Windows.Forms.TabPage SubjectsTab;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button FindStudyPlanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox SkillSelectList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage StudyPlansTab;
        private System.Windows.Forms.Button RemoveSubjectButton;
        private System.Windows.Forms.Button EditSubjectButton;
        private System.Windows.Forms.GroupBox SkillSelectGroupBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.GroupBox LogInGroupBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TextBox textbox1;




        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SubjectsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.TabPage SkillsTab;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.ComboBox SkillsComboBox;
        private System.Windows.Forms.TextBox SkillDescriptionTextBox;
        private System.Windows.Forms.Label SkillDescriptionLabel;
        private System.Windows.Forms.TextBox SkillNameTextBox;
        private System.Windows.Forms.Label SkillNameLabel;
        private System.Windows.Forms.GroupBox CareerSelectGroupBox;
        private System.Windows.Forms.ComboBox CareerSelectComboBox;
        private System.Windows.Forms.Label CareerDetailsLabel;
        private System.Windows.Forms.GroupBox NewCareerGroupBox;
        private System.Windows.Forms.Button NewCareerSaveButton;
        private System.Windows.Forms.TextBox NewCareerDescriptionTextBox;
        private System.Windows.Forms.Label NewCareerDescriptionLabel;
        private System.Windows.Forms.TextBox NewCareerNameTextBox;
        private System.Windows.Forms.Label NewCareerNameLabel;
        private System.Windows.Forms.TextBox CareerDetailsTextBox;
        private System.Windows.Forms.ComboBox careerModeComboBox;
        private System.Windows.Forms.DataGridView SubjectsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectTopicTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCreditTab;
        private System.Windows.Forms.Label SkillSubjectsLabel;
        private System.Windows.Forms.ListBox SkillSubjectsListBox;
        private System.Windows.Forms.DataGridView StudyPlanDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectYearColumn;
        private System.Windows.Forms.Label careerModeInfoLabel;
        private System.Windows.Forms.Label AddSubjectInfoLabel;
        private System.Windows.Forms.ComboBox SubjectYearComboBox;
        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.Button AddSubjectButton;
        

      
    }
}

