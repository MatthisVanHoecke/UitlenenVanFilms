using safe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitlenenVanFilms
{
    public partial class frmToevoegen : Form
    {
        private frmAdmin Ainstance;
        private frmlog Linstance;
        private IDictionary<string, string> Notifications;
        private IDictionary<string, string> Errors;
        private bool ok = true;
        public frmToevoegen(frmAdmin Ainstance, frmlog Linstance)
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
                MessageBox.Show(Errors["setFilmName"]);
                ok = false;
            }
            if (txtdescription.Text.Equals(""))
            {
                MessageBox.Show(Errors["setFilmDesc"]);
                ok = false;
            }

            if (ok)
            {
                this.Close();
            }
        }

        private void FrmToevoegen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ok)
            {
                Ainstance.insertFilm(txtname.Text, txtdescription.Text);
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            FileDialog dia = new FileDialog();
        }
    }
}
