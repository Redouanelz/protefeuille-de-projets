namespace RlzProj.Profile
{
    partial class MesTaches
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesTaches));
            this.dg_MyTasks = new System.Windows.Forms.DataGridView();
            this.pnlFicheProjet = new System.Windows.Forms.Panel();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDPerso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDProjet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomProjet = new System.Windows.Forms.TextBox();
            this.txtIDtache = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnregistrerTache = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStatut = new System.Windows.Forms.ComboBox();
            this.txt_LaTache = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSupprimerTache = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_MyTasks)).BeginInit();
            this.pnlFicheProjet.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_MyTasks
            // 
            this.dg_MyTasks.AllowUserToAddRows = false;
            this.dg_MyTasks.AllowUserToDeleteRows = false;
            this.dg_MyTasks.AllowUserToResizeColumns = false;
            this.dg_MyTasks.AllowUserToResizeRows = false;
            this.dg_MyTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_MyTasks.BackgroundColor = System.Drawing.Color.White;
            this.dg_MyTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_MyTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_MyTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_MyTasks.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_MyTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_MyTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_MyTasks.Location = new System.Drawing.Point(372, 164);
            this.dg_MyTasks.MultiSelect = false;
            this.dg_MyTasks.Name = "dg_MyTasks";
            this.dg_MyTasks.ReadOnly = true;
            this.dg_MyTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dg_MyTasks.RowHeadersWidth = 10;
            this.dg_MyTasks.RowTemplate.Height = 50;
            this.dg_MyTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_MyTasks.Size = new System.Drawing.Size(588, 307);
            this.dg_MyTasks.TabIndex = 32;
            this.dg_MyTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_MyTasks_CellClick);
            this.dg_MyTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_MyTasks_CellContentClick);
            // 
            // pnlFicheProjet
            // 
            this.pnlFicheProjet.BackColor = System.Drawing.Color.White;
            this.pnlFicheProjet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFicheProjet.Controls.Add(this.lblNotif);
            this.pnlFicheProjet.Controls.Add(this.btnSuivant);
            this.pnlFicheProjet.Controls.Add(this.panel4);
            this.pnlFicheProjet.Controls.Add(this.btnEnregistrerTache);
            this.pnlFicheProjet.Controls.Add(this.btnPrecedent);
            this.pnlFicheProjet.Controls.Add(this.dg_MyTasks);
            this.pnlFicheProjet.Controls.Add(this.panel1);
            this.pnlFicheProjet.Controls.Add(this.panel2);
            this.pnlFicheProjet.Controls.Add(this.btnSupprimerTache);
            this.pnlFicheProjet.Controls.Add(this.label8);
            this.pnlFicheProjet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFicheProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.pnlFicheProjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFicheProjet.Location = new System.Drawing.Point(0, 0);
            this.pnlFicheProjet.Name = "pnlFicheProjet";
            this.pnlFicheProjet.Size = new System.Drawing.Size(1055, 545);
            this.pnlFicheProjet.TabIndex = 34;
            // 
            // btnSuivant
            // 
            this.btnSuivant.BackColor = System.Drawing.Color.Transparent;
            this.btnSuivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuivant.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnSuivant.ForeColor = System.Drawing.Color.Black;
            this.btnSuivant.Location = new System.Drawing.Point(231, 440);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(135, 31);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = false;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtIDPerso);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtIDProjet);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtNomProjet);
            this.panel4.Controls.Add(this.txtIDtache);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(372, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 89);
            this.panel4.TabIndex = 57;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.BackColor = System.Drawing.Color.Crimson;
            this.lblNotif.Font = new System.Drawing.Font("Calibri", 8F);
            this.lblNotif.ForeColor = System.Drawing.Color.White;
            this.lblNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNotif.Location = new System.Drawing.Point(369, 474);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(108, 13);
            this.lblNotif.TabIndex = 54;
            this.lblNotif.Text = "Notifications : Aucune";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Autres informations :";
            // 
            // txtIDPerso
            // 
            this.txtIDPerso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIDPerso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDPerso.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPerso.ForeColor = System.Drawing.Color.Black;
            this.txtIDPerso.Location = new System.Drawing.Point(459, 47);
            this.txtIDPerso.MaxLength = 49;
            this.txtIDPerso.Name = "txtIDPerso";
            this.txtIDPerso.ReadOnly = true;
            this.txtIDPerso.Size = new System.Drawing.Size(82, 27);
            this.txtIDPerso.TabIndex = 51;
            this.txtIDPerso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(45, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nom du projet ";
            // 
            // txtIDProjet
            // 
            this.txtIDProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIDProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProjet.ForeColor = System.Drawing.Color.Black;
            this.txtIDProjet.Location = new System.Drawing.Point(372, 47);
            this.txtIDProjet.MaxLength = 49;
            this.txtIDProjet.Name = "txtIDProjet";
            this.txtIDProjet.ReadOnly = true;
            this.txtIDProjet.Size = new System.Drawing.Size(82, 27);
            this.txtIDProjet.TabIndex = 50;
            this.txtIDProjet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(368, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID Projet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID Tache";
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNomProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomProjet.ForeColor = System.Drawing.Color.Black;
            this.txtNomProjet.Location = new System.Drawing.Point(49, 47);
            this.txtNomProjet.MaxLength = 49;
            this.txtNomProjet.Name = "txtNomProjet";
            this.txtNomProjet.ReadOnly = true;
            this.txtNomProjet.Size = new System.Drawing.Size(225, 27);
            this.txtNomProjet.TabIndex = 0;
            this.txtNomProjet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDtache
            // 
            this.txtIDtache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtIDtache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDtache.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDtache.ForeColor = System.Drawing.Color.Black;
            this.txtIDtache.Location = new System.Drawing.Point(284, 47);
            this.txtIDtache.MaxLength = 49;
            this.txtIDtache.Name = "txtIDtache";
            this.txtIDtache.ReadOnly = true;
            this.txtIDtache.Size = new System.Drawing.Size(82, 27);
            this.txtIDtache.TabIndex = 49;
            this.txtIDtache.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(455, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID Perso";
            // 
            // btnEnregistrerTache
            // 
            this.btnEnregistrerTache.BackColor = System.Drawing.Color.Transparent;
            this.btnEnregistrerTache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnEnregistrerTache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerTache.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnEnregistrerTache.ForeColor = System.Drawing.Color.Black;
            this.btnEnregistrerTache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrerTache.Location = new System.Drawing.Point(91, 358);
            this.btnEnregistrerTache.Name = "btnEnregistrerTache";
            this.btnEnregistrerTache.Size = new System.Drawing.Size(275, 35);
            this.btnEnregistrerTache.TabIndex = 2;
            this.btnEnregistrerTache.Text = "&MODIFIER LA TACHE";
            this.btnEnregistrerTache.UseVisualStyleBackColor = false;
            this.btnEnregistrerTache.Click += new System.EventHandler(this.btnEnregistrerTache_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.Transparent;
            this.btnPrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecedent.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnPrecedent.ForeColor = System.Drawing.Color.Black;
            this.btnPrecedent.Location = new System.Drawing.Point(91, 440);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(135, 31);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 50);
            this.panel1.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "ORGANISER VOS TACHES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtStatut);
            this.panel2.Controls.Add(this.txt_LaTache);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(91, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 188);
            this.panel2.TabIndex = 55;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "informations sur la tache :";
            // 
            // txtStatut
            // 
            this.txtStatut.BackColor = System.Drawing.Color.White;
            this.txtStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatut.FormattingEnabled = true;
            this.txtStatut.Items.AddRange(new object[] {
            "Nouvelle tache",
            "En cours",
            "En Attente",
            "Terminer"});
            this.txtStatut.Location = new System.Drawing.Point(15, 143);
            this.txtStatut.Name = "txtStatut";
            this.txtStatut.Size = new System.Drawing.Size(242, 27);
            this.txtStatut.TabIndex = 0;
            // 
            // txt_LaTache
            // 
            this.txt_LaTache.BackColor = System.Drawing.Color.White;
            this.txt_LaTache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LaTache.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LaTache.ForeColor = System.Drawing.Color.Black;
            this.txt_LaTache.Location = new System.Drawing.Point(15, 63);
            this.txt_LaTache.MaxLength = 240;
            this.txt_LaTache.Multiline = true;
            this.txt_LaTache.Name = "txt_LaTache";
            this.txt_LaTache.Size = new System.Drawing.Size(242, 50);
            this.txt_LaTache.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(31, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Modifier le statut de la tache:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(46, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Description de la tache :";
            // 
            // btnSupprimerTache
            // 
            this.btnSupprimerTache.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimerTache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSupprimerTache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerTache.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnSupprimerTache.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimerTache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerTache.Location = new System.Drawing.Point(91, 399);
            this.btnSupprimerTache.Name = "btnSupprimerTache";
            this.btnSupprimerTache.Size = new System.Drawing.Size(275, 35);
            this.btnSupprimerTache.TabIndex = 3;
            this.btnSupprimerTache.Text = "&SUPPRIMER LA TACHE";
            this.btnSupprimerTache.UseVisualStyleBackColor = false;
            this.btnSupprimerTache.Click += new System.EventHandler(this.btnSupprimerTache_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(215, 61);
            this.label8.TabIndex = 60;
            this.label8.Text = "Vous pouvez suivre l\'état de toutes \r\nvos taches en toutes simplicité,\r\nles modif" +
                "ier ou bien supprimer.\r\n";
            // 
            // MesTaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.pnlFicheProjet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesTaches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Taches";
            this.Load += new System.EventHandler(this.MesTaches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_MyTasks)).EndInit();
            this.pnlFicheProjet.ResumeLayout(false);
            this.pnlFicheProjet.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_MyTasks;
        private System.Windows.Forms.Panel pnlFicheProjet;
        private System.Windows.Forms.TextBox txtIDPerso;
        private System.Windows.Forms.TextBox txtIDProjet;
        private System.Windows.Forms.TextBox txtIDtache;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomProjet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnSupprimerTache;
        private System.Windows.Forms.ComboBox txtStatut;
        private System.Windows.Forms.TextBox txt_LaTache;
        private System.Windows.Forms.Button btnEnregistrerTache;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}