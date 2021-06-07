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
    public partial class frmSetSchedule : Form
    {
        frmAdmin admin;

        public frmSetSchedule(frmAdmin admin, double currinterval)
        {
            InitializeComponent();
            this.admin = admin;
            nmrcTime.Value = Convert.ToDecimal(currinterval);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            admin.setTime(Convert.ToInt32(Convert.ToDouble(nmrcTime.Value)*60000));
            this.Close();
        }
    }
}
