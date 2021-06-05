using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitlenenVanFilms
{
    public partial class frmWijzig : Form
    {
        private frmlog Linstance;
        private frmAdmin Ainstance;
        private int FilmID;
        private IDictionary<string, string> Errors;
        private bool ok = true, close = false;
        private Image image;
        public frmWijzig(int FilmID, string name, string desc, frmAdmin Ainstance, frmlog Linstance)
        {
            InitializeComponent();
            this.Ainstance = Ainstance;
            this.Linstance = Linstance;
            Errors = Linstance.getErrors();
            this.FilmID = FilmID;

            txtname.Text = name;
            txtdescription.Text = desc;
            image = Image.FromFile("../Images/" + FilmID + ".png");
            pctrbxFile.Image = image;
        }

        private void frmWijzig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                image.Dispose();
                Ainstance.updateFilm(FilmID, txtname.Text, txtdescription.Text, lblFileName.Text);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
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

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFilmName"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFilmDesc"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }
            if (lblFileName.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFile"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ok = false;
            }

            if (ok)
            {
                close = true;

                this.Close();
            }
        }

        private void frmWijzig_Load(object sender, EventArgs e)
        {

        }
    }
}
