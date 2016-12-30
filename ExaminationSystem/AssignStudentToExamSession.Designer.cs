namespace ExaminationSystem
{
    partial class AssignStudentToExamSession
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
            this.button1 = new System.Windows.Forms.Button();
            this.StudentsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamSessionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsComboBox
            // 
            this.StudentsComboBox.FormattingEnabled = true;
            this.StudentsComboBox.Location = new System.Drawing.Point(125, 82);
            this.StudentsComboBox.Name = "StudentsComboBox";
            this.StudentsComboBox.Size = new System.Drawing.Size(183, 21);
            this.StudentsComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Students";
            // 
            // ExamSessionsComboBox
            // 
            this.ExamSessionsComboBox.FormattingEnabled = true;
            this.ExamSessionsComboBox.Location = new System.Drawing.Point(125, 165);
            this.ExamSessionsComboBox.Name = "ExamSessionsComboBox";
            this.ExamSessionsComboBox.Size = new System.Drawing.Size(183, 21);
            this.ExamSessionsComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ExamSessions";
            // 
            // AssignStudentToExamSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExamSessionsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentsComboBox);
            this.Controls.Add(this.button1);
            this.Name = "AssignStudentToExamSession";
            this.Text = "AssignStudentToExamSession";
            this.Load += new System.EventHandler(this.AssignStudentToExamSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox StudentsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ExamSessionsComboBox;
        private System.Windows.Forms.Label label2;
    }
}