namespace ExaminationSystem
{
    partial class Student_TakingExam
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
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.questioncontent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Location = new System.Drawing.Point(38, 78);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(381, 214);
            this.QuestionPanel.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(332, 314);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(242, 314);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(38, 314);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // questioncontent
            // 
            this.questioncontent.AutoSize = true;
            this.questioncontent.Location = new System.Drawing.Point(35, 49);
            this.questioncontent.Name = "questioncontent";
            this.questioncontent.Size = new System.Drawing.Size(35, 13);
            this.questioncontent.TabIndex = 5;
            this.questioncontent.Text = "label1";
            // 
            // Student_TakingExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 365);
            this.Controls.Add(this.questioncontent);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.QuestionPanel);
            this.Name = "Student_TakingExam";
            this.Text = "Student_TakingExam";
            this.Load += new System.EventHandler(this.Student_TakingExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label questioncontent;
    }
}