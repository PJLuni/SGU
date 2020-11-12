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
    public partial class CustomMessageForm : Form
    {
        public CustomMessageForm(string title, string description)
        {
            InitializeComponent();
            this.title.Text = title;
            this.desc.Text = description;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class CustomMessageBox : Form
    {
        public void Show(string title, string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new CustomMessageForm(title, description))
            {
                form.ShowDialog();
            }
        }
    }
}
