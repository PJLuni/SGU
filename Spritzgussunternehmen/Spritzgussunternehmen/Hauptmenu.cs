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

namespace Spritzgussunternehmen
{
    public partial class Hauptmenu : Form
    {
        private IconButton clickedButton;
        private Panel leftOnClickedButton;
        private Form neededForm;

        private LogIn Login = null;
        private Size NeuePanelSize;
        private Size StandardPanelSize = new Size(173, 60);
        public Hauptmenu()
        {
            InitializeComponent();
            leftOnClickedButton = new Panel();
            leftOnClickedButton.Size = new Size(7, 60);
            sidebar.Controls.Add(leftOnClickedButton);
        }
        //
        // EVENTS
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenForm(Login = new LogIn(sidebarAuftrag));
            ButtonHighlightOn(sidebarLogin);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
            main.Controls.Clear();
            OpenForm(new LogIn(sidebarAuftrag));
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            ButtonHighlightOn(sender);
        }
        private void topbarLogout_Click(object sender, EventArgs e)
        {
            LightsOff();
        }
        private void topbarClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void topbarSettings_Click(object sender, EventArgs e)
        {
            OpenForm(new ChangePW(sachname.Text));
            ButtonHighlightOff();
        }
        private void sachname_SizeChanged(object sender, EventArgs e)
        {
            Size username = sachname.Size;
            NeuePanelSize += username;
            panel5.Size += NeuePanelSize;
        }
        private void sidebarAuftrag_EnabledChanged(object sender, EventArgs e)
        {
            if (sidebarAuftrag.Enabled == true)
            {
                sidebarLieferung.Enabled = true;
                sidebarRechnung.Enabled = true;
                sidebarStammdaten.Enabled = true;
                sidebarStatus.Enabled = true;
                topbarLogout.Enabled = true;
                topbarSettings.Enabled = true;

                main.Controls.Clear();
                OpenForm(new MainMenuPlaceholder());

                sachname.Text = Login.Usernr;
                sachnr.Text = Login.Username;

                sachname.Visible = true;
                sachnr.Visible = true;
            }
            else
            {
                sidebarLieferung.Enabled = false;
                sidebarRechnung.Enabled = false;
                sidebarStammdaten.Enabled = false;
                sidebarStatus.Enabled = false;
                topbarLogout.Enabled = false;
                topbarSettings.Enabled = false;

                sachname.Visible = false;
                sachnr.Visible = false;
            }
        }
        //
        // GESCHRIEBENE METHODEN
        //
        public void OpenForm(Form FormToOpen)
        {
            neededForm = FormToOpen;
            FormToOpen.TopLevel = false;
            FormToOpen.FormBorderStyle = FormBorderStyle.None;
            FormToOpen.Dock = DockStyle.Fill;
            main.Controls.Add(FormToOpen);
            main.Tag = FormToOpen;
            FormToOpen.BringToFront();
            FormToOpen.Show();
        }
        private void ButtonHighlightOn(object sender)
        {
            if (sender != null)
            {
                ButtonHighlightOff();

                clickedButton = (IconButton)sender;
                clickedButton.BackColor = Color.FromArgb(55, 55, 55);
                clickedButton.ForeColor = Color.Coral;
                clickedButton.TextAlign = ContentAlignment.MiddleCenter;
                clickedButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                clickedButton.ImageAlign = ContentAlignment.MiddleRight;

                leftOnClickedButton.BackColor = Color.Coral;
                leftOnClickedButton.Location = new Point(0, clickedButton.Location.Y);
                leftOnClickedButton.Visible = true;
                leftOnClickedButton.BringToFront();
            }
        }
        private void ButtonHighlightOff()
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.FromArgb(46, 46, 46);
                clickedButton.ForeColor = Color.White;
                clickedButton.TextAlign = ContentAlignment.MiddleLeft;
                clickedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                clickedButton.ImageAlign = ContentAlignment.MiddleLeft;
                leftOnClickedButton.Visible = false;
            }
        }
        private void LightsOff()
        {
            sidebarAuftrag.Enabled = false;
        }

        private void Error_Tick(object sender, EventArgs e)
        {
            ErrorPanel.Visible = false;
            ErrorPanel.Controls.Clear();
            Error.Stop();
        }
    }
}
