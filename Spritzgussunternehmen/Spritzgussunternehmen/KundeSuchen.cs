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
    public partial class KundeSuchen : Form
    {
        DataSet ds = new DataSet();
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OleDB.12.0; Data Source = Werkstoffpruefsystem.accdb");
        OleDbCommand cmd = null;
        OleDbDataAdapter adap = null;
        OleDbDataReader dr = null;
     
        Form neededForm;
        TabPage KundenAdd = new TabPage();
        TabControl TC;
      
        public KundeSuchen(TabControl TC)
        {
            InitializeComponent();
            this.TC = TC;
        }
        
        private void Kunde_Load(object sender, EventArgs e)
        {
        
            DataGridFuellen();

        }

        public void DataGridFuellen()
        {
           
            adap = new OleDbDataAdapter("SELECT * FROM Kunde ", con);

            ds.Clear();

            adap.Fill(ds, "Kunden");

            Kunden.DataSource = ds;
            Kunden.DataMember = "Kunden";

            
            
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            KundenAdd.Text = "Kunden hinzufügen";
            TC.TabPages.Add(KundenAdd);
            OpenForm(new KundeAdd());
            TC.SelectedTab = KundenAdd;
        }
        public void OpenForm(Form FormToOpen)
        {
            neededForm = FormToOpen;
            FormToOpen.TopLevel = false;
            FormToOpen.FormBorderStyle = FormBorderStyle.None;
            FormToOpen.Dock = DockStyle.Fill;
            KundenAdd.Controls.Add(FormToOpen);
            KundenAdd.Tag = FormToOpen;
            FormToOpen.BringToFront();
            FormToOpen.Show();
        }


        DataTable table;
        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength>0)
            {
            table = new DataTable();
            Kunden.DataSource = table;

            adap = new OleDbDataAdapter("SELECT * FROM Kunde WHERE IsActive = true", con);

            ds.Clear();

            adap.Fill(table);
            DataView dv = table.DefaultView;
            dv.RowFilter = "Bez LIKE '" + textBox1.Text + "%'";
            Kunden.DataSource = dv;
            }
            else
            {
                MessageBox.Show("Fehler");
            }
           
            

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            filter_panel.Visible = true;
            con.Open();
            cmd = new OleDbCommand("Select Distinct Ort From Kunde", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kundeWohnort_listBox.Items.Add(dr.GetString(0));
            }

            con.Close();

            con.Open();
            cmd = new OleDbCommand("Select Distinct Land From Kunde", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                land_listBox.Items.Add(dr.GetString(0));
            }

            con.Close();
        }

        public void istActive(OleDbDataAdapter AD)
        {
          

            foreach (DataGridViewRow r in Kunden.Rows)
            {
                bool test = Convert.ToBoolean(r.Cells[9].Value);
               
                if (istAktiv_checkBox.Checked == true)
                {

                    Kunden.Rows[r.Index].DefaultCellStyle.BackColor = Color.Empty;

                    
                }
                else
                {

                    if (test == false)
                    {

                        Kunden.Rows[r.Index].DefaultCellStyle.BackColor = Color.Red;

                    }

                    else
                    {
                        Kunden.Rows[r.Index].DefaultCellStyle.BackColor = Color.Empty;
                    }
                }

            }
        }
        

        private void kundeWohnort_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Oselected = kundeWohnort_listBox.SelectedItem.ToString();

            if (land_listBox.SelectedIndex<=0)
            {
                adap = new OleDbDataAdapter("SELECT * FROM Kunde WHERE Ort ='" + Oselected + "'", con);

                ds.Clear();

                adap.Fill(ds, "KundenOrt");

                Kunden.DataSource = ds;
                Kunden.DataMember = "KundenOrt";

            }
            else
            {
                string Lselected = land_listBox.SelectedItem.ToString();

                adap = new OleDbDataAdapter("SELECT * FROM Kunde WHERE Ort ='" + Oselected + "'and Land ='"+ Lselected + "'", con);

                ds.Clear();

                adap.Fill(ds, "KundenOaL");

                Kunden.DataSource = ds;
                Kunden.DataMember = "KundenOaL";
            }
            istActive(adap);
        }

        private void land_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string Lselected = land_listBox.SelectedItem.ToString();

            adap = new OleDbDataAdapter("SELECT * FROM Kunde WHERE Land ='" + Lselected + "'", con);

            ds.Clear();

            adap.Fill(ds, "KundenLand");

            Kunden.DataSource = ds;
            Kunden.DataMember = "KundenLand";

            kundeWohnort_listBox.Items.Clear();

            con.Open();
            cmd = new OleDbCommand("Select Distinct Ort From Kunde where Land ='" + Lselected + "'", con);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                kundeWohnort_listBox.Items.Add(dr.GetString(0));
            }

            con.Close();

            istActive(adap);
        }

        private void istAktiv_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
            istActive(adap);
        }
                
    }
}
