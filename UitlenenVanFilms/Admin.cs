﻿using System;
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
using Microsoft.VisualBasic;

namespace UitlenenVanFilms
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
        private int SelectedIndex = 0;
        private List<IDictionary<string, string>> filmitems = new List<IDictionary<string, string>>();
        ImageList imgs;

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

        public void loadFilmList()
        {
            lstvwFilmsAdmin.Clear();

            lstvwFilmsAdmin.View = View.Details;

            lstvwFilmsAdmin.Columns.Add("Images", 150);
            lstvwFilmsAdmin.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            imgs = new ImageList();
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
                    filmitems.Add(new Dictionary<string, string>() { { "FilmID", dataLezer.GetValue(0).ToString() }, { "Name", dataLezer.GetValue(1).ToString() }, { "Description", dataLezer.GetValue(2).ToString() } });
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

            lstvwFilmsAdmin.SmallImageList = imgs;

            for (int i = 0; i < paths.Length; i++)
            {
                var image = Image.FromFile("../Images/" + filmitems[i]["FilmID"] + ".png");
                imgs.Images.Add(image);
                lstvwFilmsAdmin.Items.Add(filmitems[i]["Description"], i);
                image.Dispose();
            }
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

        public void insertFilm(int FilmID, string name, string desc, string path)
        {

            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            verbinding.Open();
            try
            {
                String opdrString;


                opdrString = "INSERT INTO tblFilms (FilmID, Name, Description) VALUES (?,?,?)";
                //Let op de ' bij het invoegen van strings, opgelet hier worden vaste gegevens toegevoegd!!!!
                OleDbCommand opdracht2 = new OleDbCommand(opdrString, verbinding);

                opdracht2.Parameters.AddWithValue("", FilmID);
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

            var image = Image.FromFile(path);
            imgs.Images.Add(image);
            lstvwFilmsAdmin.Items.Add(desc, lstvwFilmsAdmin.Items.Count);
            filmitems.Add(new Dictionary<string, string>() { { "FilmID", FilmID.ToString() }, { "Name", name }, { "Description", desc } });
            image.Dispose();
        }

        public void updateFilm(int FilmID, string name, string desc, string path)
        {
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
            verbinding.Open();
            try
            {
                String opdrString;


                opdrString = "UPDATE tblFilms SET Name = ?, Description = ? WHERE FilmID = ?";
                //Let op de ' bij het invoegen van strings, opgelet hier worden vaste gegevens toegevoegd!!!!
                OleDbCommand opdracht2 = new OleDbCommand(opdrString, verbinding);

                opdracht2.Parameters.AddWithValue("", name);
                opdracht2.Parameters.AddWithValue("", desc);
                opdracht2.Parameters.AddWithValue("", FilmID);

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

            File.Delete("../Images/" + FilmID + ".png");
            File.Copy(path, "../Images/" + FilmID + ".png");

            loadFilmList();
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

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void lstvwFilmsAdmin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstvwFilmsAdmin.SelectedItems.Count == 1)
            {
                int index = lstvwFilmsAdmin.SelectedItems[0].Index;
                frmWijzig wijzig = new frmWijzig(Convert.ToInt32(filmitems[index]["FilmID"]), filmitems[index]["Name"], filmitems[index]["Description"], this, instance);
                wijzig.Show();

                SelectedIndex = index;
            }
        }

        private void lstvwFilmsAdmin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().ToLower().Equals("delete"))
            {
                if (lstvwFilmsAdmin.SelectedItems.Count > 0)
                {
                    string deleteItems = "";
                    for (int i = 0; i < lstvwFilmsAdmin.SelectedItems.Count; i++)
                    {
                        int index = lstvwFilmsAdmin.SelectedItems[i].Index;
                        deleteItems += (filmitems[index]["Name"] + "\n");
                    }
                    DialogResult result = MessageBox.Show(Notifications["deleteVerify"], Notifications["Warning"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
                        OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
                        verbinding.Open();
                        try
                        {

                            string opdrString = "DELETE FROM tblFilms WHERE FilmID = ?";
                            OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                            for(int i = 0; i < lstvwFilmsAdmin.SelectedItems.Count; i++)
                            {
                                int index = lstvwFilmsAdmin.SelectedItems[i].Index;
                                opdracht.Parameters.AddWithValue("", filmitems[index]["FilmID"]);

                                opdracht.ExecuteNonQuery();

                                File.Delete("../Images/" + filmitems[index]["FilmID"] + ".png");

                                lstvwFilmsAdmin.Items.RemoveAt(index);
                                filmitems.RemoveAt(index);
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
                        loadFilmList();
                    }
                }
            }
        }

        private void btnSaveFilms_Click(object sender, EventArgs e)
        {
        }
    }
}
