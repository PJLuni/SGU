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
    public partial class Auftrag : Form
    {
        DataSet ds = new DataSet();
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OleDB.12.0; Data Source = Werkstoffpruefsystem.accdb");
        OleDbCommand cmd = null;
        OleDbDataAdapter adap = null;
        OleDbDataReader dr = null;
        public Auftrag()
        {
            InitializeComponent();
        }

        private void Auftrag_Load(object sender, EventArgs e)
        {
            adap = new OleDbDataAdapter("SELECT Auftrag.Nr as Auftrag_Nr, Kunde.Bez as Kunde, Benutzerkonto.Vorname as Sachmitarbeiter,Auftrag.Auslieferungsdatum,Auftragsstatus.Bez as Status " + 
                                        "FROM Auftrag, Kunde, Benutzerkonto,Auftragsstatus " +  
                                        "Where Auftrag.Kunde=Kunde.Nr and Auftrag.Sachbearbeiter = Benutzerkonto.Nr and  Auftrag.Status = 1", con);

            ds.Clear();

            adap.Fill(ds, "Auftraege");

            Auftraege.DataSource = ds;
            Auftraege.DataMember = "Auftraege";

        }
    }
}
