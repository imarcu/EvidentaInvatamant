using System.Windows.Forms;

namespace EvidentaInvatamant
{
    partial class MainMenu:IMainMenuView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Topic1",
            "3"}, -1);
            this.MainMenuTabControl = new System.Windows.Forms.TabControl();
            this.CareerTab = new System.Windows.Forms.TabPage();
            this.CareerSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.CareerDetailsLabel = new System.Windows.Forms.Label();
            this.CareerSelectComboBox = new System.Windows.Forms.ComboBox();
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
            this.SubjectsTab = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SubjectsViewList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Credits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.StudyPlansTab = new System.Windows.Forms.TabPage();
            this.SkillViewList = new System.Windows.Forms.ListView();
            this.SubjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudyPlanMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAlternateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsTab = new System.Windows.Forms.TabPage();
            this.SkillsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SkillDescriptionLabel = new System.Windows.Forms.Label();
            this.SkillNameTextBox = new System.Windows.Forms.TextBox();
            this.SkillNameLabel = new System.Windows.Forms.Label();
            this.SkillLabel = new System.Windows.Forms.Label();
            this.SkillsComboBox = new System.Windows.Forms.ComboBox();
            this.Users = new System.Windows.Forms.TabPage();
            this.NewUserNameLabel = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenuTabControl.SuspendLayout();
            this.CareerTab.SuspendLayout();
            this.CareerSelectGroupBox.SuspendLayout();
            this.SkillSelectGroupBox.SuspendLayout();
            this.NewCareerGroupBox.SuspendLayout();
            this.SubjectsTab.SuspendLayout();
            this.SubjectsMenuStrip.SuspendLayout();
            this.StudyPlansTab.SuspendLayout();
            this.StudyPlanMenuStrip.SuspendLayout();
            this.SkillsTab.SuspendLayout();
            this.Users.SuspendLayout();
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
            this.MainMenuTabControl.Controls.Add(this.Users);
            this.MainMenuTabControl.Location = new System.Drawing.Point(5, 1);
            this.MainMenuTabControl.Name = "MainMenuTabControl";
            this.MainMenuTabControl.SelectedIndex = 0;
            this.MainMenuTabControl.Size = new System.Drawing.Size(686, 424);
            this.MainMenuTabControl.TabIndex = 0;
            // 
            // CareerTab
            // 
            this.CareerTab.Controls.Add(this.CareerSelectGroupBox);
            this.CareerTab.Controls.Add(this.FindStudyPlanButton);
            this.CareerTab.Controls.Add(this.SkillSelectGroupBox);
            this.CareerTab.Controls.Add(this.NewCareerGroupBox);
            this.CareerTab.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CareerTab.Location = new System.Drawing.Point(4, 22);
            this.CareerTab.Name = "CareerTab";
            this.CareerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CareerTab.Size = new System.Drawing.Size(678, 398);
            this.CareerTab.TabIndex = 0;
            this.CareerTab.Text = "Career";
            this.CareerTab.UseVisualStyleBackColor = true;
            this.CareerTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // CareerSelectGroupBox
            // 
            this.CareerSelectGroupBox.Controls.Add(this.CareerDetailsLabel);
            this.CareerSelectGroupBox.Controls.Add(this.CareerSelectComboBox);
            this.CareerSelectGroupBox.Location = new System.Drawing.Point(22, 47);
            this.CareerSelectGroupBox.Name = "CareerSelectGroupBox";
            this.CareerSelectGroupBox.Size = new System.Drawing.Size(284, 290);
            this.CareerSelectGroupBox.TabIndex = 6;
            this.CareerSelectGroupBox.TabStop = false;
            this.CareerSelectGroupBox.Text = "Choose a Career you want to follow";
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
            // 
            // FindStudyPlanButton
            // 
            this.FindStudyPlanButton.Location = new System.Drawing.Point(22, 353);
            this.FindStudyPlanButton.Name = "FindStudyPlanButton";
            this.FindStudyPlanButton.Size = new System.Drawing.Size(75, 23);
            this.FindStudyPlanButton.TabIndex = 2;
            this.FindStudyPlanButton.Text = "Next";
            this.FindStudyPlanButton.UseVisualStyleBackColor = true;
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
            // SubjectsTab
            // 
            this.SubjectsTab.Controls.Add(this.button4);
            this.SubjectsTab.Controls.Add(this.button3);
            this.SubjectsTab.Controls.Add(this.SubjectsViewList);
            this.SubjectsTab.Controls.Add(this.button2);
            this.SubjectsTab.Location = new System.Drawing.Point(4, 22);
            this.SubjectsTab.Name = "SubjectsTab";
            this.SubjectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubjectsTab.Size = new System.Drawing.Size(678, 398);
            this.SubjectsTab.TabIndex = 1;
            this.SubjectsTab.Text = "Subjects";
            this.SubjectsTab.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SubjectsViewList
            // 
            this.SubjectsViewList.CheckBoxes = true;
            this.SubjectsViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.Credits});
            this.SubjectsViewList.ContextMenuStrip = this.SubjectsMenuStrip;
            this.SubjectsViewList.FullRowSelect = true;
            this.SubjectsViewList.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            this.SubjectsViewList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.SubjectsViewList.Location = new System.Drawing.Point(26, 50);
            this.SubjectsViewList.Name = "SubjectsViewList";
            this.SubjectsViewList.Size = new System.Drawing.Size(622, 277);
            this.SubjectsViewList.TabIndex = 4;
            this.SubjectsViewList.UseCompatibleStateImageBehavior = false;
            this.SubjectsViewList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SubjectName";
            this.columnHeader5.Width = 167;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Topic";
            this.columnHeader6.Width = 156;
            // 
            // Credits
            // 
            this.Credits.Text = "Credits";
            this.Credits.Width = 135;
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
            this.StudyPlansTab.Controls.Add(this.SkillViewList);
            this.StudyPlansTab.Location = new System.Drawing.Point(4, 22);
            this.StudyPlansTab.Name = "StudyPlansTab";
            this.StudyPlansTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudyPlansTab.Size = new System.Drawing.Size(678, 398);
            this.StudyPlansTab.TabIndex = 2;
            this.StudyPlansTab.Text = "Study Plans";
            this.StudyPlansTab.UseVisualStyleBackColor = true;
            // 
            // SkillViewList
            // 
            this.SkillViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkillViewList.CheckBoxes = true;
            this.SkillViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SubjectName,
            this.columnHeader10,
            this.columnHeader11});
            this.SkillViewList.ContextMenuStrip = this.StudyPlanMenuStrip;
            this.SkillViewList.FullRowSelect = true;
            this.SkillViewList.GridLines = true;
            this.SkillViewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SkillViewList.Location = new System.Drawing.Point(16, 17);
            this.SkillViewList.Name = "SkillViewList";
            this.SkillViewList.Size = new System.Drawing.Size(645, 366);
            this.SkillViewList.TabIndex = 4;
            this.SkillViewList.UseCompatibleStateImageBehavior = false;
            this.SkillViewList.View = System.Windows.Forms.View.Details;
            // 
            // SubjectName
            // 
            this.SubjectName.Text = "Subject name";
            this.SubjectName.Width = 486;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Year";
            this.columnHeader10.Width = 73;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Credits";
            // 
            // StudyPlanMenuStrip
            // 
            this.StudyPlanMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailsToolStripMenuItem,
            this.chooseAlternateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.StudyPlanMenuStrip.Name = "StudyPlanMenuStrip";
            this.StudyPlanMenuStrip.Size = new System.Drawing.Size(166, 70);
            this.StudyPlanMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // chooseAlternateToolStripMenuItem
            // 
            this.chooseAlternateToolStripMenuItem.Name = "chooseAlternateToolStripMenuItem";
            this.chooseAlternateToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chooseAlternateToolStripMenuItem.Text = "Choose Alternate";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // SkillsTab
            // 
            this.SkillsTab.Controls.Add(this.SkillsDescriptionTextBox);
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
            // SkillsDescriptionTextBox
            // 
            this.SkillsDescriptionTextBox.Location = new System.Drawing.Point(118, 162);
            this.SkillsDescriptionTextBox.Multiline = true;
            this.SkillsDescriptionTextBox.Name = "SkillsDescriptionTextBox";
            this.SkillsDescriptionTextBox.Size = new System.Drawing.Size(127, 103);
            this.SkillsDescriptionTextBox.TabIndex = 5;
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
            this.SkillsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Users
            // 
            this.Users.Controls.Add(this.textBox1);
            this.Users.Controls.Add(this.NewUserNameLabel);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(678, 398);
            this.Users.TabIndex = 4;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // NewUserNameLabel
            // 
            this.NewUserNameLabel.AutoSize = true;
            this.NewUserNameLabel.Location = new System.Drawing.Point(35, 51);
            this.NewUserNameLabel.Name = "NewUserNameLabel";
            this.NewUserNameLabel.Size = new System.Drawing.Size(57, 13);
            this.NewUserNameLabel.TabIndex = 0;
            this.NewUserNameLabel.Text = "UserName";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 1;
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
            this.CareerSelectGroupBox.ResumeLayout(false);
            this.CareerSelectGroupBox.PerformLayout();
            this.SkillSelectGroupBox.ResumeLayout(false);
            this.SkillSelectGroupBox.PerformLayout();
            this.NewCareerGroupBox.ResumeLayout(false);
            this.NewCareerGroupBox.PerformLayout();
            this.SubjectsTab.ResumeLayout(false);
            this.SubjectsMenuStrip.ResumeLayout(false);
            this.StudyPlansTab.ResumeLayout(false);
            this.StudyPlanMenuStrip.ResumeLayout(false);
            this.SkillsTab.ResumeLayout(false);
            this.SkillsTab.PerformLayout();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.LogInPanel.ResumeLayout(false);
            this.LogInGroupBox.ResumeLayout(false);
            this.LogInGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tabPage1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView SubjectsViewList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader Credits;
        private System.Windows.Forms.GroupBox SkillSelectGroupBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.GroupBox LogInGroupBox;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.Label NewUserNameLabel;
        private System.Windows.Forms.TextBox textbox1;

        
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
        private void AddSkillToSkillSelect(ISkill skill)
        {
            SkillSelectList.Items.Add(skill);
        }

        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ListView SkillViewList;
        private System.Windows.Forms.ColumnHeader SubjectName;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ContextMenuStrip StudyPlanMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAlternateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SubjectsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.TabPage SkillsTab;
        private System.Windows.Forms.Label SkillLabel;
        private System.Windows.Forms.ComboBox SkillsComboBox;
        private System.Windows.Forms.TextBox SkillsDescriptionTextBox;
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
        private TextBox textBox1;


        public void DisplayErrorMessage()
        {
            MessageBox.Show("Invalid User and password");
        }


        void IMainMenuView.ExitMainMenu()
        {
            MainMenuDisappear();
            LogInPanelAppear();
        }

       
    }
}

