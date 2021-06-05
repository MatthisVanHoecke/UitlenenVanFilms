
namespace UitlenenVanFilms
{
    partial class frmWijzig
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
            this.pctrbxFile = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnWijzigen = new System.Windows.Forms.Button();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxFile
            // 
            this.pctrbxFile.BackColor = System.Drawing.Color.White;
            this.pctrbxFile.Location = new System.Drawing.Point(102, 240);
            this.pctrbxFile.Name = "pctrbxFile";
            this.pctrbxFile.Size = new System.Drawing.Size(150, 186);
            this.pctrbxFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrbxFile.TabIndex = 15;
            this.pctrbxFile.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(193, 216);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 14;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(102, 211);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(85, 23);
            this.btnChoose.TabIndex = 13;
            this.btnChoose.Text = "Kies Bestand";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnWijzigen
            // 
            this.btnWijzigen.Location = new System.Drawing.Point(102, 432);
            this.btnWijzigen.Name = "btnWijzigen";
            this.btnWijzigen.Size = new System.Drawing.Size(150, 43);
            this.btnWijzigen.TabIndex = 12;
            this.btnWijzigen.Text = "Wijzig";
            this.btnWijzigen.UseVisualStyleBackColor = true;
            this.btnWijzigen.Click += new System.EventHandler(this.btnWijzigen_Click);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(17, 76);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(67, 13);
            this.lbldescription.TabIndex = 11;
            this.lbldescription.Text = "Beschrijving:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(17, 50);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Naam:";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(102, 73);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(223, 132);
            this.txtdescription.TabIndex = 9;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(102, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(223, 20);
            this.txtname.TabIndex = 8;
            // 
            // frmWijzig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 489);
            this.Controls.Add(this.pctrbxFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnWijzigen);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Name = "frmWijzig";
            this.Text = "Wijzigen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWijzig_FormClosing);
            this.Load += new System.EventHandler(this.frmWijzig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnWijzigen;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtname;
    }
}