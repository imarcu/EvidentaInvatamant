namespace EvidentaInvatamant
{
    partial class SubjectDetails
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.creditsNumeric = new System.Windows.Forms.NumericUpDown();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.courseNumeric = new System.Windows.Forms.NumericUpDown();
            this.seminaryNumeric = new System.Windows.Forms.NumericUpDown();
            this.laboratoryNumeric = new System.Windows.Forms.NumericUpDown();
            this.projectNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.prerequisitesLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.hoursGroupBox = new System.Windows.Forms.GroupBox();
            this.ProjectCheckBox = new System.Windows.Forms.CheckBox();
            this.LaboratoryCheckBox = new System.Windows.Forms.CheckBox();
            this.seminaryCheckBox = new System.Windows.Forms.CheckBox();
            this.CourseCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NewTopicTextBox = new System.Windows.Forms.TextBox();
            this.SkillsListBox = new System.Windows.Forms.CheckedListBox();
            this.PreRequisitesListBox = new System.Windows.Forms.CheckedListBox();
            this.AddNewSkillButton = new System.Windows.Forms.Button();
            this.NameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewSkillOkButton = new System.Windows.Forms.Button();
            this.NewSkillNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.creditsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminaryNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectNumeric)).BeginInit();
            this.hoursGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 41);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(147, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(27, 97);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(34, 13);
            this.topicLabel.TabIndex = 6;
            this.topicLabel.Text = "Topic";
            // 
            // creditsNumeric
            // 
            this.creditsNumeric.Location = new System.Drawing.Point(87, 152);
            this.creditsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditsNumeric.Name = "creditsNumeric";
            this.creditsNumeric.Size = new System.Drawing.Size(33, 20);
            this.creditsNumeric.TabIndex = 8;
            this.creditsNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(27, 157);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(39, 13);
            this.creditsLabel.TabIndex = 9;
            this.creditsLabel.Text = "Credits";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(9, 211);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(206, 13);
            this.skillsLabel.TabIndex = 11;
            this.skillsLabel.Text = "Select the skills this subject aids in forming";
            // 
            // courseNumeric
            // 
            this.courseNumeric.Location = new System.Drawing.Point(141, 44);
            this.courseNumeric.Name = "courseNumeric";
            this.courseNumeric.Size = new System.Drawing.Size(33, 20);
            this.courseNumeric.TabIndex = 14;
            this.courseNumeric.Visible = false;
            // 
            // seminaryNumeric
            // 
            this.seminaryNumeric.Location = new System.Drawing.Point(141, 70);
            this.seminaryNumeric.Name = "seminaryNumeric";
            this.seminaryNumeric.Size = new System.Drawing.Size(33, 20);
            this.seminaryNumeric.TabIndex = 16;
            this.seminaryNumeric.Visible = false;
            // 
            // laboratoryNumeric
            // 
            this.laboratoryNumeric.Location = new System.Drawing.Point(141, 96);
            this.laboratoryNumeric.Name = "laboratoryNumeric";
            this.laboratoryNumeric.Size = new System.Drawing.Size(33, 20);
            this.laboratoryNumeric.TabIndex = 18;
            this.laboratoryNumeric.Visible = false;
            // 
            // projectNumeric
            // 
            this.projectNumeric.Location = new System.Drawing.Point(141, 122);
            this.projectNumeric.Name = "projectNumeric";
            this.projectNumeric.Size = new System.Drawing.Size(33, 20);
            this.projectNumeric.TabIndex = 20;
            this.projectNumeric.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hours/Week";
            // 
            // prerequisitesLabel
            // 
            this.prerequisitesLabel.AutoSize = true;
            this.prerequisitesLabel.Location = new System.Drawing.Point(319, 211);
            this.prerequisitesLabel.Name = "prerequisitesLabel";
            this.prerequisitesLabel.Size = new System.Drawing.Size(194, 13);
            this.prerequisitesLabel.TabIndex = 25;
            this.prerequisitesLabel.Text = "Select the PreRequisites for this subject";
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(465, 444);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(90, 37);
            this.OkButton.TabIndex = 26;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // hoursGroupBox
            // 
            this.hoursGroupBox.Controls.Add(this.ProjectCheckBox);
            this.hoursGroupBox.Controls.Add(this.LaboratoryCheckBox);
            this.hoursGroupBox.Controls.Add(this.seminaryCheckBox);
            this.hoursGroupBox.Controls.Add(this.CourseCheckBox);
            this.hoursGroupBox.Controls.Add(this.courseNumeric);
            this.hoursGroupBox.Controls.Add(this.label9);
            this.hoursGroupBox.Controls.Add(this.seminaryNumeric);
            this.hoursGroupBox.Controls.Add(this.laboratoryNumeric);
            this.hoursGroupBox.Controls.Add(this.projectNumeric);
            this.hoursGroupBox.Location = new System.Drawing.Point(316, 12);
            this.hoursGroupBox.Name = "hoursGroupBox";
            this.hoursGroupBox.Size = new System.Drawing.Size(229, 169);
            this.hoursGroupBox.TabIndex = 27;
            this.hoursGroupBox.TabStop = false;
            this.hoursGroupBox.Text = "Hours Information";
            // 
            // ProjectCheckBox
            // 
            this.ProjectCheckBox.AutoSize = true;
            this.ProjectCheckBox.Location = new System.Drawing.Point(36, 123);
            this.ProjectCheckBox.Name = "ProjectCheckBox";
            this.ProjectCheckBox.Size = new System.Drawing.Size(59, 17);
            this.ProjectCheckBox.TabIndex = 26;
            this.ProjectCheckBox.Text = "Project";
            this.ProjectCheckBox.UseVisualStyleBackColor = true;
            this.ProjectCheckBox.CheckedChanged += new System.EventHandler(this.ProjectCheckBox_CheckedChanged);
            // 
            // LaboratoryCheckBox
            // 
            this.LaboratoryCheckBox.AutoSize = true;
            this.LaboratoryCheckBox.Location = new System.Drawing.Point(36, 97);
            this.LaboratoryCheckBox.Name = "LaboratoryCheckBox";
            this.LaboratoryCheckBox.Size = new System.Drawing.Size(76, 17);
            this.LaboratoryCheckBox.TabIndex = 25;
            this.LaboratoryCheckBox.Text = "Laboratory";
            this.LaboratoryCheckBox.UseVisualStyleBackColor = true;
            this.LaboratoryCheckBox.CheckedChanged += new System.EventHandler(this.LaboratoryCheckBox_CheckedChanged);
            // 
            // seminaryCheckBox
            // 
            this.seminaryCheckBox.AutoSize = true;
            this.seminaryCheckBox.Location = new System.Drawing.Point(36, 71);
            this.seminaryCheckBox.Name = "seminaryCheckBox";
            this.seminaryCheckBox.Size = new System.Drawing.Size(69, 17);
            this.seminaryCheckBox.TabIndex = 24;
            this.seminaryCheckBox.Text = "Seminary";
            this.seminaryCheckBox.UseVisualStyleBackColor = true;
            this.seminaryCheckBox.CheckedChanged += new System.EventHandler(this.seminaryCheckBox_CheckedChanged);
            // 
            // CourseCheckBox
            // 
            this.CourseCheckBox.AutoSize = true;
            this.CourseCheckBox.Location = new System.Drawing.Point(36, 45);
            this.CourseCheckBox.Name = "CourseCheckBox";
            this.CourseCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CourseCheckBox.TabIndex = 23;
            this.CourseCheckBox.Text = "Course";
            this.CourseCheckBox.UseVisualStyleBackColor = true;
            this.CourseCheckBox.CheckedChanged += new System.EventHandler(this.CourseCheckBox_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewTopicTextBox
            // 
            this.NewTopicTextBox.Location = new System.Drawing.Point(87, 94);
            this.NewTopicTextBox.Name = "NewTopicTextBox";
            this.NewTopicTextBox.Size = new System.Drawing.Size(147, 20);
            this.NewTopicTextBox.TabIndex = 30;
            // 
            // SkillsListBox
            // 
            this.SkillsListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SkillsListBox.CheckOnClick = true;
            this.SkillsListBox.FormattingEnabled = true;
            this.SkillsListBox.Location = new System.Drawing.Point(12, 241);
            this.SkillsListBox.Name = "SkillsListBox";
            this.SkillsListBox.Size = new System.Drawing.Size(244, 169);
            this.SkillsListBox.TabIndex = 31;
            // 
            // PreRequisitesListBox
            // 
            this.PreRequisitesListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.PreRequisitesListBox.CheckOnClick = true;
            this.PreRequisitesListBox.FormattingEnabled = true;
            this.PreRequisitesListBox.Location = new System.Drawing.Point(316, 241);
            this.PreRequisitesListBox.Name = "PreRequisitesListBox";
            this.PreRequisitesListBox.Size = new System.Drawing.Size(239, 169);
            this.PreRequisitesListBox.TabIndex = 32;
            // 
            // AddNewSkillButton
            // 
            this.AddNewSkillButton.Location = new System.Drawing.Point(12, 420);
            this.AddNewSkillButton.Name = "AddNewSkillButton";
            this.AddNewSkillButton.Size = new System.Drawing.Size(147, 23);
            this.AddNewSkillButton.TabIndex = 33;
            this.AddNewSkillButton.Text = "Add New Skill";
            this.AddNewSkillButton.UseVisualStyleBackColor = true;
            this.AddNewSkillButton.Click += new System.EventHandler(this.AddNewSkill_Click);
            // 
            // NameToolTip
            // 
            this.NameToolTip.ToolTipTitle = "NameToolTip";
            // 
            // NewSkillOkButton
            // 
            this.NewSkillOkButton.Location = new System.Drawing.Point(169, 459);
            this.NewSkillOkButton.Name = "NewSkillOkButton";
            this.NewSkillOkButton.Size = new System.Drawing.Size(32, 23);
            this.NewSkillOkButton.TabIndex = 36;
            this.NewSkillOkButton.Text = "OK";
            this.NewSkillOkButton.UseVisualStyleBackColor = true;
            this.NewSkillOkButton.Visible = false;
            this.NewSkillOkButton.Click += new System.EventHandler(this.NewSkillOkButton_Click);
            // 
            // NewSkillNameTextBox
            // 
            this.NewSkillNameTextBox.Location = new System.Drawing.Point(12, 459);
            this.NewSkillNameTextBox.Name = "NewSkillNameTextBox";
            this.NewSkillNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.NewSkillNameTextBox.TabIndex = 35;
            this.NewSkillNameTextBox.Visible = false;
            // 
            // SubjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 493);
            this.Controls.Add(this.NewSkillOkButton);
            this.Controls.Add(this.NewSkillNameTextBox);
            this.Controls.Add(this.AddNewSkillButton);
            this.Controls.Add(this.PreRequisitesListBox);
            this.Controls.Add(this.SkillsListBox);
            this.Controls.Add(this.hoursGroupBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.prerequisitesLabel);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditsNumeric);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.NewTopicTextBox);
            this.Name = "SubjectDetails";
            this.Text = "Subject Details";
            ((System.ComponentModel.ISupportInitialize)(this.creditsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminaryNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratoryNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectNumeric)).EndInit();
            this.hoursGroupBox.ResumeLayout(false);
            this.hoursGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.NumericUpDown creditsNumeric;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.NumericUpDown courseNumeric;
        private System.Windows.Forms.NumericUpDown seminaryNumeric;
        private System.Windows.Forms.NumericUpDown laboratoryNumeric;
        private System.Windows.Forms.NumericUpDown projectNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label prerequisitesLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox hoursGroupBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button AddNewSkillButton;
        private System.Windows.Forms.CheckedListBox PreRequisitesListBox;
        private System.Windows.Forms.CheckedListBox SkillsListBox;
        private System.Windows.Forms.TextBox NewTopicTextBox;
        private System.Windows.Forms.CheckBox ProjectCheckBox;
        private System.Windows.Forms.CheckBox LaboratoryCheckBox;
        private System.Windows.Forms.CheckBox seminaryCheckBox;
        private System.Windows.Forms.CheckBox CourseCheckBox;
        private System.Windows.Forms.ToolTip NameToolTip;
        private System.Windows.Forms.Button NewSkillOkButton;
        private System.Windows.Forms.TextBox NewSkillNameTextBox;
    }
}