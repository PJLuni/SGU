using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Spritzgussunternehmen
{
    public partial class ChangePW : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OleDB.12.0; Data Source = Werkstoffpruefsystem.accdb");
        OleDbCommand cmd = null;
        string Sachnr;
        public ChangePW(string Sachnr)
        {
            InitializeComponent();
            this.Sachnr = Sachnr;
        }
        private void oldpw_Enter(object sender, EventArgs e)
        {
            if (oldpw.Text == "Altes Passwort")
            {
                oldpw.Clear();
                oldpw.PasswordChar = '*';
                oldpw.ForeColor = Color.Black;
            }
        }
        private void oldpw_Leave(object sender, EventArgs e)
        {
            if (oldpw.Text == "")
            {
                oldpw.Text = "Altes Passwort";
                oldpw.ForeColor = Color.Gray;
                oldpw.PasswordChar = '\0';
            }
        }
        private void newpw_Enter(object sender, EventArgs e)
        {
            if (newpw.Text == "Neues Passwort")
            {
                newpw.Clear();
                newpw.PasswordChar = '*';
                newpw.ForeColor = Color.Black;
            }
        }
        private void newpw_Leave(object sender, EventArgs e)
        {
            if (newpw.Text == "")
            {
                newpw.Text = "Neues Passwort";
                newpw.ForeColor = Color.Gray;
                newpw.PasswordChar = '\0';
            }
        }
        private void newpwagain_Enter(object sender, EventArgs e)
        {
            if (newpwagain.Text == "Neues Passwort wiederholen")
            {
                newpwagain.Clear();
                newpwagain.PasswordChar = '*';
                newpwagain.ForeColor = Color.Black;
            }
        }
        private void newpwagain_Leave(object sender, EventArgs e)
        {
            if (newpwagain.Text == "")
            {
                newpwagain.Text = "Neues Passwort wiederholen";
                newpwagain.ForeColor = Color.Gray;
                newpwagain.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string hashedpasswort = HashPassword(oldpw.Text, new SHA256CryptoServiceProvider());

                con.Open();

                cmd = new OleDbCommand($"SELECT Passwort FROM Benutzerkonto WHERE Nr = {Sachnr}", con);
                string DatabasePw = cmd.ExecuteScalar().ToString();

                con.Close();

                if (DatabasePw == hashedpasswort)
                {
                    if (newpw.Text == newpwagain.Text)
                    {
                        hashedpasswort = HashPassword(newpw.Text, new SHA256CryptoServiceProvider());

                        con.Open();

                        cmd = new OleDbCommand($"UPDATE Benutzerkonto set Passwort = '{hashedpasswort}' WHERE Nr = {Sachnr}", con);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Yes Baby");
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    string Test1 = "Aktion Fehlgeschlagen";
                    string Test2 = "Die von Ihnen eingegeben Passwörter stimmen nicht überein!";
                    MessageBox.Show(Test1, Test2, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception fehler)
            {
                MessageBox.Show("No Baby" + fehler);
            }
        }

        private string HashPassword(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
