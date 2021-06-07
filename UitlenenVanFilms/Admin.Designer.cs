namespace UitlenenVanFilms
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveDatagrid = new System.Windows.Forms.Button();
            this.dtgrdvwUsers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmoviename = new System.Windows.Forms.TextBox();
            this.lstvwFilmsAdmin = new System.Windows.Forms.ListView();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblTimeSchedule = new System.Windows.Forms.Label();
            this.btnTimeSchedule = new System.Windows.Forms.Button();
            this.lblBoeteUpdate = new System.Windows.Forms.Label();
            this.btnBoeteUpdate = new System.Windows.Forms.Button();
            this.dtgrdvwOntleningen = new System.Windows.Forms.DataGridView();
            this.tmrboete = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwUsers)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwOntleningen)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 454);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ga naar de gebruikers panel: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveDatagrid);
            this.tabPage2.Controls.Add(this.dtgrdvwUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveDatagrid
            // 
            this.btnSaveDatagrid.Location = new System.Drawing.Point(27, 359);
            this.btnSaveDatagrid.Name = "btnSaveDatagrid";
            this.btnSaveDatagrid.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDatagrid.TabIndex = 1;
            this.btnSaveDatagrid.Text = "Opslaan";
            this.btnSaveDatagrid.UseVisualStyleBackColor = true;
            this.btnSaveDatagrid.Click += new System.EventHandler(this.btnSaveDatagrid_Click);
            // 
            // dtgrdvwUsers
            // 
            this.dtgrdvwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwUsers.Location = new System.Drawing.Point(27, 40);
            this.dtgrdvwUsers.Name = "dtgrdvwUsers";
            this.dtgrdvwUsers.Size = new System.Drawing.Size(445, 304);
            this.dtgrdvwUsers.TabIndex = 0;
            this.dtgrdvwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dtgrdvwUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dtgrdvwUsers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dtgrdvwUsers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtmoviename);
            this.tabPage3.Controls.Add(this.lstvwFilmsAdmin);
            this.tabPage3.Controls.Add(this.btnToevoegen);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Films";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(320, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find movie:";
            // 
            // txtmoviename
            // 
            this.txtmoviename.Location = new System.Drawing.Point(75, 12);
            this.txtmoviename.Name = "txtmoviename";
            this.txtmoviename.Size = new System.Drawing.Size(239, 20);
            this.txtmoviename.TabIndex = 9;
            this.txtmoviename.TextChanged += new System.EventHandler(this.txtmoviename_TextChanged);
            this.txtmoviename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmoviename_KeyDown);
            // 
            // lstvwFilmsAdmin
            // 
            this.lstvwFilmsAdmin.AllowColumnReorder = true;
            this.lstvwFilmsAdmin.FullRowSelect = true;
            this.lstvwFilmsAdmin.HideSelection = false;
            this.lstvwFilmsAdmin.Location = new System.Drawing.Point(8, 67);
            this.lstvwFilmsAdmin.Name = "lstvwFilmsAdmin";
            this.lstvwFilmsAdmin.Size = new System.Drawing.Size(776, 350);
            this.lstvwFilmsAdmin.TabIndex = 3;
            this.lstvwFilmsAdmin.UseCompatibleStateImageBehavior = false;
            this.lstvwFilmsAdmin.SelectedIndexChanged += new System.EventHandler(this.LstvwFilmsAdmin_SelectedIndexChanged);
            this.lstvwFilmsAdmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstvwFilmsAdmin_KeyUp);
            this.lstvwFilmsAdmin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvwFilmsAdmin_MouseDoubleClick);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(8, 38);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblTimeSchedule);
            this.tabPage4.Controls.Add(this.btnTimeSchedule);
            this.tabPage4.Controls.Add(this.lblBoeteUpdate);
            this.tabPage4.Controls.Add(this.btnBoeteUpdate);
            this.tabPage4.Controls.Add(this.dtgrdvwOntleningen);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 428);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ontleningen";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblTimeSchedule
            // 
            this.lblTimeSchedule.AutoSize = true;
            this.lblTimeSchedule.Location = new System.Drawing.Point(8, 361);
            this.lblTimeSchedule.Name = "lblTimeSchedule";
            this.lblTimeSchedule.Size = new System.Drawing.Size(133, 13);
            this.lblTimeSchedule.TabIndex = 4;
            this.lblTimeSchedule.Text = "Boete Update Tijdschema:";
            // 
            // btnTimeSchedule
            // 
            this.btnTimeSchedule.Location = new System.Drawing.Point(147, 356);
            this.btnTimeSchedule.Name = "btnTimeSchedule";
            this.btnTimeSchedule.Size = new System.Drawing.Size(68, 23);
            this.btnTimeSchedule.TabIndex = 3;
            this.btnTimeSchedule.Text = "Time";
            this.btnTimeSchedule.UseVisualStyleBackColor = true;
            this.btnTimeSchedule.Click += new System.EventHandler(this.btnTimeSchedule_Click);
            // 
            // lblBoeteUpdate
            // 
            this.lblBoeteUpdate.AutoSize = true;
            this.lblBoeteUpdate.Location = new System.Drawing.Point(8, 319);
            this.lblBoeteUpdate.Name = "lblBoeteUpdate";
            this.lblBoeteUpdate.Size = new System.Drawing.Size(115, 13);
            this.lblBoeteUpdate.TabIndex = 2;
            this.lblBoeteUpdate.Text = "Forceer Boete Update:";
            // 
            // btnBoeteUpdate
            // 
            this.btnBoeteUpdate.Location = new System.Drawing.Point(129, 314);
            this.btnBoeteUpdate.Name = "btnBoeteUpdate";
            this.btnBoeteUpdate.Size = new System.Drawing.Size(68, 23);
            this.btnBoeteUpdate.TabIndex = 1;
            this.btnBoeteUpdate.Text = "Update";
            this.btnBoeteUpdate.UseVisualStyleBackColor = true;
            this.btnBoeteUpdate.Click += new System.EventHandler(this.btnBoeteUpdate_Click);
            // 
            // dtgrdvwOntleningen
            // 
            this.dtgrdvwOntleningen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwOntleningen.Location = new System.Drawing.Point(8, 6);
            this.dtgrdvwOntleningen.Name = "dtgrdvwOntleningen";
            this.dtgrdvwOntleningen.Size = new System.Drawing.Size(629, 270);
            this.dtgrdvwOntleningen.TabIndex = 0;
            // 
            // tmrboete
            // 
            this.tmrboete.Enabled = true;
            this.tmrboete.Interval = 60000;
            this.tmrboete.Tick += new System.EventHandler(this.tmrboete_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwUsers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwOntleningen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lstvwFilmsAdmin;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.DataGridView dtgrdvwUsers;
        private System.Windows.Forms.Button btnSaveDatagrid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmoviename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrdvwOntleningen;
        private System.Windows.Forms.Label lblTimeSchedule;
        private System.Windows.Forms.Button btnTimeSchedule;
        private System.Windows.Forms.Label lblBoeteUpdate;
        private System.Windows.Forms.Button btnBoeteUpdate;
        private System.Windows.Forms.Timer tmrboete;
    }
}