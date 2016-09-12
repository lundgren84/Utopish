namespace YtopishWinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCheckLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.txtRRepeatPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.txtRUser = new System.Windows.Forms.TextBox();
            this.btnCheckRegister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNews = new System.Windows.Forms.Label();
            this.panelStart.SuspendLayout();
            this.panelLogIn.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utopish";
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.panelLogIn);
            this.panelStart.Controls.Add(this.panelRegister);
            this.panelStart.Controls.Add(this.btnRegister);
            this.panelStart.Controls.Add(this.btnLogin);
            this.panelStart.Location = new System.Drawing.Point(18, 44);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(1202, 501);
            this.panelStart.TabIndex = 1;
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.label6);
            this.panelLogIn.Controls.Add(this.label3);
            this.panelLogIn.Controls.Add(this.label2);
            this.panelLogIn.Controls.Add(this.txtPassword);
            this.panelLogIn.Controls.Add(this.txtUsername);
            this.panelLogIn.Controls.Add(this.btnCheckLogin);
            this.panelLogIn.Location = new System.Drawing.Point(3, 6);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(609, 495);
            this.panelLogIn.TabIndex = 2;
            this.panelLogIn.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "LOG IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(290, 188);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(290, 105);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // btnCheckLogin
            // 
            this.btnCheckLogin.Location = new System.Drawing.Point(290, 243);
            this.btnCheckLogin.Name = "btnCheckLogin";
            this.btnCheckLogin.Size = new System.Drawing.Size(100, 82);
            this.btnCheckLogin.TabIndex = 0;
            this.btnCheckLogin.Text = "btnCheckLogin";
            this.btnCheckLogin.UseVisualStyleBackColor = true;
            this.btnCheckLogin.Click += new System.EventHandler(this.btnCheckLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(781, 155);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 82);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register New Player";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(273, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 82);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.txtREmail);
            this.panelRegister.Controls.Add(this.txtRRepeatPassword);
            this.panelRegister.Controls.Add(this.label9);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.txtRPassword);
            this.panelRegister.Controls.Add(this.txtRUser);
            this.panelRegister.Controls.Add(this.btnCheckRegister);
            this.panelRegister.Location = new System.Drawing.Point(618, 6);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(581, 495);
            this.panelRegister.TabIndex = 5;
            this.panelRegister.Visible = false;
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(290, 223);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(169, 22);
            this.txtREmail.TabIndex = 9;
            // 
            // txtRRepeatPassword
            // 
            this.txtRRepeatPassword.Location = new System.Drawing.Point(290, 188);
            this.txtRRepeatPassword.Name = "txtRRepeatPassword";
            this.txtRRepeatPassword.Size = new System.Drawing.Size(169, 22);
            this.txtRRepeatPassword.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(213, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(136, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Repeat Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "REGISTER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(186, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(182, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // txtRPassword
            // 
            this.txtRPassword.Location = new System.Drawing.Point(290, 153);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(169, 22);
            this.txtRPassword.TabIndex = 2;
            // 
            // txtRUser
            // 
            this.txtRUser.Location = new System.Drawing.Point(290, 105);
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.Size = new System.Drawing.Size(169, 22);
            this.txtRUser.TabIndex = 1;
            // 
            // btnCheckRegister
            // 
            this.btnCheckRegister.Location = new System.Drawing.Point(290, 261);
            this.btnCheckRegister.Name = "btnCheckRegister";
            this.btnCheckRegister.Size = new System.Drawing.Size(100, 82);
            this.btnCheckRegister.TabIndex = 0;
            this.btnCheckRegister.Text = "Register";
            this.btnCheckRegister.UseVisualStyleBackColor = true;
            this.btnCheckRegister.Click += new System.EventHandler(this.btnCheckRegister_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back to start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNews
            // 
            this.lblNews.AutoSize = true;
            this.lblNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNews.ForeColor = System.Drawing.Color.Transparent;
            this.lblNews.Location = new System.Drawing.Point(484, 9);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(42, 32);
            this.lblNews.TabIndex = 7;
            this.lblNews.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1232, 557);
            this.Controls.Add(this.lblNews);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelStart.ResumeLayout(false);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnCheckLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.TextBox txtREmail;
        private System.Windows.Forms.TextBox txtRRepeatPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRPassword;
        private System.Windows.Forms.TextBox txtRUser;
        private System.Windows.Forms.Button btnCheckRegister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNews;
    }
}

