using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UitlenenVanFilms;

namespace safe
{
    public partial class frmfilms : Form
    {
        private frmlog instance;
        private string user = "";

        public frmfilms(frmlog instance, string user)
        {
            InitializeComponent();
            this.instance = instance;
            this.user = user;
        }

        private void Frmfilms_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void frmfilms_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance.Close();
        }

        private void frmfilms_Load(object sender, EventArgs e)
        {
            lblwelkom.Text = "Welkom, " + user;
        }
    }
}
