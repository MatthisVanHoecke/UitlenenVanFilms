namespace UitlenenVanFilms
{
    partial class frmlog
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
            this.tabControlStart = new System.Windows.Forms.TabControl();
            this.tabInloggen = new System.Windows.Forms.TabPage();
            this.lblLogPasswordError = new System.Windows.Forms.Label();
            this.lblLogUserError = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.tabRegistreren = new System.Windows.Forms.TabPage();
            this.lblConfirmPasswordError = new System.Windows.Forms.Label();
            this.lblCreatePasswordError = new System.Windows.Forms.Label();
            this.lblCreateEmailError = new System.Windows.Forms.Label();
            this.lblCreateUserError = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblCreateEmail = new System.Windows.Forms.Label();
            this.txtCreateEmail = new System.Windows.Forms.TextBox();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.lblCreateUser = new System.Windows.Forms.Label();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.tabControlStart.SuspendLayout();
            this.tabInloggen.SuspendLayout();
            this.tabRegistreren.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStart
            // 
            this.tabControlStart.Controls.Add(this.tabInloggen);
            this.tabControlStart.Controls.Add(this.tabRegistreren);
            this.tabControlStart.Location = new System.Drawing.Point(-2, -2);
            this.tabControlStart.Name = "tabControlStart";
            this.tabControlStart.SelectedIndex = 0;
            this.tabControlStart.Size = new System.Drawing.Size(803, 453);
            this.tabControlStart.TabIndex = 1;
            // 
            // tabInloggen
            // 
            this.tabInloggen.Controls.Add(this.lblLogPasswordError);
            this.tabInloggen.Controls.Add(this.lblLogUserError);
            this.tabInloggen.Controls.Add(this.btnInloggen);
            this.tabInloggen.Controls.Add(this.lblpassword);
            this.tabInloggen.Controls.Add(this.txtPasswordLogin);
            this.tabInloggen.Controls.Add(this.lblusername);
            this.tabInloggen.Controls.Add(this.txtUserLogin);
            this.tabInloggen.Location = new System.Drawing.Point(4, 22);
            this.tabInloggen.Name = "tabInloggen";
            this.tabInloggen.Padding = new System.Windows.Forms.Padding(3);
            this.tabInloggen.Size = new System.Drawing.Size(795, 427);
            this.tabInloggen.TabIndex = 0;
            this.tabInloggen.Text = "Inloggen";
            this.tabInloggen.UseVisualStyleBackColor = true;
            // 
            // lblLogPasswordError
            // 
            this.lblLogPasswordError.AutoSize = true;
            this.lblLogPasswordError.Location = new System.Drawing.Point(500, 157);
            this.lblLogPasswordError.Name = "lblLogPasswordError";
            this.lblLogPasswordError.Size = new System.Drawing.Size(0, 13);
            this.lblLogPasswordError.TabIndex = 6;
            // 
            // lblLogUserError
            // 
            this.lblLogUserError.AutoSize = true;
            this.lblLogUserError.Location = new System.Drawing.Point(500, 131);
            this.lblLogUserError.Name = "lblLogUserError";
            this.lblLogUserError.Size = new System.Drawing.Size(0, 13);
            this.lblLogUserError.TabIndex = 5;
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(317, 180);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(177, 23);
            this.btnInloggen.TabIndex = 4;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.BtnInloggen_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(240, 157);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(71, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Wachtwoord:";
            this.lblpassword.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(317, 154);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '●';
            this.txtPasswordLogin.Size = new System.Drawing.Size(177, 20);
            this.txtPasswordLogin.TabIndex = 2;
            this.txtPasswordLogin.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(213, 131);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(98, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "Usernaam of Email:";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(317, 128);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(177, 20);
            this.txtUserLogin.TabIndex = 0;
            this.txtUserLogin.TextChanged += new System.EventHandler(this.TxtUserLogin_TextChanged);
            // 
            // tabRegistreren
            // 
            this.tabRegistreren.Controls.Add(this.lblConfirmPasswordError);
            this.tabRegistreren.Controls.Add(this.lblCreatePasswordError);
            this.tabRegistreren.Controls.Add(this.lblCreateEmailError);
            this.tabRegistreren.Controls.Add(this.lblCreateUserError);
            this.tabRegistreren.Controls.Add(this.lblConfirmPassword);
            this.tabRegistreren.Controls.Add(this.txtConfirmPassword);
            this.tabRegistreren.Controls.Add(this.lblCreateEmail);
            this.tabRegistreren.Controls.Add(this.txtCreateEmail);
            this.tabRegistreren.Controls.Add(this.btnRegistreren);
            this.tabRegistreren.Controls.Add(this.lblCreatePassword);
            this.tabRegistreren.Controls.Add(this.txtCreatePassword);
            this.tabRegistreren.Controls.Add(this.lblCreateUser);
            this.tabRegistreren.Controls.Add(this.txtCreateUser);
            this.tabRegistreren.Location = new System.Drawing.Point(4, 22);
            this.tabRegistreren.Name = "tabRegistreren";
            this.tabRegistreren.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistreren.Size = new System.Drawing.Size(795, 427);
            this.tabRegistreren.TabIndex = 1;
            this.tabRegistreren.Text = "Registreren";
            this.tabRegistreren.UseVisualStyleBackColor = true;
            this.tabRegistreren.Click += new System.EventHandler(this.TabRegistreren_Click);
            // 
            // lblConfirmPasswordError
            // 
            this.lblConfirmPasswordError.AutoSize = true;
            this.lblConfirmPasswordError.Location = new System.Drawing.Point(497, 188);
            this.lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            this.lblConfirmPasswordError.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmPasswordError.TabIndex = 17;
            // 
            // lblCreatePasswordError
            // 
            this.lblCreatePasswordError.AutoSize = true;
            this.lblCreatePasswordError.Location = new System.Drawing.Point(497, 162);
            this.lblCreatePasswordError.Name = "lblCreatePasswordError";
            this.lblCreatePasswordError.Size = new System.Drawing.Size(0, 13);
            this.lblCreatePasswordError.TabIndex = 16;
            // 
            // lblCreateEmailError
            // 
            this.lblCreateEmailError.AutoSize = true;
            this.lblCreateEmailError.Location = new System.Drawing.Point(497, 136);
            this.lblCreateEmailError.Name = "lblCreateEmailError";
            this.lblCreateEmailError.Size = new System.Drawing.Size(0, 13);
            this.lblCreateEmailError.TabIndex = 15;
            // 
            // lblCreateUserError
            // 
            this.lblCreateUserError.AutoSize = true;
            this.lblCreateUserError.Location = new System.Drawing.Point(497, 110);
            this.lblCreateUserError.Name = "lblCreateUserError";
            this.lblCreateUserError.Size = new System.Drawing.Size(0, 13);
            this.lblCreateUserError.TabIndex = 14;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(214, 188);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 13;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(314, 185);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(177, 20);
            this.txtConfirmPassword.TabIndex = 12;
            // 
            // lblCreateEmail
            // 
            this.lblCreateEmail.AutoSize = true;
            this.lblCreateEmail.Location = new System.Drawing.Point(273, 136);
            this.lblCreateEmail.Name = "lblCreateEmail";
            this.lblCreateEmail.Size = new System.Drawing.Size(35, 13);
            this.lblCreateEmail.TabIndex = 11;
            this.lblCreateEmail.Text = "Email:";
            // 
            // txtCreateEmail
            // 
            this.txtCreateEmail.Location = new System.Drawing.Point(314, 133);
            this.txtCreateEmail.Name = "txtCreateEmail";
            this.txtCreateEmail.Size = new System.Drawing.Size(177, 20);
            this.txtCreateEmail.TabIndex = 10;
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(314, 211);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(177, 23);
            this.btnRegistreren.TabIndex = 9;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.BtnRegistreren_Click);
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(252, 162);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(56, 13);
            this.lblCreatePassword.TabIndex = 8;
            this.lblCreatePassword.Text = "Password:";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(314, 159);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(177, 20);
            this.txtCreatePassword.TabIndex = 7;
            // 
            // lblCreateUser
            // 
            this.lblCreateUser.AutoSize = true;
            this.lblCreateUser.Location = new System.Drawing.Point(250, 110);
            this.lblCreateUser.Name = "lblCreateUser";
            this.lblCreateUser.Size = new System.Drawing.Size(58, 13);
            this.lblCreateUser.TabIndex = 6;
            this.lblCreateUser.Text = "Username:";
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(314, 107);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(177, 20);
            this.txtCreateUser.TabIndex = 5;
            this.txtCreateUser.TextChanged += new System.EventHandler(this.TxtCreateUser_TextChanged);
            // 
            // frmlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlStart);
            this.KeyPreview = true;
            this.Name = "frmlog";
            this.Text = "Films uitlenen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmlog_FormClosed);
            this.Load += new System.EventHandler(this.Frmlog_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmlog_KeyUp);
            this.tabControlStart.ResumeLayout(false);
            this.tabInloggen.ResumeLayout(false);
            this.tabInloggen.PerformLayout();
            this.tabRegistreren.ResumeLayout(false);
            this.tabRegistreren.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStart;
        private System.Windows.Forms.TabPage tabInloggen;
        private System.Windows.Forms.TabPage tabRegistreren;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblCreateEmail;
        private System.Windows.Forms.TextBox txtCreateEmail;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Label lblCreateUser;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.Label lblCreatePasswordError;
        private System.Windows.Forms.Label lblCreateEmailError;
        private System.Windows.Forms.Label lblCreateUserError;
        private System.Windows.Forms.Label lblLogPasswordError;
        private System.Windows.Forms.Label lblLogUserError;
    }
}

