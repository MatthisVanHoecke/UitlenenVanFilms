namespace safe
{
    partial class frmfilms
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
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblwelkom = new System.Windows.Forms.Label();
            this.tabControlHome.SuspendLayout();
            this.home.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.home);
            this.tabControlHome.Controls.Add(this.tabPage2);
            this.tabControlHome.Controls.Add(this.tabPage3);
            this.tabControlHome.Controls.Add(this.tabPage1);
            this.tabControlHome.Location = new System.Drawing.Point(1, -1);
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(798, 452);
            this.tabControlHome.TabIndex = 1;
            // 
            // home
            // 
            this.home.Controls.Add(this.lblwelkom);
            this.home.Location = new System.Drawing.Point(4, 22);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(790, 426);
            this.home.TabIndex = 0;
            this.home.Text = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mijn account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 426);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "instellingen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblwelkom
            // 
            this.lblwelkom.AutoSize = true;
            this.lblwelkom.Location = new System.Drawing.Point(654, 3);
            this.lblwelkom.Name = "lblwelkom";
            this.lblwelkom.Size = new System.Drawing.Size(35, 13);
            this.lblwelkom.TabIndex = 0;
            this.lblwelkom.Text = "label1";
            this.lblwelkom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmfilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHome);
            this.Name = "frmfilms";
            this.Text = "Films uitlenen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfilms_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmfilms_FormClosed);
            this.Load += new System.EventHandler(this.frmfilms_Load);
            this.tabControlHome.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblwelkom;
    }
}

