namespace ExaminationSystem
{
    partial class Login
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
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studRadBtn = new System.Windows.Forms.RadioButton();
            this.adminRadBtn = new System.Windows.Forms.RadioButton();
            this.insRadBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userNameRegTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.departmentsCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameRegTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PassRegTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.userNameAdminRegTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.emailAdminRegTextBox = new System.Windows.Forms.TextBox();
            this.nameAdminRegTextBox = new System.Windows.Forms.TextBox();
            this.AdminRegisterBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.passAdminRegTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(72, 19);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(72, 56);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(142, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(16, 193);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(187, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(9, 341);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(225, 23);
            this.RegisterBtn.TabIndex = 3;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.UserNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LoginBtn);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 225);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studRadBtn);
            this.groupBox3.Controls.Add(this.adminRadBtn);
            this.groupBox3.Controls.Add(this.insRadBtn);
            this.groupBox3.Location = new System.Drawing.Point(16, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 91);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose your role";
            // 
            // studRadBtn
            // 
            this.studRadBtn.AutoSize = true;
            this.studRadBtn.Location = new System.Drawing.Point(54, 62);
            this.studRadBtn.Name = "studRadBtn";
            this.studRadBtn.Size = new System.Drawing.Size(62, 17);
            this.studRadBtn.TabIndex = 9;
            this.studRadBtn.TabStop = true;
            this.studRadBtn.Text = "Student";
            this.studRadBtn.UseVisualStyleBackColor = true;
            // 
            // adminRadBtn
            // 
            this.adminRadBtn.AutoSize = true;
            this.adminRadBtn.Location = new System.Drawing.Point(21, 26);
            this.adminRadBtn.Name = "adminRadBtn";
            this.adminRadBtn.Size = new System.Drawing.Size(54, 17);
            this.adminRadBtn.TabIndex = 7;
            this.adminRadBtn.TabStop = true;
            this.adminRadBtn.Text = "Admin";
            this.adminRadBtn.UseVisualStyleBackColor = true;
            // 
            // insRadBtn
            // 
            this.insRadBtn.AutoSize = true;
            this.insRadBtn.Location = new System.Drawing.Point(103, 26);
            this.insRadBtn.Name = "insRadBtn";
            this.insRadBtn.Size = new System.Drawing.Size(69, 17);
            this.insRadBtn.TabIndex = 8;
            this.insRadBtn.TabStop = true;
            this.insRadBtn.Text = "Instructor";
            this.insRadBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.userNameRegTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.departmentsCombo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.EmailTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PhoneTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AddressTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AgeTextBox);
            this.groupBox2.Controls.Add(this.NameRegTextBox);
            this.groupBox2.Controls.Add(this.RegisterBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PassRegTextBox);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 417);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "User Name";
            // 
            // userNameRegTextBox
            // 
            this.userNameRegTextBox.Location = new System.Drawing.Point(71, 66);
            this.userNameRegTextBox.Name = "userNameRegTextBox";
            this.userNameRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.userNameRegTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Department";
            // 
            // departmentsCombo
            // 
            this.departmentsCombo.FormattingEnabled = true;
            this.departmentsCombo.Location = new System.Drawing.Point(69, 285);
            this.departmentsCombo.Name = "departmentsCombo";
            this.departmentsCombo.Size = new System.Drawing.Size(143, 21);
            this.departmentsCombo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(70, 212);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(142, 20);
            this.EmailTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(70, 175);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.PhoneTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(70, 139);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(142, 20);
            this.AddressTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(70, 104);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(142, 20);
            this.AgeTextBox.TabIndex = 7;
            // 
            // NameRegTextBox
            // 
            this.NameRegTextBox.Location = new System.Drawing.Point(70, 29);
            this.NameRegTextBox.Name = "NameRegTextBox";
            this.NameRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.NameRegTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // PassRegTextBox
            // 
            this.PassRegTextBox.Location = new System.Drawing.Point(70, 249);
            this.PassRegTextBox.Name = "PassRegTextBox";
            this.PassRegTextBox.PasswordChar = '*';
            this.PassRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.PassRegTextBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.userNameAdminRegTextBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.emailAdminRegTextBox);
            this.groupBox4.Controls.Add(this.nameAdminRegTextBox);
            this.groupBox4.Controls.Add(this.AdminRegisterBtn);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.passAdminRegTextBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 208);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Admin Register";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "User Name";
            // 
            // userNameAdminRegTextBox
            // 
            this.userNameAdminRegTextBox.Location = new System.Drawing.Point(71, 66);
            this.userNameAdminRegTextBox.Name = "userNameAdminRegTextBox";
            this.userNameAdminRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.userNameAdminRegTextBox.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Email";
            // 
            // emailAdminRegTextBox
            // 
            this.emailAdminRegTextBox.Location = new System.Drawing.Point(71, 104);
            this.emailAdminRegTextBox.Name = "emailAdminRegTextBox";
            this.emailAdminRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.emailAdminRegTextBox.TabIndex = 13;
            // 
            // nameAdminRegTextBox
            // 
            this.nameAdminRegTextBox.Location = new System.Drawing.Point(70, 29);
            this.nameAdminRegTextBox.Name = "nameAdminRegTextBox";
            this.nameAdminRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.nameAdminRegTextBox.TabIndex = 0;
            // 
            // AdminRegisterBtn
            // 
            this.AdminRegisterBtn.Location = new System.Drawing.Point(9, 173);
            this.AdminRegisterBtn.Name = "AdminRegisterBtn";
            this.AdminRegisterBtn.Size = new System.Drawing.Size(204, 23);
            this.AdminRegisterBtn.TabIndex = 3;
            this.AdminRegisterBtn.Text = "Register";
            this.AdminRegisterBtn.UseVisualStyleBackColor = true;
            this.AdminRegisterBtn.Click += new System.EventHandler(this.AdminRegisterBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Password";
            // 
            // passAdminRegTextBox
            // 
            this.passAdminRegTextBox.Location = new System.Drawing.Point(71, 139);
            this.passAdminRegTextBox.Name = "passAdminRegTextBox";
            this.passAdminRegTextBox.PasswordChar = '*';
            this.passAdminRegTextBox.Size = new System.Drawing.Size(142, 20);
            this.passAdminRegTextBox.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameRegTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassRegTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton adminRadBtn;
        private System.Windows.Forms.RadioButton insRadBtn;
        private System.Windows.Forms.RadioButton studRadBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox departmentsCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userNameRegTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userNameAdminRegTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox emailAdminRegTextBox;
        private System.Windows.Forms.TextBox nameAdminRegTextBox;
        private System.Windows.Forms.Button AdminRegisterBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox passAdminRegTextBox;
    }
}