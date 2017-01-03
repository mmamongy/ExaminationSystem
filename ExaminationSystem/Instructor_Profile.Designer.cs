namespace ExaminationSystem
{
    partial class Instructor_Profile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.question_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddQuestionBtn = new System.Windows.Forms.Button();
            this.ViewExamBtn = new System.Windows.Forms.Button();
            this.examsCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.question_type,
            this.questionContent});
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 234);
            this.dataGridView1.TabIndex = 1;
            // 
            // question_type
            // 
            this.question_type.HeaderText = "Type";
            this.question_type.Name = "question_type";
            // 
            // questionContent
            // 
            this.questionContent.HeaderText = "Question";
            this.questionContent.Name = "questionContent";
            // 
            // AddQuestionBtn
            // 
            this.AddQuestionBtn.Location = new System.Drawing.Point(380, 336);
            this.AddQuestionBtn.Name = "AddQuestionBtn";
            this.AddQuestionBtn.Size = new System.Drawing.Size(157, 23);
            this.AddQuestionBtn.TabIndex = 2;
            this.AddQuestionBtn.Text = "Add Question In Course";
            this.AddQuestionBtn.UseVisualStyleBackColor = true;
            this.AddQuestionBtn.Click += new System.EventHandler(this.AddQuestionBtn_Click);
            // 
            // ViewExamBtn
            // 
            this.ViewExamBtn.Location = new System.Drawing.Point(442, 31);
            this.ViewExamBtn.Name = "ViewExamBtn";
            this.ViewExamBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewExamBtn.TabIndex = 3;
            this.ViewExamBtn.Text = "View Exam";
            this.ViewExamBtn.UseVisualStyleBackColor = true;
            this.ViewExamBtn.Click += new System.EventHandler(this.ViewExamBtn_Click);
            // 
            // examsCombobox
            // 
            this.examsCombobox.FormattingEnabled = true;
            this.examsCombobox.Location = new System.Drawing.Point(13, 31);
            this.examsCombobox.Name = "examsCombobox";
            this.examsCombobox.Size = new System.Drawing.Size(368, 21);
            this.examsCombobox.TabIndex = 4;
            // 
            // Instructor_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 381);
            this.Controls.Add(this.examsCombobox);
            this.Controls.Add(this.ViewExamBtn);
            this.Controls.Add(this.AddQuestionBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Instructor_Profile";
            this.Text = "Instructor_Profile";
            this.Load += new System.EventHandler(this.Instructor_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionContent;
        private System.Windows.Forms.Button AddQuestionBtn;
        private System.Windows.Forms.Button ViewExamBtn;
        private System.Windows.Forms.ComboBox examsCombobox;

    }
}