namespace UitlenenVanFilms
{
    partial class frmToevoegen
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(97, 48);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(223, 20);
            this.txtname.TabIndex = 0;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(97, 74);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(223, 132);
            this.txtdescription.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 51);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Naam:";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(12, 77);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(67, 13);
            this.lbldescription.TabIndex = 3;
            this.lbldescription.Text = "Beschrijving:";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(97, 284);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(150, 23);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.BtnToevoegen_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(97, 212);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Kies File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // frmToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 377);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Name = "frmToevoegen";
            this.Text = "Film Toevoegen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmToevoegen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnChoose;
    }
}