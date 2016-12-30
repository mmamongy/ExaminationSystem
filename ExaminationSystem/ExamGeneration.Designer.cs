namespace ExaminationSystem
{
    partial class ExamGeneration
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
            this.GenerateExamBtn = new System.Windows.Forms.Button();
            this.NumOfMCQTextBox = new System.Windows.Forms.TextBox();
            this.NumOfTFTextBox = new System.Windows.Forms.TextBox();
            this.NumOfEssayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TFnumLabel = new System.Windows.Forms.Label();
            this.EssaynumLabel = new System.Windows.Forms.Label();
            this.MCQnumLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CourseNameComboBox = new System.Windows.Forms.ComboBox();
            this.sessionsComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createExamSessionBtn = new System.Windows.Forms.Button();
            this.ExamsComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AssignSessionForCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateExamBtn
            // 
            this.GenerateExamBtn.Location = new System.Drawing.Point(24, 250);
            this.GenerateExamBtn.Name = "GenerateExamBtn";
            this.GenerateExamBtn.Size = new System.Drawing.Size(232, 23);
            this.GenerateExamBtn.TabIndex = 0;
            this.GenerateExamBtn.Text = "Generate Exam";
            this.GenerateExamBtn.UseVisualStyleBackColor = true;
            this.GenerateExamBtn.Click += new System.EventHandler(this.GenerateExamBtn_Click);
            // 
            // NumOfMCQTextBox
            // 
            this.NumOfMCQTextBox.Location = new System.Drawing.Point(88, 58);
            this.NumOfMCQTextBox.Name = "NumOfMCQTextBox";
            this.NumOfMCQTextBox.Size = new System.Drawing.Size(168, 20);
            this.NumOfMCQTextBox.TabIndex = 1;
            // 
            // NumOfTFTextBox
            // 
            this.NumOfTFTextBox.Location = new System.Drawing.Point(88, 104);
            this.NumOfTFTextBox.Name = "NumOfTFTextBox";
            this.NumOfTFTextBox.Size = new System.Drawing.Size(168, 20);
            this.NumOfTFTextBox.TabIndex = 2;
            // 
            // NumOfEssayTextBox
            // 
            this.NumOfEssayTextBox.Location = new System.Drawing.Point(88, 154);
            this.NumOfEssayTextBox.Name = "NumOfEssayTextBox";
            this.NumOfEssayTextBox.Size = new System.Drawing.Size(168, 20);
            this.NumOfEssayTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MCQ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Essay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Nubmber Of Qustions From Each Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Available Nubmber Of Qustions From Each Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // TFnumLabel
            // 
            this.TFnumLabel.AutoSize = true;
            this.TFnumLabel.Location = new System.Drawing.Point(355, 107);
            this.TFnumLabel.Name = "TFnumLabel";
            this.TFnumLabel.Size = new System.Drawing.Size(74, 13);
            this.TFnumLabel.TabIndex = 10;
            this.TFnumLabel.Text = "Number Of TF";
            // 
            // EssaynumLabel
            // 
            this.EssaynumLabel.AutoSize = true;
            this.EssaynumLabel.Location = new System.Drawing.Point(355, 157);
            this.EssaynumLabel.Name = "EssaynumLabel";
            this.EssaynumLabel.Size = new System.Drawing.Size(89, 13);
            this.EssaynumLabel.TabIndex = 11;
            this.EssaynumLabel.Text = "Number Of Essay";
            // 
            // MCQnumLabel
            // 
            this.MCQnumLabel.AutoSize = true;
            this.MCQnumLabel.Location = new System.Drawing.Point(355, 61);
            this.MCQnumLabel.Name = "MCQnumLabel";
            this.MCQnumLabel.Size = new System.Drawing.Size(85, 13);
            this.MCQnumLabel.TabIndex = 12;
            this.MCQnumLabel.Text = "Number Of MCQ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Course";
            // 
            // CourseNameComboBox
            // 
            this.CourseNameComboBox.FormattingEnabled = true;
            this.CourseNameComboBox.Location = new System.Drawing.Point(88, 204);
            this.CourseNameComboBox.Name = "CourseNameComboBox";
            this.CourseNameComboBox.Size = new System.Drawing.Size(168, 21);
            this.CourseNameComboBox.TabIndex = 16;
            // 
            // sessionsComboBox
            // 
            this.sessionsComboBox.FormattingEnabled = true;
            this.sessionsComboBox.Location = new System.Drawing.Point(340, 303);
            this.sessionsComboBox.Name = "sessionsComboBox";
            this.sessionsComboBox.Size = new System.Drawing.Size(168, 21);
            this.sessionsComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Exam Session";
            // 
            // createExamSessionBtn
            // 
            this.createExamSessionBtn.Location = new System.Drawing.Point(264, 250);
            this.createExamSessionBtn.Name = "createExamSessionBtn";
            this.createExamSessionBtn.Size = new System.Drawing.Size(244, 23);
            this.createExamSessionBtn.TabIndex = 19;
            this.createExamSessionBtn.Text = "Create Session";
            this.createExamSessionBtn.UseVisualStyleBackColor = true;
            this.createExamSessionBtn.Click += new System.EventHandler(this.createExamSessionBtn_Click);
            // 
            // ExamsComboBox
            // 
            this.ExamsComboBox.FormattingEnabled = true;
            this.ExamsComboBox.Location = new System.Drawing.Point(340, 199);
            this.ExamsComboBox.Name = "ExamsComboBox";
            this.ExamsComboBox.Size = new System.Drawing.Size(168, 21);
            this.ExamsComboBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Exams";
            // 
            // AssignSessionForCourseBtn
            // 
            this.AssignSessionForCourseBtn.Location = new System.Drawing.Point(24, 301);
            this.AssignSessionForCourseBtn.Name = "AssignSessionForCourseBtn";
            this.AssignSessionForCourseBtn.Size = new System.Drawing.Size(232, 23);
            this.AssignSessionForCourseBtn.TabIndex = 22;
            this.AssignSessionForCourseBtn.Text = "Assign ExamSession For Course";
            this.AssignSessionForCourseBtn.UseVisualStyleBackColor = true;
            this.AssignSessionForCourseBtn.Click += new System.EventHandler(this.AssignSessionForCourseBtn_Click);
            // 
            // ExamGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 364);
            this.Controls.Add(this.AssignSessionForCourseBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExamsComboBox);
            this.Controls.Add(this.createExamSessionBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sessionsComboBox);
            this.Controls.Add(this.CourseNameComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MCQnumLabel);
            this.Controls.Add(this.EssaynumLabel);
            this.Controls.Add(this.TFnumLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfEssayTextBox);
            this.Controls.Add(this.NumOfTFTextBox);
            this.Controls.Add(this.NumOfMCQTextBox);
            this.Controls.Add(this.GenerateExamBtn);
            this.Name = "ExamGeneration";
            this.Text = "ExamGeneration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateExamBtn;
        private System.Windows.Forms.TextBox NumOfMCQTextBox;
        private System.Windows.Forms.TextBox NumOfTFTextBox;
        private System.Windows.Forms.TextBox NumOfEssayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TFnumLabel;
        private System.Windows.Forms.Label EssaynumLabel;
        private System.Windows.Forms.Label MCQnumLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CourseNameComboBox;
        private System.Windows.Forms.ComboBox sessionsComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createExamSessionBtn;
        private System.Windows.Forms.ComboBox ExamsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AssignSessionForCourseBtn;
    }
}