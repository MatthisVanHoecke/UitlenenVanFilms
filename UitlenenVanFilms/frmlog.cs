using safe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UitlenenVanFilms
{
    public partial class frmlog : Form
    {
        public frmlog()
        {
            InitializeComponent();
        }

        private IDictionary<string, string> Errors = new Dictionary<string, string>() { {"userExists", "Deze gebruiker bestaat al."}, 
                                                                                        {"tableError", "Problemen bij het vullen van de tabel. "},
                                                                                        {"emptyPassword", "Vul alstublieft een wachtwoord in."},
                                                                                        {"passwordNotMatch", "De wachtwoorden komen niet overeen."},
                                                                                        {"emptyUsername", "Vul alstublieft een gebruikersnaam in." },
                                                                                        {"emptyEmail", "Vul alstublieft een email in." },
                                                                                        {"wrongPassword", "Fout password."},
                                                                                        {"userNotExist", "Deze gebruiker bestaat niet."}
                                                                                        };

        private IDictionary<string, string> Notifications = new Dictionary<string, string>() { 
                                                                                        {"changesSaved", "Wijzigingen zijn opgeslaan."}

                                                                                        };

        public IDictionary<string, string> getNotifications()
        {
            return Notifications;
        }
        public IDictionary<string, string> getErrors()
        {
            return Errors;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabRegistreren_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistreren_Click(object sender, EventArgs e)
        {

            String Username = txtCreateUser.Text, Email = txtCreateEmail.Text, Password = txtCreatePassword.Text, ConfirmPassword = txtConfirmPassword.Text;
            String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
            OleDbConnection verbinding = new OleDbConnection(verbindingsstring);

            if(!Username.Equals("") && !Email.Equals("") && !Password.Equals("") && !ConfirmPassword.Equals(""))
            {
                verbinding.Open();
                try
                {

                    bool ok = true;

                    String opdrString;
                    opdrString = "SELECT Usernaam FROM tblUsers WHERE Usernaam = ?";
                    OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                    opdracht.Parameters.AddWithValue("", Username);
                    OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dataLezer.Read())
                    {
                        if (!dataLezer.GetValue(0).ToString().Equals("") && !dataLezer.GetValue(0).ToString().Equals(null))
                        {
                            MessageBox.Show(Errors["userExists"], "Error");
                            ok = false;
                        }
                    }

                    if (ok)
                    {
                        opdrString = "INSERT INTO tblUsers (Usernaam, Passwoord) VALUES (?,?)";
                        //Let op de ' bij het invoegen van strings, opgelet hier worden vaste gegevens toegevoegd!!!!
                        OleDbCommand opdracht2 = new OleDbCommand(opdrString, verbinding);

                        opdracht2.Parameters.AddWithValue("", Username);
                        opdracht2.Parameters.AddWithValue("", EncodePasswordToBase64(Password));

                        opdracht2.ExecuteNonQuery();
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
            }
            else
            {
                string err = "";
                if(Username.Equals(""))
                {
                    err += Errors["emptyUsername"] + "\n";
                }
                if(Email.Equals(""))
                {
                    err += Errors["emptyEmail"] + "\n";
                }
                if (Password.Equals(""))
                {
                    err += Errors["emptyPassword"] + "\n";
                }
                if (!ConfirmPassword.Equals(Password))
                {
                    err += Errors["passwordNotMatch"] + "\n";
                }
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        private void TxtUserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCreateUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInloggen_Click(object sender, EventArgs e)
        {

            String Username = txtUserLogin.Text, Password = txtPasswordLogin.Text;

            if(!Username.Equals("") && !Password.Equals(""))
            {
                String verbindingsstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Films.accdb";
                OleDbConnection verbinding = new OleDbConnection(verbindingsstring);
                verbinding.Open();
                try
                {
                    bool ok = false, admin = false;

                    String opdrString, opdrString1;

                    opdrString1 = "SELECT COUNT(Usernaam) FROM tblUsers WHERE Usernaam = ?";
                    OleDbCommand opdracht1 = new OleDbCommand(opdrString1, verbinding);

                    opdracht1.Parameters.AddWithValue("", Username);
                    OleDbDataReader dataLezer1 = opdracht1.ExecuteReader(CommandBehavior.CloseConnection);

                    dataLezer1.Read();

                    if (!dataLezer1.GetValue(0).ToString().Equals("0"))
                    {
                        opdrString = "SELECT Passwoord, Admin FROM tblUsers WHERE Usernaam = ?";
                        OleDbCommand opdracht = new OleDbCommand(opdrString, verbinding);

                        opdracht.Parameters.AddWithValue("", Username);
                        OleDbDataReader dataLezer = opdracht.ExecuteReader(CommandBehavior.CloseConnection);

                        while (dataLezer.Read())
                        {
                            if (!DecodeFrom64(dataLezer.GetValue(0).ToString()).Equals(Password))
                            {
                                MessageBox.Show(Errors["wrongPassword"], "Error");


                            }
                            else
                            {
                                ok = true;
                                if (dataLezer.GetValue(1).ToString().ToLower().Equals("true"))
                                {
                                    admin = true;
                                }
                            }
                        }

                        if (ok && admin)
                        {
                            frmAdmin form = new frmAdmin(this, txtUserLogin.Text);
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmfilms form = new frmfilms(this, txtUserLogin.Text);
                            form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show(Errors["userNotExist"], "Error");
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
            }
            else
            {
                string err = "";
                if(Username.Equals(""))
                {
                    err += Errors["emptyUsername"] + "\n";
                }
                if(Password.Equals(""))
                {
                    err += Errors["emptyPassword"] + "\n";
                }
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmlog_Load(object sender, EventArgs e)
        {

        }

        private void Frmlog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmlog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().ToLower().Equals("return"))
            {
                if(tabControlStart.SelectedTab == tabInloggen)
                {
                    btnInloggen.PerformClick();
                }
                else
                {
                    btnRegistreren.PerformClick();
                }
            }
        }
    }
}
