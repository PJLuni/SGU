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

namespace Spritzgussunternehmen
{
    public partial class KundeAdd : Form
    {
        DataSet ds = new DataSet();
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OleDB.12.0; Data Source = Werkstoffpruefsystem.accdb");
        OleDbCommand cmd = null;
        OleDbDataAdapter adap = null;
        public KundeAdd()
        {
            InitializeComponent();
        }

        private void Kunde_Load(object sender, EventArgs e)
        {
               
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Kunden.SelectedRows != null)
                {
                    DialogResult result = MessageBox.Show("Sind Sie sicher das Sie den ausgewählten Kunden löschen möchten?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = Kunden.SelectedRows[0];
                        string ZuLoeschen = row.Cells[0].Value.ToString();

                        cmd = new OleDbCommand($"UPDATE Kunde SET IsActive = false WHERE Nr = {ZuLoeschen}", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        
                        Kunden.Rows.Remove(row);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Fehler beim löschen des Kunden" + a);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                lieferdaten.Visible = false;
            }
            else
            {
                lieferdaten.Visible = true;
            }
        }
    }
}
