namespace UitlenenVanFilms
{
    partial class frmUser
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
            this.lblwelkom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstvwFilmsUser = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRent = new System.Windows.Forms.Button();
            this.tabControlHome.SuspendLayout();
            this.home.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRent);
            this.tabPage2.Controls.Add(this.lstvwFilmsUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "overzicht";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstvwFilmsUser
            // 
            this.lstvwFilmsUser.AllowColumnReorder = true;
            this.lstvwFilmsUser.FullRowSelect = true;
            this.lstvwFilmsUser.HideSelection = false;
            this.lstvwFilmsUser.Location = new System.Drawing.Point(7, 6);
            this.lstvwFilmsUser.Name = "lstvwFilmsUser";
            this.lstvwFilmsUser.Size = new System.Drawing.Size(776, 370);
            this.lstvwFilmsUser.TabIndex = 4;
            this.lstvwFilmsUser.UseCompatibleStateImageBehavior = false;
            this.lstvwFilmsUser.SelectedIndexChanged += new System.EventHandler(this.lstvwFilmsAdmin_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvUser);
            this.tabPage3.Controls.Add(this.btnSave);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mijn account";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(7, 23);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(776, 96);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellClick);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            this.dgvUser.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(7, 382);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(106, 35);
            this.btnRent.TabIndex = 5;
            this.btnRent.Text = "Huren";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlHome);
            this.Name = "frmUser";
            this.Text = "Films uitlenen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfilms_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmfilms_FormClosed);
            this.Load += new System.EventHandler(this.frmfilms_Load);
            this.tabControlHome.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblwelkom;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lstvwFilmsUser;
        private System.Windows.Forms.Button btnRent;
    }
}

