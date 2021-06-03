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
using UitlenenVanFilms;
using Microsoft.VisualBasic;

namespace safe
{
    public partial class frmAdmin : Form
    {
        private frmlog instance;
        private List<int> changedRows = new List<int>();
        private List<int> changedPass = new List<int>();
        private List<int> deletedRows = new List<int>();
        private IDictionary<string, string> Notifications;
        private IDictionary<string, string> Errors;
        private string user = "";
        private List<List<string>> filmitems = new List<List<string>>();

        public frmAdmin(frmlog instance, string user)
        {
            InitializeComponent();
            this.instance = instance;
            Notifications = instance.getNotifications();
            Errors = instance.getErrors();
            this.user = user;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            loadFilmList();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            try
            {
                verbinding.Open();

                String sql = "Select * From tblUsers";

                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, verbinding);

                DataSet mydata = new DataSet();

                adapter.Fill(mydata);

                mydata.DataSetName = "Omschrijving fouten";

                dataGridView1.DataSource = mydata.Tables[0];
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



        private void loadFilmList()
        {
            lstvwFilmsAdmin.View = View.Details;

            lstvwFilmsAdmin.Columns.Add("Images", 150);
            lstvwFilmsAdmin.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 148);

            string[] paths = { };
            paths = Directory.GetFiles(Directory.GetParent(Directory.GetCurrentDirectory()) + "/Images");

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            verbinding.Open();
            try
            {

                String opdrString;

                opdrString = "SELECT * FROM tblFilms";
                OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                while (dataLezer.Read())
                {
                    filmitems.Add(new List<string>() {dataLezer.GetValue(0).ToString(), dataLezer.GetValue(1).ToString(), dataLezer.GetValue(2).ToString(), dataLezer.GetValue(3).ToString() });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                verbinding.Close();
            }

            for (int i = 0; i < paths.Length; i++)
            {
                imgs.Images.Add(Image.FromFile(paths[i]));
                lstvwFilmsAdmin.Items.Add(filmitems[i][2], i);
            }

            lstvwFilmsAdmin.SmallImageList = imgs;
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changedRows.Add(e.RowIndex);
            if(e.ColumnIndex == 2)
            {
                changedPass.Add(e.RowIndex);
            }
        }

        private void btnSaveDatagrid_Click(object sender, EventArgs e)
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

                    opdracht.Parameters.AddWithValue("", dataGridView1.Rows[val].Cells[1].Value);
                    opdracht.Parameters.AddWithValue("", instance.EncodePasswordToBase64(dataGridView1.Rows[val].Cells[2].Value.ToString()));
                    opdracht.Parameters.AddWithValue("", dataGridView1.Rows[val].Cells[3].Value);
                    opdracht.Parameters.AddWithValue("", dataGridView1.Rows[val].Cells[0].Value);

                    opdracht.ExecuteNonQuery();
                }
                foreach(int val in deletedRows)
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
                dataGridView1.Rows[val].Cells[2].Value = instance.EncodePasswordToBase64(dataGridView1.Rows[val].Cells[2].Value.ToString());
            }
            changedRows.Clear();
            changedPass.Clear();
            deletedRows.Clear();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().ToLower().Equals("delete"))
            {
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    deletedRows.Add((int)dataGridView1.SelectedRows[i].Cells[0].Value);
                }
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            frmToevoegen toevoegen = new frmToevoegen(this, instance);
            toevoegen.Show();
        }

        public void insertFilm(string name, string desc)
        {

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            verbinding.Open();
            try
            {
                String opdrString;


                opdrString = "INSERT INTO tblFilms (Name, Description) VALUES (?,?)";
                //Let op de ' bij het invoegen van strings, opgelet hier worden vaste gegevens toegevoegd!!!!
                OleDbCommand opdracht2 = new OleDbCommand(opdrString, verbinding);

                opdracht2.Parameters.AddWithValue("", name);
                opdracht2.Parameters.AddWithValue("", desc);

                opdracht2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Errors["tableError"] + ex);
            }
            finally
            {
                verbinding.Close();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                MessageBox.Show("U kunt dit column niet aanpassen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.Rows[e.RowIndex].Cells[0].ReadOnly = true;
            }
        }

        private void LstvwFilmsAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
