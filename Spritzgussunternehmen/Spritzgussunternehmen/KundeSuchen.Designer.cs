namespace Spritzgussunternehmen
{
    partial class KundeSuchen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kunden = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.filter_panel = new System.Windows.Forms.Panel();
            this.land_label = new System.Windows.Forms.Label();
            this.land_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kundeWohnort_listBox = new System.Windows.Forms.ListBox();
            this.istAktiv_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Kunden)).BeginInit();
            this.filter_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kunden
            // 
            this.Kunden.BackgroundColor = System.Drawing.Color.White;
            this.Kunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kunden.Location = new System.Drawing.Point(12, 233);
            this.Kunden.Name = "Kunden";
            this.Kunden.Size = new System.Drawing.Size(986, 318);
            this.Kunden.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(729, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 1;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.iconButton2.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 26;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.Location = new System.Drawing.Point(12, 199);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(87, 29);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Filter";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 26;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButton3.Location = new System.Drawing.Point(890, 198);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(108, 29);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Suchen";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 26;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 557);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(202, 29);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Kunden hinzufügen";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton4.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 26;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(220, 557);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(202, 29);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "Kunden bearbeiten";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton5.IconColor = System.Drawing.Color.Chocolate;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 26;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(428, 557);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(178, 29);
            this.iconButton5.TabIndex = 7;
            this.iconButton5.Text = "Kunden löschen";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // filter_panel
            // 
            this.filter_panel.Controls.Add(this.land_label);
            this.filter_panel.Controls.Add(this.land_listBox);
            this.filter_panel.Controls.Add(this.label1);
            this.filter_panel.Controls.Add(this.kundeWohnort_listBox);
            this.filter_panel.Controls.Add(this.istAktiv_checkBox);
            this.filter_panel.Location = new System.Drawing.Point(105, 154);
            this.filter_panel.Name = "filter_panel";
            this.filter_panel.Size = new System.Drawing.Size(528, 72);
            this.filter_panel.TabIndex = 8;
            this.filter_panel.Visible = false;
            // 
            // land_label
            // 
            this.land_label.AutoSize = true;
            this.land_label.ForeColor = System.Drawing.Color.White;
            this.land_label.Location = new System.Drawing.Point(61, 0);
            this.land_label.Name = "land_label";
            this.land_label.Size = new System.Drawing.Size(33, 12);
            this.land_label.TabIndex = 4;
            this.land_label.Text = "Land";
            // 
            // land_listBox
            // 
            this.land_listBox.FormattingEnabled = true;
            this.land_listBox.ItemHeight = 12;
            this.land_listBox.Location = new System.Drawing.Point(3, 29);
            this.land_listBox.Name = "land_listBox";
            this.land_listBox.Size = new System.Drawing.Size(161, 40);
            this.land_listBox.TabIndex = 3;
            this.land_listBox.SelectedIndexChanged += new System.EventHandler(this.land_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kunde Wohnort";
            // 
            // kundeWohnort_listBox
            // 
            this.kundeWohnort_listBox.FormattingEnabled = true;
            this.kundeWohnort_listBox.ItemHeight = 12;
            this.kundeWohnort_listBox.Location = new System.Drawing.Point(233, 29);
            this.kundeWohnort_listBox.Name = "kundeWohnort_listBox";
            this.kundeWohnort_listBox.Size = new System.Drawing.Size(161, 40);
            this.kundeWohnort_listBox.TabIndex = 1;
            this.kundeWohnort_listBox.SelectedIndexChanged += new System.EventHandler(this.kundeWohnort_listBox_SelectedIndexChanged);
            // 
            // istAktiv_checkBox
            // 
            this.istAktiv_checkBox.AutoSize = true;
            this.istAktiv_checkBox.ForeColor = System.Drawing.Color.White;
            this.istAktiv_checkBox.Location = new System.Drawing.Point(437, 44);
            this.istAktiv_checkBox.Name = "istAktiv_checkBox";
            this.istAktiv_checkBox.Size = new System.Drawing.Size(64, 16);
            this.istAktiv_checkBox.TabIndex = 0;
            this.istAktiv_checkBox.Text = "IstAktiv";
            this.istAktiv_checkBox.UseVisualStyleBackColor = true;
            this.istAktiv_checkBox.CheckedChanged += new System.EventHandler(this.istAktiv_checkBox_CheckedChanged);
            // 
            // KundeSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1010, 598);
            this.Controls.Add(this.filter_panel);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Kunden);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KundeSuchen";
            this.Text = "Kunde";
            this.Load += new System.EventHandler(this.Kunde_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kunden)).EndInit();
            this.filter_panel.ResumeLayout(false);
            this.filter_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Kunden;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel filter_panel;
        private System.Windows.Forms.CheckBox istAktiv_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox kundeWohnort_listBox;
        private System.Windows.Forms.Label land_label;
        private System.Windows.Forms.ListBox land_listBox;
    }
}