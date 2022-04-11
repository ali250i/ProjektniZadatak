namespace ProjektniZadatak
{
    partial class AdminArtikli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPretraga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPNaziv = new System.Windows.Forms.TextBox();
            this.textBoxPID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.textBoxVrsta = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIDD = new System.Windows.Forms.TextBox();
            this.buttonAzuriranje = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDodajteKolicinu = new System.Windows.Forms.Button();
            this.buttonOsvjezi = new System.Windows.Forms.Button();
            this.buttonBrisanje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kupciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudzbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(13, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(705, 231);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonPretraga
            // 
            this.buttonPretraga.BackColor = System.Drawing.Color.Green;
            this.buttonPretraga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPretraga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPretraga.ForeColor = System.Drawing.Color.White;
            this.buttonPretraga.Location = new System.Drawing.Point(584, 53);
            this.buttonPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPretraga.Name = "buttonPretraga";
            this.buttonPretraga.Size = new System.Drawing.Size(135, 43);
            this.buttonPretraga.TabIndex = 31;
            this.buttonPretraga.Text = "Pretraga";
            this.buttonPretraga.UseVisualStyleBackColor = false;
            this.buttonPretraga.Click += new System.EventHandler(this.buttonPretraga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(265, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dodavanje/Ažuriranje artikala";
            // 
            // textBoxPNaziv
            // 
            this.textBoxPNaziv.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxPNaziv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPNaziv.Location = new System.Drawing.Point(360, 59);
            this.textBoxPNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPNaziv.Name = "textBoxPNaziv";
            this.textBoxPNaziv.Size = new System.Drawing.Size(132, 32);
            this.textBoxPNaziv.TabIndex = 27;
            // 
            // textBoxPID
            // 
            this.textBoxPID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxPID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPID.Location = new System.Drawing.Point(72, 58);
            this.textBoxPID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPID.Name = "textBoxPID";
            this.textBoxPID.Size = new System.Drawing.Size(132, 32);
            this.textBoxPID.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(425, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Količina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(425, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vrsta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Naziv:";
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxKolicina.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxKolicina.Location = new System.Drawing.Point(585, 425);
            this.textBoxKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(132, 32);
            this.textBoxKolicina.TabIndex = 36;
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxCijena.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCijena.Location = new System.Drawing.Point(161, 421);
            this.textBoxCijena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(132, 32);
            this.textBoxCijena.TabIndex = 35;
            // 
            // textBoxVrsta
            // 
            this.textBoxVrsta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxVrsta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxVrsta.Location = new System.Drawing.Point(585, 363);
            this.textBoxVrsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVrsta.Name = "textBoxVrsta";
            this.textBoxVrsta.Size = new System.Drawing.Size(132, 32);
            this.textBoxVrsta.TabIndex = 34;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxNaziv.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxNaziv.Location = new System.Drawing.Point(160, 362);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(132, 32);
            this.textBoxNaziv.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(253, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "Dodavanje artikla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxIDD
            // 
            this.textBoxIDD.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxIDD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxIDD.Location = new System.Drawing.Point(183, 629);
            this.textBoxIDD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDD.Name = "textBoxIDD";
            this.textBoxIDD.Size = new System.Drawing.Size(132, 32);
            this.textBoxIDD.TabIndex = 42;
            // 
            // buttonAzuriranje
            // 
            this.buttonAzuriranje.BackColor = System.Drawing.Color.Green;
            this.buttonAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAzuriranje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAzuriranje.ForeColor = System.Drawing.Color.White;
            this.buttonAzuriranje.Location = new System.Drawing.Point(21, 542);
            this.buttonAzuriranje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAzuriranje.Name = "buttonAzuriranje";
            this.buttonAzuriranje.Size = new System.Drawing.Size(209, 44);
            this.buttonAzuriranje.TabIndex = 44;
            this.buttonAzuriranje.Text = "Azurirajte artikal";
            this.buttonAzuriranje.UseVisualStyleBackColor = false;
            this.buttonAzuriranje.Click += new System.EventHandler(this.buttonAzuriranje_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(16, 633);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "ID artikla:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(16, 682);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Dodajte količinu:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown1.Location = new System.Drawing.Point(239, 679);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 32);
            this.numericUpDown1.TabIndex = 47;
            // 
            // buttonDodajteKolicinu
            // 
            this.buttonDodajteKolicinu.BackColor = System.Drawing.Color.Green;
            this.buttonDodajteKolicinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajteKolicinu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDodajteKolicinu.ForeColor = System.Drawing.Color.White;
            this.buttonDodajteKolicinu.Location = new System.Drawing.Point(513, 649);
            this.buttonDodajteKolicinu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDodajteKolicinu.Name = "buttonDodajteKolicinu";
            this.buttonDodajteKolicinu.Size = new System.Drawing.Size(205, 44);
            this.buttonDodajteKolicinu.TabIndex = 48;
            this.buttonDodajteKolicinu.Text = "Dodajte kolicinu";
            this.buttonDodajteKolicinu.UseVisualStyleBackColor = false;
            this.buttonDodajteKolicinu.Click += new System.EventHandler(this.buttonDodajteKolicinu_Click);
            // 
            // buttonOsvjezi
            // 
            this.buttonOsvjezi.BackColor = System.Drawing.Color.Green;
            this.buttonOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOsvjezi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOsvjezi.ForeColor = System.Drawing.Color.White;
            this.buttonOsvjezi.Location = new System.Drawing.Point(293, 476);
            this.buttonOsvjezi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOsvjezi.Name = "buttonOsvjezi";
            this.buttonOsvjezi.Size = new System.Drawing.Size(135, 44);
            this.buttonOsvjezi.TabIndex = 49;
            this.buttonOsvjezi.Text = "Osvježi";
            this.buttonOsvjezi.UseVisualStyleBackColor = false;
            this.buttonOsvjezi.Click += new System.EventHandler(this.buttonOsvjezi_Click);
            // 
            // buttonBrisanje
            // 
            this.buttonBrisanje.BackColor = System.Drawing.Color.Green;
            this.buttonBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrisanje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBrisanje.ForeColor = System.Drawing.Color.White;
            this.buttonBrisanje.Location = new System.Drawing.Point(528, 542);
            this.buttonBrisanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBrisanje.Name = "buttonBrisanje";
            this.buttonBrisanje.Size = new System.Drawing.Size(191, 44);
            this.buttonBrisanje.TabIndex = 50;
            this.buttonBrisanje.Text = "Brisanje artikla";
            this.buttonBrisanje.UseVisualStyleBackColor = false;
            this.buttonBrisanje.Click += new System.EventHandler(this.buttonBrisanje_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(735, 31);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.kupciToolStripMenuItem,
            this.narudzbeToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.DarkKhaki;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // kupciToolStripMenuItem
            // 
            this.kupciToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.kupciToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            this.kupciToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.kupciToolStripMenuItem.Text = "Kupci";
            this.kupciToolStripMenuItem.Click += new System.EventHandler(this.kupciToolStripMenuItem_Click);
            // 
            // narudzbeToolStripMenuItem
            // 
            this.narudzbeToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.narudzbeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.narudzbeToolStripMenuItem.Name = "narudzbeToolStripMenuItem";
            this.narudzbeToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.narudzbeToolStripMenuItem.Text = "Narudzbe";
            this.narudzbeToolStripMenuItem.Click += new System.EventHandler(this.narudzbeToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(700, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 32);
            this.label10.TabIndex = 52;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AdminArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(735, 727);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonBrisanje);
            this.Controls.Add(this.buttonOsvjezi);
            this.Controls.Add(this.buttonDodajteKolicinu);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAzuriranje);
            this.Controls.Add(this.textBoxIDD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.textBoxVrsta);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPretraga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPNaziv);
            this.Controls.Add(this.textBoxPID);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminArtikli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminArtikli_FormClosed);
            this.Load += new System.EventHandler(this.AdminArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPNaziv;
        private System.Windows.Forms.TextBox textBoxPID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.TextBox textBoxVrsta;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIDD;
        private System.Windows.Forms.Button buttonAzuriranje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonDodajteKolicinu;
        private System.Windows.Forms.Button buttonOsvjezi;
        private System.Windows.Forms.Button buttonBrisanje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kupciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudzbeToolStripMenuItem;
        private System.Windows.Forms.Label label10;
    }
}