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
        OleDbDataReader dr = null;
        long Kunde;
        public KundeAdd(long Kunde)
        {
            this.Kunde = Kunde;
            InitializeComponent();
        }

        private void Kunde_Load(object sender, EventArgs e)
        {
            if (Kunde==0)
            {

            }
            else
            {

            cmd = new OleDbCommand("Select * from Kunde where Nr = " + Kunde + "", con);
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();

            textBox1.Text = dr.GetString(1);
            textBox2.Text = dr.GetString(2);
            textBox3.Text = dr.GetString(3);
            textBox4.Text = dr.GetString(4);
            textBox5.Text = Convert.ToString(dr.GetInt32(5));
            textBox6.Text = dr.GetString(6);
            textBox7.Text = dr.GetString(7);
            textBox8.Text = dr.GetString(8);
            }



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
