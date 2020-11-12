using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spritzgussunternehmen
{
    public partial class MainMenuPlaceholder : Form
    {
        Size StandardDateInfo = new Size(112, 28);
        Size Test = new Size(124, 0);

        public MainMenuPlaceholder()
        {
            InitializeComponent();
        }
        private void MainMenuPlaceholder_Load(object sender, EventArgs e)
        {
            SetClock();
            label1.Focus();
        }
        private void Uhr_Tick(object sender, EventArgs e)
        {
            SetClock();
        }
        private void label2_SizeChanged(object sender, EventArgs e)
        {
            /*Size NeueDateInfo = label2.Size;
            NeueDateInfo -= StandardDateInfo;*/
            label2.Location -= Test;
        }

        private void SetClock()
        {
            string dayshort = DateTime.Now.ToString("dd");
            string daylong = DateTime.Now.ToString("dddd");
            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.ToString("yyyy");

            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = $"{daylong}, {dayshort}. {month}, {year}";
        }
    }
}
