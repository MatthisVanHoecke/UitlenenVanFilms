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
    public partial class frmUser : Form
    {
        private frmLog instance;
        private string user = "";
        private List<int> changedRows = new List<int>();
        private List<int> changedPass = new List<int>();
        private List<int> deletedRows = new List<int>();
        private IDictionary<string, string> Notifications;
        private IDictionary<string, string> Errors;
        private List<Dictionary<string, string>> filmitems = new List<Dictionary<string, string>>();
        private frmAdmin admin;
        private int customerID;
        public frmUser(frmLog instance, string user, frmAdmin admin)
        {
            InitializeComponent();
            this.instance = instance;
            this.user = user;
            this.admin = admin;
        }

        private void Frmfilms_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void frmfilms_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Close();
            instance.Close();
        }

        private void frmfilms_Load(object sender, EventArgs e)
        {
            MessageBox.Show(instance.getCustomerID() + "");
            customerID = instance.getCustomerID();

            lstvwFilmsUser = admin.loadFilmList(lstvwFilmsUser);
            lstvwFilmsUser.Columns.Remove(lstvwFilmsUser.Columns[1]);
            filmitems = admin.getFilmItems();
            Notifications = instance.getNotifications();
            Errors = instance.getErrors();
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


                String sql = "Select * From tblUsers WHERE User like ?";


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
                    String sql = "UPDATE tblUsers SET User = ?, Passwoord = ?, Admin = ? WHERE CustomerID = ?";
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

        private void lstvwFilmsAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {

            if(lstvwFilmsUser.SelectedItems.Count != 0)
            {
                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
                verbinding.Open();
                try
                {
                    for (int i = 0; i < lstvwFilmsUser.SelectedItems.Count; i++)
                    {
                        if(Convert.ToBoolean(filmitems[lstvwFilmsUser.SelectedItems[i].Index]["Available"]))
                        {
                            string opdrString = "SELECT MAX(OrderID) FROM tblOrders";
                            OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                            OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                            dataLezer.Read();

                            int orderid = (!dataLezer.GetValue(0).ToString().Equals("")) ? Convert.ToInt32(dataLezer.GetInt32(0)) + 1 : 0;

                            String opdrString1, opdrString2, opdrString3;

                            opdrString1 = "INSERT INTO tblOrders (OrderID, CustomerID, DatumOntlening, Ingeleverd) VALUES (?,?,?,?)";
                            opdrString2 = "INSERT INTO tblOrderlines (OrderID, FilmID) VALUES (?,?)";
                            opdrString3 = "UPDATE tblFilms SET Available = False WHERE FilmID = ?";
                            //Let op de ' bij het invoegen van strings, opgelet hier worden vaste gegevens toegevoegd!!!!
                            OleDbCommand opdracht1 = new OleDbCommand(opdrString1, verbinding);
                            OleDbCommand opdracht2 = new OleDbCommand(opdrString2, verbinding);
                            OleDbCommand opdracht3 = new OleDbCommand(opdrString3, verbinding);

                            opdracht1.Parameters.AddWithValue("", orderid);
                            opdracht1.Parameters.AddWithValue("", customerID);
                            opdracht1.Parameters.AddWithValue("", DateTime.Today);
                            opdracht1.Parameters.AddWithValue("", false);

                            opdracht2.Parameters.AddWithValue("", orderid);
                            opdracht2.Parameters.AddWithValue("", filmitems[lstvwFilmsUser.SelectedItems[i].Index]["FilmID"]);

                            opdracht3.Parameters.AddWithValue("", filmitems[lstvwFilmsUser.SelectedItems[i].Index]["FilmID"]);

                            opdracht1.ExecuteNonQuery();
                            opdracht2.ExecuteNonQuery();
                            opdracht3.ExecuteNonQuery();

                            filmitems[lstvwFilmsUser.SelectedItems[i].Index]["Available"] = false.ToString();
                        }
                        else
                        {
                            MessageBox.Show(Errors["filmUnavailable"], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Errors["tableError"] + ex);
                }
                finally
                {
                    verbinding.Close();
                }
                lstvwFilmsUser = admin.createImageList(lstvwFilmsUser);
            }
        }

        private void txtmoviename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().ToLower().Equals("return"))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnSearch.PerformClick();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstvwFilmsUser = admin.createImageList(lstvwFilmsUser);
            for (int i = filmitems.Count - 1; i >= 0; i--)
            {
                if (!filmitems[i]["Name"].ToLower().StartsWith(txtmoviename.Text))
                {
                    lstvwFilmsUser.Items.RemoveAt(i);

                }
            }
        }
    }
}
