namespace Spritzgussunternehmen
{
    partial class Hauptmenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptmenu));
            this.sidebar = new System.Windows.Forms.Panel();
            this.sidebarStatus = new FontAwesome.Sharp.IconButton();
            this.sidebarStammdaten = new FontAwesome.Sharp.IconButton();
            this.sidebarRechnung = new FontAwesome.Sharp.IconButton();
            this.sidebarLieferung = new FontAwesome.Sharp.IconButton();
            this.sidebarAuftrag = new FontAwesome.Sharp.IconButton();
            this.sidebarLogin = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sachnr = new System.Windows.Forms.Label();
            this.sachname = new System.Windows.Forms.Label();
            this.topbarLogout = new FontAwesome.Sharp.IconButton();
            this.topbarClose = new FontAwesome.Sharp.IconButton();
            this.topbarSettings = new FontAwesome.Sharp.IconButton();
            this.main = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.topbar.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sidebar.Controls.Add(this.sidebarStatus);
            this.sidebar.Controls.Add(this.sidebarStammdaten);
            this.sidebar.Controls.Add(this.sidebarRechnung);
            this.sidebar.Controls.Add(this.sidebarLieferung);
            this.sidebar.Controls.Add(this.sidebarAuftrag);
            this.sidebar.Controls.Add(this.sidebarLogin);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 875);
            this.sidebar.TabIndex = 0;
            // 
            // sidebarStatus
            // 
            this.sidebarStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarStatus.Enabled = false;
            this.sidebarStatus.FlatAppearance.BorderSize = 0;
            this.sidebarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarStatus.ForeColor = System.Drawing.Color.White;
            this.sidebarStatus.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.sidebarStatus.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarStatus.Location = new System.Drawing.Point(0, 420);
            this.sidebarStatus.Name = "sidebarStatus";
            this.sidebarStatus.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarStatus.Size = new System.Drawing.Size(200, 60);
            this.sidebarStatus.TabIndex = 5;
            this.sidebarStatus.TabStop = false;
            this.sidebarStatus.Text = "Status";
            this.sidebarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarStatus.UseVisualStyleBackColor = true;
            this.sidebarStatus.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // sidebarStammdaten
            // 
            this.sidebarStammdaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarStammdaten.Enabled = false;
            this.sidebarStammdaten.FlatAppearance.BorderSize = 0;
            this.sidebarStammdaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarStammdaten.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarStammdaten.ForeColor = System.Drawing.Color.White;
            this.sidebarStammdaten.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.sidebarStammdaten.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarStammdaten.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarStammdaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarStammdaten.Location = new System.Drawing.Point(0, 360);
            this.sidebarStammdaten.Name = "sidebarStammdaten";
            this.sidebarStammdaten.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarStammdaten.Size = new System.Drawing.Size(200, 60);
            this.sidebarStammdaten.TabIndex = 4;
            this.sidebarStammdaten.TabStop = false;
            this.sidebarStammdaten.Text = "Stammdaten";
            this.sidebarStammdaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarStammdaten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarStammdaten.UseVisualStyleBackColor = true;
            this.sidebarStammdaten.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // sidebarRechnung
            // 
            this.sidebarRechnung.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarRechnung.Enabled = false;
            this.sidebarRechnung.FlatAppearance.BorderSize = 0;
            this.sidebarRechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarRechnung.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarRechnung.ForeColor = System.Drawing.Color.White;
            this.sidebarRechnung.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.sidebarRechnung.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarRechnung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarRechnung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarRechnung.Location = new System.Drawing.Point(0, 300);
            this.sidebarRechnung.Name = "sidebarRechnung";
            this.sidebarRechnung.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarRechnung.Size = new System.Drawing.Size(200, 60);
            this.sidebarRechnung.TabIndex = 3;
            this.sidebarRechnung.TabStop = false;
            this.sidebarRechnung.Text = "Rechnung";
            this.sidebarRechnung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarRechnung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarRechnung.UseVisualStyleBackColor = true;
            this.sidebarRechnung.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // sidebarLieferung
            // 
            this.sidebarLieferung.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarLieferung.Enabled = false;
            this.sidebarLieferung.FlatAppearance.BorderSize = 0;
            this.sidebarLieferung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarLieferung.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarLieferung.ForeColor = System.Drawing.Color.White;
            this.sidebarLieferung.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.sidebarLieferung.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarLieferung.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarLieferung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarLieferung.Location = new System.Drawing.Point(0, 240);
            this.sidebarLieferung.Name = "sidebarLieferung";
            this.sidebarLieferung.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarLieferung.Size = new System.Drawing.Size(200, 60);
            this.sidebarLieferung.TabIndex = 2;
            this.sidebarLieferung.TabStop = false;
            this.sidebarLieferung.Text = "Lieferung";
            this.sidebarLieferung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarLieferung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarLieferung.UseVisualStyleBackColor = true;
            this.sidebarLieferung.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // sidebarAuftrag
            // 
            this.sidebarAuftrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarAuftrag.Enabled = false;
            this.sidebarAuftrag.FlatAppearance.BorderSize = 0;
            this.sidebarAuftrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarAuftrag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarAuftrag.ForeColor = System.Drawing.Color.White;
            this.sidebarAuftrag.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.sidebarAuftrag.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarAuftrag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarAuftrag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarAuftrag.Location = new System.Drawing.Point(0, 180);
            this.sidebarAuftrag.Name = "sidebarAuftrag";
            this.sidebarAuftrag.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarAuftrag.Size = new System.Drawing.Size(200, 60);
            this.sidebarAuftrag.TabIndex = 1;
            this.sidebarAuftrag.TabStop = false;
            this.sidebarAuftrag.Text = "Auftrag";
            this.sidebarAuftrag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarAuftrag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarAuftrag.UseVisualStyleBackColor = true;
            this.sidebarAuftrag.EnabledChanged += new System.EventHandler(this.sidebarAuftrag_EnabledChanged);
            this.sidebarAuftrag.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // sidebarLogin
            // 
            this.sidebarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.sidebarLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidebarLogin.FlatAppearance.BorderSize = 0;
            this.sidebarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebarLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidebarLogin.ForeColor = System.Drawing.Color.White;
            this.sidebarLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.sidebarLogin.IconColor = System.Drawing.Color.Chocolate;
            this.sidebarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sidebarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarLogin.Location = new System.Drawing.Point(0, 120);
            this.sidebarLogin.Name = "sidebarLogin";
            this.sidebarLogin.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.sidebarLogin.Size = new System.Drawing.Size(200, 60);
            this.sidebarLogin.TabIndex = 0;
            this.sidebarLogin.TabStop = false;
            this.sidebarLogin.Text = "Login";
            this.sidebarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebarLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sidebarLogin.UseVisualStyleBackColor = false;
            this.sidebarLogin.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 120);
            this.panel4.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.topbar.Controls.Add(this.panel5);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(200, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(1064, 60);
            this.topbar.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.sachnr);
            this.panel5.Controls.Add(this.sachname);
            this.panel5.Controls.Add(this.topbarLogout);
            this.panel5.Controls.Add(this.topbarClose);
            this.panel5.Controls.Add(this.topbarSettings);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(891, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 60);
            this.panel5.TabIndex = 0;
            // 
            // sachnr
            // 
            this.sachnr.AutoSize = true;
            this.sachnr.Dock = System.Windows.Forms.DockStyle.Top;
            this.sachnr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sachnr.ForeColor = System.Drawing.Color.White;
            this.sachnr.Location = new System.Drawing.Point(56, 18);
            this.sachnr.Name = "sachnr";
            this.sachnr.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.sachnr.Size = new System.Drawing.Size(0, 28);
            this.sachnr.TabIndex = 7;
            this.sachnr.Visible = false;
            // 
            // sachname
            // 
            this.sachname.AutoSize = true;
            this.sachname.Dock = System.Windows.Forms.DockStyle.Top;
            this.sachname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sachname.ForeColor = System.Drawing.Color.White;
            this.sachname.Location = new System.Drawing.Point(56, 0);
            this.sachname.Name = "sachname";
            this.sachname.Size = new System.Drawing.Size(0, 18);
            this.sachname.TabIndex = 1;
            this.sachname.Visible = false;
            this.sachname.SizeChanged += new System.EventHandler(this.sachname_SizeChanged);
            // 
            // topbarLogout
            // 
            this.topbarLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.topbarLogout.Enabled = false;
            this.topbarLogout.FlatAppearance.BorderSize = 0;
            this.topbarLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbarLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbarLogout.ForeColor = System.Drawing.Color.White;
            this.topbarLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.topbarLogout.IconColor = System.Drawing.Color.Chocolate;
            this.topbarLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topbarLogout.Location = new System.Drawing.Point(61, 0);
            this.topbarLogout.Name = "topbarLogout";
            this.topbarLogout.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.topbarLogout.Size = new System.Drawing.Size(56, 60);
            this.topbarLogout.TabIndex = 6;
            this.topbarLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbarLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbarLogout.UseVisualStyleBackColor = true;
            this.topbarLogout.Click += new System.EventHandler(this.topbarLogout_Click);
            // 
            // topbarClose
            // 
            this.topbarClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.topbarClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.topbarClose.FlatAppearance.BorderSize = 0;
            this.topbarClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbarClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbarClose.ForeColor = System.Drawing.Color.White;
            this.topbarClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.topbarClose.IconColor = System.Drawing.Color.Chocolate;
            this.topbarClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topbarClose.Location = new System.Drawing.Point(117, 0);
            this.topbarClose.Name = "topbarClose";
            this.topbarClose.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.topbarClose.Size = new System.Drawing.Size(56, 60);
            this.topbarClose.TabIndex = 5;
            this.topbarClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbarClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbarClose.UseVisualStyleBackColor = true;
            this.topbarClose.Click += new System.EventHandler(this.topbarClose_Click);
            // 
            // topbarSettings
            // 
            this.topbarSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.topbarSettings.Enabled = false;
            this.topbarSettings.FlatAppearance.BorderSize = 0;
            this.topbarSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topbarSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbarSettings.ForeColor = System.Drawing.Color.White;
            this.topbarSettings.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.topbarSettings.IconColor = System.Drawing.Color.Chocolate;
            this.topbarSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topbarSettings.Location = new System.Drawing.Point(0, 0);
            this.topbarSettings.Name = "topbarSettings";
            this.topbarSettings.Padding = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.topbarSettings.Size = new System.Drawing.Size(56, 60);
            this.topbarSettings.TabIndex = 4;
            this.topbarSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topbarSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topbarSettings.UseVisualStyleBackColor = true;
            this.topbarSettings.Click += new System.EventHandler(this.topbarSettings_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.main.Location = new System.Drawing.Point(200, 60);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1064, 815);
            this.main.TabIndex = 2;
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1264, 875);
            this.Controls.Add(this.main);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Hauptmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firmenname";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.topbar.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel main;
        private FontAwesome.Sharp.IconButton sidebarStatus;
        private FontAwesome.Sharp.IconButton sidebarStammdaten;
        private FontAwesome.Sharp.IconButton sidebarRechnung;
        private FontAwesome.Sharp.IconButton sidebarLieferung;
        private FontAwesome.Sharp.IconButton sidebarAuftrag;
        private FontAwesome.Sharp.IconButton sidebarLogin;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton topbarLogout;
        private FontAwesome.Sharp.IconButton topbarClose;
        private FontAwesome.Sharp.IconButton topbarSettings;
        private System.Windows.Forms.Label sachname;
        private System.Windows.Forms.Label sachnr;
    }
}

