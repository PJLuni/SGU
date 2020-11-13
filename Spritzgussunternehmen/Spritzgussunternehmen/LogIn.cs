using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace Spritzgussunternehmen
{
    public partial class LogIn : Form
    {
        IconButton sidebarAuftrag;

        OleConfig myConfig = new OleConfig();

        string username = null;
        string usernr = null;
        public LogIn(IconButton sidebarAuftrag)
        {
            InitializeComponent();
            this.sidebarAuftrag = sidebarAuftrag;
        }
        private void benutzername_Enter(object sender, EventArgs e)
        {
            if (benutzername.Text == "Benutzername")
            {
                benutzername.Clear();
                benutzername.ForeColor = Color.Black;
            }
        }
        private void benutzername_Leave(object sender, EventArgs e)
        {
            if (benutzername.Text == "")
            {
                benutzername.Text = "Benutzername";
                benutzername.ForeColor = Color.Gray;
            }
        }
        private void passwort_Enter(object sender, EventArgs e)
        {
            if (passwort.Text == "Passwort")
            {
                passwort.Clear();
                passwort.PasswordChar = '*';
                passwort.ForeColor = Color.Black;
            }
        }
        private void passwort_Leave(object sender, EventArgs e)
        {
            if (passwort.Text == "")
            {
                passwort.Text = "Passwort";
                passwort.ForeColor = Color.Gray;
                passwort.PasswordChar = '\0';
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || passwort.Text == "Passwort")
            {
                passwort.PasswordChar = '\0';
            }
            else if (checkBox1.Checked == false)
            {
                passwort.PasswordChar = '*';
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string hashedpasswort = HashPassword(passwort.Text, new SHA256CryptoServiceProvider());

            myConfig.ConOpen();

            myConfig.NewCmd($"SELECT count(*) FROM Benutzerkonto WHERE Benutzername = '{benutzername.Text}' AND Passwort = '{hashedpasswort}'");
            int userexists = myConfig.ExeCmd();

            myConfig.ConClose();

            if (userexists > 0)
            {
                GetData(benutzername.Text, hashedpasswort);
                LightsOn();
            }
        }
        private string HashPassword(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
        private void GetData(string benutzername, string hashedpasswort)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand($"SELECT Nr FROM Benutzerkonto WHERE Benutzername = '{benutzername}' AND Passwort = '{hashedpasswort}'", con);
                usernr += cmd.ExecuteScalar().ToString();

                cmd = new OleDbCommand($"SELECT Vorname FROM Benutzerkonto WHERE Benutzername = '{benutzername}' AND Passwort = '{hashedpasswort}'", con);
                username += cmd.ExecuteScalar().ToString() + " ";

                cmd = new OleDbCommand($"SELECT Nachname FROM Benutzerkonto WHERE Benutzername = '{benutzername}' AND Passwort = '{hashedpasswort}'", con);
                username += cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception Fehler)
            {
                MessageBox.Show("Fehler!!!!!\n\n" + Fehler);
            }
        }
        private void LightsOn()
        {
            sidebarAuftrag.Enabled = true;
        }

        public string Username
        {
            get
            {
                return username;
            }
        }
        public string Usernr
        {
            get
            {
                return usernr;
            }
        }
    }
}
