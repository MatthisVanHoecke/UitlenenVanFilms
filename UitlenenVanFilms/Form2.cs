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
        frmAdmin instance;

        public frmToevoegen(frmAdmin instance)
        {
            InitializeComponent();
            this.instance = instance;
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            instance.setNameF(txtname.Text);
            instance.setDescriptionF(txtdescription.Text);
        }
    }
}
