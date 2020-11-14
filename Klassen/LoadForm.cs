using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Spritzgussunternehmen
{
    class LoadForm
    {
        public static void OpenPanel(Form FormToOpen, Panel PanelToLoadIn)
        {
            FormToOpen.TopLevel = false;
            FormToOpen.FormBorderStyle = FormBorderStyle.None;
            FormToOpen.Dock = DockStyle.Fill;
            PanelToLoadIn.Controls.Add(FormToOpen);
            PanelToLoadIn.Tag = FormToOpen;
            FormToOpen.BringToFront();
            FormToOpen.Show();
        }
        public static void OpenTab(Form FormToOpen, TabPage TabToLoadIn)
        {
            FormToOpen.TopLevel = false;
            FormToOpen.FormBorderStyle = FormBorderStyle.None;
            FormToOpen.Dock = DockStyle.Fill;
            TabToLoadIn.Controls.Add(FormToOpen);
            TabToLoadIn.Tag = FormToOpen;
            FormToOpen.BringToFront();
            FormToOpen.Show();
        }
    }
}
