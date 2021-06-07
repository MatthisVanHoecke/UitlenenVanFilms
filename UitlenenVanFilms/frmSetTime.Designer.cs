
namespace UitlenenVanFilms
{
    partial class frmSetSchedule
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
            this.nmrcTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTime)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrcTime
            // 
            this.nmrcTime.DecimalPlaces = 2;
            this.nmrcTime.Location = new System.Drawing.Point(96, 40);
            this.nmrcTime.Name = "nmrcTime";
            this.nmrcTime.Size = new System.Drawing.Size(120, 20);
            this.nmrcTime.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 42);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Tijd in minuten:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSetSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 161);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.nmrcTime);
            this.Name = "frmSetSchedule";
            this.Text = "Set Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrcTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSave;
    }
}