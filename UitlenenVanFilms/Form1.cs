using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UitlenenVanFilms;

namespace UitlenenVanFilms
{
    public partial class frmfilms : Form
    {
        private frmlog instance;
        private string user = "";
        private List<int> changedRows = new List<int>();
        private List<int> changedPass = new List<int>();
        private List<int> deletedRows = new List<int>();
        private IDictionary<string, string> Notifications;
        private IDictionary<string, string> Errors;
        public frmfilms(frmlog instance, string user)
        {
            InitializeComponent();
            this.instance = instance;
            this.user = user;
            Notifications = instance.getNotifications();
            Errors = instance.getErrors();
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
            loadDataGrid();
            lblwelkom.Text = "Welkom, " + user;
        }
        private void loadDataGrid()
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                OleDbCommand command;

                String sql = "Select * From tblUsers WHERE Usernaam like ?";


                command = new OleDbCommand(sql, verbinding);
                command.Parameters.AddWithValue("", user);
                // Geef het command door aan de adapter.
                adapter.SelectCommand = command;

                DataSet mijnDataSat = new DataSet();
                adapter.Fill(mijnDataSat);

                mijnDataSat.DataSetName = "omschrijving fouten";
                dgvUser.DataSource = mijnDataSat.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                verbinding.Close();
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changedRows.Add(e.RowIndex);
            if (e.ColumnIndex == 2)
            {
                changedPass.Add(e.RowIndex);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            try
            {
                verbinding.Open();
                foreach (int val in changedRows)
                {
                    String sql = "UPDATE tblUsers SET Usernaam = ?, Passwoord = ?, Admin = ? WHERE CustomerID = ?";
                    OleDbCommand opdracht = new OleDbCommand(sql, verbinding);

                    opdracht.Parameters.AddWithValue("", dgvUser.Rows[val].Cells[1].Value);
                    opdracht.Parameters.AddWithValue("", instance.EncodePasswordToBase64(dgvUser.Rows[val].Cells[2].Value.ToString()));
                    opdracht.Parameters.AddWithValue("", dgvUser.Rows[val].Cells[3].Value);
                    opdracht.Parameters.AddWithValue("", dgvUser.Rows[val].Cells[0].Value);

                    opdracht.ExecuteNonQuery();
                }
                foreach (int val in deletedRows)
                {
                    String sql = "DELETE FROM tblUsers WHERE CustomerID = ?";
                    OleDbCommand opdracht = new OleDbCommand(sql, verbinding);

                    opdracht.Parameters.AddWithValue("", val);

                    opdracht.ExecuteNonQuery();
                }
                MessageBox.Show(Notifications["changesSaved"], "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                verbinding.Close();
            }
            foreach (int val in changedPass.ToList())
            {
                dgvUser.Rows[val].Cells[2].Value = instance.EncodePasswordToBase64(dgvUser.Rows[val].Cells[2].Value.ToString());
            }
            changedRows.Clear();
            changedPass.Clear();
            deletedRows.Clear();
        }

        private void DgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 3)
            {
                MessageBox.Show("U kunt dit column niet aanpassen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvUser.Rows[e.RowIndex].Cells[0].ReadOnly = true;
                dgvUser.Rows[e.RowIndex].Cells[3].ReadOnly = true;
            }
        }
    }
}
