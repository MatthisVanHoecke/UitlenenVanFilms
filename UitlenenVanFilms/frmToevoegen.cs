using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitlenenVanFilms
{
    public partial class frmToevoegen : Form
    {
        private frmAdmin Ainstance;
        private frmLog Linstance;
        private IDictionary<string, string> Notifications;
        private IDictionary<string, string> Errors;
        private bool ok = true, close = false;
        private int FilmID = 0;
        public frmToevoegen(frmAdmin Ainstance, frmLog Linstance)
        {
            InitializeComponent();
            this.Ainstance = Ainstance;
            this.Linstance = Linstance;
            Errors = Linstance.getErrors();
            Notifications = Linstance.getNotifications();
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            if(txtname.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFilmName"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else
            {
                ok = true;
            }
            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFilmDesc"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else
            {
                ok = true;
            }
            if (lblFileName.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFile"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else
            {
                ok = true;
            }
            if (txtCategory.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFile"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            else
            {
                ok = true;
            }

            if (ok)
            {
                close = true;

                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
                verbinding.Open();
                try
                {


                    string opdrString = "SELECT MAX(FilmID) FROM tblFilms";
                    OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                    OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                    dataLezer.Read();

                    FilmID = (!dataLezer.GetValue(0).ToString().Equals("")) ? Convert.ToInt32(dataLezer.GetInt32(0))+1 : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Errors["tableError"] + ex);
                }
                finally
                {
                    verbinding.Close();
                }
                File.Copy(lblFileName.Text, "../Images/" + FilmID + ".png");
                this.Close();
            }
        }

        private void FrmToevoegen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(close)
            {
                Ainstance.insertFilm(FilmID, txtname.Text, txtdescription.Text, txtCategory.Text, lblFileName.Text);
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                if (!openFileDialog.FileName.ToLower().EndsWith(".png") && !openFileDialog.FileName.ToLower().EndsWith(".jpg") && !openFileDialog.FileName.ToLower().EndsWith(".jpeg"))
                {
                    MessageBox.Show(Errors["wrongFileType"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblFileName.Text = "";
                    pctrbxFile.Image = null;
                    ok = false;
                }
                else
                {
                    lblFileName.Text = openFileDialog.FileName;
                    pctrbxFile.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
