namespace ExaminationSystem
{
    partial class AdminProfile
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
            this.ExamGenerationFormBtn = new System.Windows.Forms.Button();
            this.AssignToExamSession = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.assignInsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExamGenerationFormBtn
            // 
            this.ExamGenerationFormBtn.Location = new System.Drawing.Point(110, 70);
            this.ExamGenerationFormBtn.Name = "ExamGenerationFormBtn";
            this.ExamGenerationFormBtn.Size = new System.Drawing.Size(187, 23);
            this.ExamGenerationFormBtn.TabIndex = 0;
            this.ExamGenerationFormBtn.Text = "Exam Generation";
            this.ExamGenerationFormBtn.UseVisualStyleBackColor = true;
            this.ExamGenerationFormBtn.Click += new System.EventHandler(this.ExamGenerationFormBtn_Click);
            // 
            // AssignToExamSession
            // 
            this.AssignToExamSession.Location = new System.Drawing.Point(110, 218);
            this.AssignToExamSession.Name = "AssignToExamSession";
            this.AssignToExamSession.Size = new System.Drawing.Size(187, 23);
            this.AssignToExamSession.TabIndex = 1;
            this.AssignToExamSession.Text = "Assign Student To ExamSession";
            this.AssignToExamSession.UseVisualStyleBackColor = true;
            this.AssignToExamSession.Click += new System.EventHandler(this.AssignToExamSession_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Course";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Course";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete Course";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // assignInsBtn
            // 
            this.assignInsBtn.Location = new System.Drawing.Point(110, 260);
            this.assignInsBtn.Name = "assignInsBtn";
            this.assignInsBtn.Size = new System.Drawing.Size(187, 23);
            this.assignInsBtn.TabIndex = 6;
            this.assignInsBtn.Text = "Assign Instructor";
            this.assignInsBtn.UseVisualStyleBackColor = true;
            this.assignInsBtn.Click += new System.EventHandler(this.assignInsBtn_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 344);
            this.Controls.Add(this.assignInsBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AssignToExamSession);
            this.Controls.Add(this.ExamGenerationFormBtn);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExamGenerationFormBtn;
        private System.Windows.Forms.Button AssignToExamSession;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button assignInsBtn;
    }
}