namespace ExaminationSystem
{
    partial class Teacher_AddQuestion
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
            this.QuestionType = new System.Windows.Forms.ComboBox();
            this.AddQuestionBtn = new System.Windows.Forms.Button();
            this.FinishAddingBtn = new System.Windows.Forms.Button();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionCourse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QuestionType
            // 
            this.QuestionType.FormattingEnabled = true;
            this.QuestionType.Location = new System.Drawing.Point(33, 37);
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.Size = new System.Drawing.Size(225, 21);
            this.QuestionType.TabIndex = 0;
            this.QuestionType.SelectedIndexChanged += new System.EventHandler(this.QuestionType_SelectedIndexChanged);
            // 
            // AddQuestionBtn
            // 
            this.AddQuestionBtn.Location = new System.Drawing.Point(539, 373);
            this.AddQuestionBtn.Name = "AddQuestionBtn";
            this.AddQuestionBtn.Size = new System.Drawing.Size(88, 23);
            this.AddQuestionBtn.TabIndex = 1;
            this.AddQuestionBtn.Text = "Add";
            this.AddQuestionBtn.UseVisualStyleBackColor = true;
            this.AddQuestionBtn.Click += new System.EventHandler(this.AddQuestionBtn_Click);
            // 
            // FinishAddingBtn
            // 
            this.FinishAddingBtn.Location = new System.Drawing.Point(447, 373);
            this.FinishAddingBtn.Name = "FinishAddingBtn";
            this.FinishAddingBtn.Size = new System.Drawing.Size(86, 23);
            this.FinishAddingBtn.TabIndex = 2;
            this.FinishAddingBtn.Text = "Finish";
            this.FinishAddingBtn.UseVisualStyleBackColor = true;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Location = new System.Drawing.Point(33, 110);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(524, 229);
            this.QuestionPanel.TabIndex = 3;
            this.QuestionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // QuestionCourse
            // 
            this.QuestionCourse.FormattingEnabled = true;
            this.QuestionCourse.Location = new System.Drawing.Point(315, 37);
            this.QuestionCourse.Name = "QuestionCourse";
            this.QuestionCourse.Size = new System.Drawing.Size(242, 21);
            this.QuestionCourse.TabIndex = 4;
            // 
            // Teacher_AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 423);
            this.Controls.Add(this.QuestionCourse);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.FinishAddingBtn);
            this.Controls.Add(this.AddQuestionBtn);
            this.Controls.Add(this.QuestionType);
            this.Name = "Teacher_AddQuestion";
            this.Text = "Teacher_AddQuestion";
            this.Load += new System.EventHandler(this.Teacher_AddQuestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox QuestionType;
        private System.Windows.Forms.Button AddQuestionBtn;
        private System.Windows.Forms.Button FinishAddingBtn;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.ComboBox QuestionCourse;
    }
}