namespace Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvProfesori = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTitlu = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.cmbOra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdaugaInOrar = new System.Windows.Forms.Button();
            this.btnAfiseazaOrar = new System.Windows.Forms.Button();
            this.cmbZiua = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStergeOrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficSaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatistici = new System.Windows.Forms.Label();
            this.tbCautare = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProfesori
            // 
            this.dgvProfesori.AllowUserToAddRows = false;
            this.dgvProfesori.AllowUserToResizeColumns = false;
            this.dgvProfesori.AllowUserToResizeRows = false;
            this.dgvProfesori.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesori.Location = new System.Drawing.Point(345, 48);
            this.dgvProfesori.Name = "dgvProfesori";
            this.dgvProfesori.ReadOnly = true;
            this.dgvProfesori.Size = new System.Drawing.Size(443, 164);
            this.dgvProfesori.TabIndex = 0;
            this.dgvProfesori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesori_CellClick);
            this.dgvProfesori.SelectionChanged += new System.EventHandler(this.dgvProfesori_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga Profesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNume.Location = new System.Drawing.Point(56, 31);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume:";
            // 
            // tbPrenume
            // 
            this.tbPrenume.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrenume.Location = new System.Drawing.Point(72, 61);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 20);
            this.tbPrenume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Titlu Academic:";
            // 
            // cmbTitlu
            // 
            this.cmbTitlu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitlu.FormattingEnabled = true;
            this.cmbTitlu.Items.AddRange(new object[] {
            "Asistent",
            "Lector",
            "Conf. Dr.",
            "Prof. Univ."});
            this.cmbTitlu.Location = new System.Drawing.Point(113, 91);
            this.cmbTitlu.Name = "cmbTitlu";
            this.cmbTitlu.Size = new System.Drawing.Size(121, 21);
            this.cmbTitlu.TabIndex = 7;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(14, 282);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(169, 21);
            this.cmbProfesor.TabIndex = 8;
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(189, 282);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(77, 21);
            this.cmbSala.TabIndex = 9;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(272, 282);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(177, 21);
            this.cmbDisciplina.TabIndex = 10;
            // 
            // cmbOra
            // 
            this.cmbOra.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOra.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbOra.FormattingEnabled = true;
            this.cmbOra.Location = new System.Drawing.Point(521, 282);
            this.cmbOra.Name = "cmbOra";
            this.cmbOra.Size = new System.Drawing.Size(56, 21);
            this.cmbOra.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Profesor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(205, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sala:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Materie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ora:";
            // 
            // btnAdaugaInOrar
            // 
            this.btnAdaugaInOrar.Location = new System.Drawing.Point(583, 280);
            this.btnAdaugaInOrar.Name = "btnAdaugaInOrar";
            this.btnAdaugaInOrar.Size = new System.Drawing.Size(96, 23);
            this.btnAdaugaInOrar.TabIndex = 16;
            this.btnAdaugaInOrar.Text = "Adauga in orar";
            this.btnAdaugaInOrar.UseVisualStyleBackColor = true;
            this.btnAdaugaInOrar.Click += new System.EventHandler(this.btnAdaugaInOrar_Click);
            // 
            // btnAfiseazaOrar
            // 
            this.btnAfiseazaOrar.Location = new System.Drawing.Point(35, 309);
            this.btnAfiseazaOrar.Name = "btnAfiseazaOrar";
            this.btnAfiseazaOrar.Size = new System.Drawing.Size(132, 23);
            this.btnAfiseazaOrar.TabIndex = 17;
            this.btnAfiseazaOrar.Text = "Afiseaza orar";
            this.btnAfiseazaOrar.UseVisualStyleBackColor = true;
            this.btnAfiseazaOrar.Click += new System.EventHandler(this.btnAfiseazaOrar_Click);
            // 
            // cmbZiua
            // 
            this.cmbZiua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZiua.FormattingEnabled = true;
            this.cmbZiua.Items.AddRange(new object[] {
            "Luni",
            "Marti",
            "Miercuri",
            "Joi",
            "Vineri",
            "Sambata",
            "Duminica"});
            this.cmbZiua.Location = new System.Drawing.Point(455, 282);
            this.cmbZiua.Name = "cmbZiua";
            this.cmbZiua.Size = new System.Drawing.Size(60, 21);
            this.cmbZiua.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ziua:";
            // 
            // btnStergeOrar
            // 
            this.btnStergeOrar.Location = new System.Drawing.Point(684, 280);
            this.btnStergeOrar.Name = "btnStergeOrar";
            this.btnStergeOrar.Size = new System.Drawing.Size(96, 23);
            this.btnStergeOrar.TabIndex = 20;
            this.btnStergeOrar.Text = "Sterge din orar";
            this.btnStergeOrar.UseVisualStyleBackColor = true;
            this.btnStergeOrar.Click += new System.EventHandler(this.btnStergeOrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveBinaryToolStripMenuItem,
            this.loadBinaryToolStripMenuItem,
            this.graficSaliToolStripMenuItem,
            this.lToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Load";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveBinaryToolStripMenuItem
            // 
            this.saveBinaryToolStripMenuItem.Name = "saveBinaryToolStripMenuItem";
            this.saveBinaryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveBinaryToolStripMenuItem.Text = "Save Binary";
            this.saveBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToolStripMenuItem_Click);
            // 
            // loadBinaryToolStripMenuItem
            // 
            this.loadBinaryToolStripMenuItem.Name = "loadBinaryToolStripMenuItem";
            this.loadBinaryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadBinaryToolStripMenuItem.Text = "Load Binary";
            this.loadBinaryToolStripMenuItem.Click += new System.EventHandler(this.loadBinaryToolStripMenuItem_Click);
            // 
            // graficSaliToolStripMenuItem
            // 
            this.graficSaliToolStripMenuItem.Name = "graficSaliToolStripMenuItem";
            this.graficSaliToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.graficSaliToolStripMenuItem.Text = "Grafic Sali";
            this.graficSaliToolStripMenuItem.Click += new System.EventHandler(this.graficSaliToolStripMenuItem_Click);
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.lToolStripMenuItem.Text = "Load XML";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaToolStripMenuItem,
            this.materieToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // materieToolStripMenuItem
            // 
            this.materieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem1,
            this.stergeToolStripMenuItem1});
            this.materieToolStripMenuItem.Name = "materieToolStripMenuItem";
            this.materieToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.materieToolStripMenuItem.Text = "Materie";
            // 
            // adaugaToolStripMenuItem1
            // 
            this.adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            this.adaugaToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.adaugaToolStripMenuItem1.Text = "Adauga";
            this.adaugaToolStripMenuItem1.Click += new System.EventHandler(this.adaugaToolStripMenuItem1_Click);
            // 
            // stergeToolStripMenuItem1
            // 
            this.stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            this.stergeToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.stergeToolStripMenuItem1.Text = "Sterge";
            this.stergeToolStripMenuItem1.Click += new System.EventHandler(this.stergeToolStripMenuItem1_Click);
            // 
            // lblStatistici
            // 
            this.lblStatistici.AutoSize = true;
            this.lblStatistici.BackColor = System.Drawing.Color.Transparent;
            this.lblStatistici.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistici.Location = new System.Drawing.Point(342, 30);
            this.lblStatistici.Name = "lblStatistici";
            this.lblStatistici.Size = new System.Drawing.Size(28, 15);
            this.lblStatistici.TabIndex = 22;
            this.lblStatistici.Text = "stat";
            // 
            // tbCautare
            // 
            this.tbCautare.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCautare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCautare.Location = new System.Drawing.Point(687, 26);
            this.tbCautare.Name = "tbCautare";
            this.tbCautare.Size = new System.Drawing.Size(100, 20);
            this.tbCautare.TabIndex = 23;
            this.tbCautare.TextChanged += new System.EventHandler(this.tbCautare_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(698, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Sterge Profesor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(637, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cauta:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(61, 338);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._2ryt05p7sm0d1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbCautare);
            this.Controls.Add(this.lblStatistici);
            this.Controls.Add(this.btnStergeOrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbZiua);
            this.Controls.Add(this.btnAfiseazaOrar);
            this.Controls.Add(this.btnAdaugaInOrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOra);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.cmbTitlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProfesori);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesori)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTitlu;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.ComboBox cmbOra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdaugaInOrar;
        private System.Windows.Forms.Button btnAfiseazaOrar;
        private System.Windows.Forms.ComboBox cmbZiua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStergeOrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label lblStatistici;
        private System.Windows.Forms.TextBox tbCautare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBinaryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graficSaliToolStripMenuItem;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
    }
}

