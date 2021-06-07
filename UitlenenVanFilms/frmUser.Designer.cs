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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblwelkom = new System.Windows.Forms.Label();
            this.tabOverzicht = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFilmLenen = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.lstvwFilmsUser = new System.Windows.Forms.ListView();
            this.tabOntleendeFilms = new System.Windows.Forms.TabPage();
            this.lstvwOntleendeFilms = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabOverzicht.SuspendLayout();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFilmLenen.SuspendLayout();
            this.tabOntleendeFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabOverzicht);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(1, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(798, 498);
            this.tabControl.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblwelkom);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(790, 472);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "home";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Click += new System.EventHandler(this.home_Click);
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
            // tabOverzicht
            // 
            this.tabOverzicht.Controls.Add(this.tabControl1);
            this.tabOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tabOverzicht.Name = "tabOverzicht";
            this.tabOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverzicht.Size = new System.Drawing.Size(790, 472);
            this.tabOverzicht.TabIndex = 1;
            this.tabOverzicht.Text = "overzicht";
            this.tabOverzicht.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.dgvUser);
            this.tabAccount.Controls.Add(this.btnSave);
            this.tabAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(790, 472);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "Mijn account";
            this.tabAccount.UseVisualStyleBackColor = true;
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
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(790, 472);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "instellingen";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFilmLenen);
            this.tabControl1.Controls.Add(this.tabOntleendeFilms);
            this.tabControl1.Location = new System.Drawing.Point(3, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 476);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFilmLenen
            // 
            this.tabFilmLenen.Controls.Add(this.btnSearch);
            this.tabFilmLenen.Controls.Add(this.label1);
            this.tabFilmLenen.Controls.Add(this.txtmoviename);
            this.tabFilmLenen.Controls.Add(this.btnRent);
            this.tabFilmLenen.Controls.Add(this.lstvwFilmsUser);
            this.tabFilmLenen.Location = new System.Drawing.Point(4, 22);
            this.tabFilmLenen.Name = "tabFilmLenen";
            this.tabFilmLenen.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilmLenen.Size = new System.Drawing.Size(779, 450);
            this.tabFilmLenen.TabIndex = 0;
            this.tabFilmLenen.Text = "Films lenen";
            this.tabFilmLenen.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(315, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Find movie:";
            // 
            // txtmoviename
            // 
            this.txtmoviename.Location = new System.Drawing.Point(70, 13);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(239, 20);
            this.txtmoviename.TabIndex = 11;
            this.txtmoviename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtmoviename_KeyDown_1);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(3, 404);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(106, 35);
            this.btnRent.TabIndex = 10;
            this.btnRent.Text = "Huren";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click_1);
            // 
            // lstvwFilmsUser
            // 
            this.lstvwFilmsUser.AllowColumnReorder = true;
            this.lstvwFilmsUser.FullRowSelect = true;
            this.lstvwFilmsUser.HideSelection = false;
            this.lstvwFilmsUser.Location = new System.Drawing.Point(3, 39);
            this.lstvwFilmsUser.Name = "lstvwFilmsUser";
            this.lstvwFilmsUser.Size = new System.Drawing.Size(776, 359);
            this.lstvwFilmsUser.TabIndex = 9;
            this.lstvwFilmsUser.UseCompatibleStateImageBehavior = false;
            // 
            // tabOntleendeFilms
            // 
            this.tabOntleendeFilms.Controls.Add(this.lstvwOntleendeFilms);
            this.tabOntleendeFilms.Location = new System.Drawing.Point(4, 22);
            this.tabOntleendeFilms.Name = "tabOntleendeFilms";
            this.tabOntleendeFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabOntleendeFilms.Size = new System.Drawing.Size(779, 450);
            this.tabOntleendeFilms.TabIndex = 1;
            this.tabOntleendeFilms.Text = "Ontleende films";
            this.tabOntleendeFilms.UseVisualStyleBackColor = true;
            // 
            // lstvwOntleendeFilms
            // 
            this.lstvwOntleendeFilms.AllowColumnReorder = true;
            this.lstvwOntleendeFilms.FullRowSelect = true;
            this.lstvwOntleendeFilms.HideSelection = false;
            this.lstvwOntleendeFilms.Location = new System.Drawing.Point(1, 25);
            this.lstvwOntleendeFilms.Name = "lstvwOntleendeFilms";
            this.lstvwOntleendeFilms.Size = new System.Drawing.Size(776, 419);
            this.lstvwOntleendeFilms.TabIndex = 11;
            this.lstvwOntleendeFilms.UseCompatibleStateImageBehavior = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.tabControl);
            this.Name = "frmUser";
            this.Text = "Films uitlenen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmfilms_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmfilms_FormClosed);
            this.Load += new System.EventHandler(this.frmfilms_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabOverzicht.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFilmLenen.ResumeLayout(false);
            this.tabFilmLenen.PerformLayout();
            this.tabOntleendeFilms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabOverzicht;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblwelkom;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFilmLenen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ListView lstvwFilmsUser;
        private System.Windows.Forms.TabPage tabOntleendeFilms;
        private System.Windows.Forms.ListView lstvwOntleendeFilms;
    }
}

