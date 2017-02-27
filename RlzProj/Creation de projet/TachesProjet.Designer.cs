namespace RlzProj.Creation_de_projet
{
    partial class TachesProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TachesProjet));
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTacheProjet = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Ajouter_Tache = new System.Windows.Forms.Button();
            this.txt_laTache = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tacheAttribueA = new System.Windows.Forms.ComboBox();
            this.txt_statutTache = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblErrorInfos = new System.Windows.Forms.Label();
            this.tachesProjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlzDs = new RlzProj.RlzDs();
            this.tachesProjTableAdapter = new RlzProj.RlzDsTableAdapters.TachesProjTableAdapter();
            this.tableAdapterManager = new RlzProj.RlzDsTableAdapters.TableAdapterManager();
            this.ItemTemplate = new Microsoft.VisualBasic.PowerPacks.DataRepeaterItem();
            this.pnlFicheProjet = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tachesProjBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_FilterTaches = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Filter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.laTacheTextBox2 = new System.Windows.Forms.TextBox();
            this.statutTacheLabel3 = new System.Windows.Forms.Label();
            this.tacheAttribueANomLabel3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tacheAttribueANomLabel2 = new System.Windows.Forms.Label();
            this.statutTacheLabel2 = new System.Windows.Forms.Label();
            this.laTacheTextBox = new System.Windows.Forms.TextBox();
            this.tacheAttribueANomLabel1 = new System.Windows.Forms.Label();
            this.statutTacheLabel1 = new System.Windows.Forms.Label();
            this.laTacheTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTacheProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tachesProjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).BeginInit();
            this.pnlFicheProjet.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tachesProjBindingNavigator)).BeginInit();
            this.tachesProjBindingNavigator.SuspendLayout();
            this.dataRepeater.ItemTemplate.SuspendLayout();
            this.dataRepeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "TACHES / JALONS PROJET";
            // 
            // pnlTacheProjet
            // 
            this.pnlTacheProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTacheProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTacheProjet.Controls.Add(this.label4);
            this.pnlTacheProjet.Controls.Add(this.btn_Ajouter_Tache);
            this.pnlTacheProjet.Controls.Add(this.txt_laTache);
            this.pnlTacheProjet.Controls.Add(this.label5);
            this.pnlTacheProjet.Controls.Add(this.txt_tacheAttribueA);
            this.pnlTacheProjet.Controls.Add(this.txt_statutTache);
            this.pnlTacheProjet.Controls.Add(this.label10);
            this.pnlTacheProjet.Controls.Add(this.label1);
            this.pnlTacheProjet.Location = new System.Drawing.Point(24, 33);
            this.pnlTacheProjet.Name = "pnlTacheProjet";
            this.pnlTacheProjet.Size = new System.Drawing.Size(290, 235);
            this.pnlTacheProjet.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "La Tache*";
            // 
            // btn_Ajouter_Tache
            // 
            this.btn_Ajouter_Tache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Ajouter_Tache.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Ajouter_Tache.FlatAppearance.BorderSize = 0;
            this.btn_Ajouter_Tache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter_Tache.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter_Tache.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter_Tache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ajouter_Tache.Location = new System.Drawing.Point(245, 0);
            this.btn_Ajouter_Tache.Name = "btn_Ajouter_Tache";
            this.btn_Ajouter_Tache.Size = new System.Drawing.Size(43, 233);
            this.btn_Ajouter_Tache.TabIndex = 2;
            this.btn_Ajouter_Tache.Text = "+";
            this.btn_Ajouter_Tache.UseVisualStyleBackColor = false;
            this.btn_Ajouter_Tache.Click += new System.EventHandler(this.btn_Ajouter_Tache_Click);
            // 
            // txt_laTache
            // 
            this.txt_laTache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_laTache.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_laTache.Location = new System.Drawing.Point(14, 156);
            this.txt_laTache.MaxLength = 240;
            this.txt_laTache.Multiline = true;
            this.txt_laTache.Name = "txt_laTache";
            this.txt_laTache.Size = new System.Drawing.Size(222, 50);
            this.txt_laTache.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 68;
            this.label5.Text = "Statut de la tache";
            // 
            // txt_tacheAttribueA
            // 
            this.txt_tacheAttribueA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_tacheAttribueA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_tacheAttribueA.FormattingEnabled = true;
            this.txt_tacheAttribueA.Location = new System.Drawing.Point(14, 54);
            this.txt_tacheAttribueA.Name = "txt_tacheAttribueA";
            this.txt_tacheAttribueA.Size = new System.Drawing.Size(222, 27);
            this.txt_tacheAttribueA.TabIndex = 0;
            // 
            // txt_statutTache
            // 
            this.txt_statutTache.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_statutTache.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_statutTache.FormattingEnabled = true;
            this.txt_statutTache.Items.AddRange(new object[] {
            "Nouvelle tache",
            "En cours",
            "En Attente",
            "Terminer"});
            this.txt_statutTache.Location = new System.Drawing.Point(14, 105);
            this.txt_statutTache.Name = "txt_statutTache";
            this.txt_statutTache.Size = new System.Drawing.Size(222, 27);
            this.txt_statutTache.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(4, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Notifications :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Tache Attribuer à*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "NOUVELLES TACHES";
            // 
            // lblErrorInfos
            // 
            this.lblErrorInfos.AutoSize = true;
            this.lblErrorInfos.BackColor = System.Drawing.Color.Crimson;
            this.lblErrorInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorInfos.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblErrorInfos.ForeColor = System.Drawing.Color.White;
            this.lblErrorInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorInfos.Location = new System.Drawing.Point(0, 528);
            this.lblErrorInfos.Name = "lblErrorInfos";
            this.lblErrorInfos.Size = new System.Drawing.Size(15, 17);
            this.lblErrorInfos.TabIndex = 46;
            this.lblErrorInfos.Text = "+";
            // 
            // tachesProjBindingSource
            // 
            this.tachesProjBindingSource.DataMember = "TachesProj";
            this.tachesProjBindingSource.DataSource = this.rlzDs;
            // 
            // rlzDs
            // 
            this.rlzDs.DataSetName = "RlzDs";
            this.rlzDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tachesProjTableAdapter
            // 
            this.tachesProjTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetProjTableAdapter = null;
            this.tableAdapterManager.EquipeProjTableAdapter = null;
            this.tableAdapterManager.FicheProjTableAdapter = null;
            this.tableAdapterManager.TachesProjTableAdapter = this.tachesProjTableAdapter;
            this.tableAdapterManager.UpdateOrder = RlzProj.RlzDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ItemTemplate
            // 
            this.ItemTemplate.BackColor = System.Drawing.Color.Silver;
            this.ItemTemplate.Margin = new System.Windows.Forms.Padding(10);
            this.ItemTemplate.Size = new System.Drawing.Size(501, 79);
            // 
            // pnlFicheProjet
            // 
            this.pnlFicheProjet.BackColor = System.Drawing.Color.Transparent;
            this.pnlFicheProjet.Controls.Add(this.panel1);
            this.pnlFicheProjet.Controls.Add(this.pnlTacheProjet);
            this.pnlFicheProjet.Location = new System.Drawing.Point(103, 70);
            this.pnlFicheProjet.Name = "pnlFicheProjet";
            this.pnlFicheProjet.Size = new System.Drawing.Size(825, 448);
            this.pnlFicheProjet.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(24, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 35);
            this.panel1.TabIndex = 52;
            // 
            // tachesProjBindingNavigator
            // 
            this.tachesProjBindingNavigator.AddNewItem = null;
            this.tachesProjBindingNavigator.AutoSize = false;
            this.tachesProjBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tachesProjBindingNavigator.BindingSource = this.tachesProjBindingSource;
            this.tachesProjBindingNavigator.CountItem = null;
            this.tachesProjBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tachesProjBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tachesProjBindingNavigator.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tachesProjBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tachesProjBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.toolStripSeparator1,
            this.cmb_FilterTaches,
            this.btn_Filter,
            this.toolStripSeparator2});
            this.tachesProjBindingNavigator.Location = new System.Drawing.Point(423, 67);
            this.tachesProjBindingNavigator.MoveFirstItem = null;
            this.tachesProjBindingNavigator.MoveLastItem = null;
            this.tachesProjBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tachesProjBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tachesProjBindingNavigator.Name = "tachesProjBindingNavigator";
            this.tachesProjBindingNavigator.PositionItem = null;
            this.tachesProjBindingNavigator.Size = new System.Drawing.Size(505, 32);
            this.tachesProjBindingNavigator.TabIndex = 4;
            this.tachesProjBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::RlzProj.Properties.Resources.fermer_icone_3746_481;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(129, 29);
            this.bindingNavigatorDeleteItem.Text = "Retirer la tache";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // cmb_FilterTaches
            // 
            this.cmb_FilterTaches.BackColor = System.Drawing.Color.White;
            this.cmb_FilterTaches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FilterTaches.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmb_FilterTaches.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_FilterTaches.Items.AddRange(new object[] {
            "Tous",
            "Nouvelle tache",
            "En cours",
            "En Attente",
            "Terminer"});
            this.cmb_FilterTaches.Name = "cmb_FilterTaches";
            this.cmb_FilterTaches.Size = new System.Drawing.Size(150, 32);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Image = global::RlzProj.Properties.Resources.loupe_icone_4171_32;
            this.btn_Filter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(67, 29);
            this.btn_Filter.Text = "Filtrer";
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // dataRepeater
            // 
            this.dataRepeater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataRepeater.BackgroundImage = global::RlzProj.Properties.Resources.clients_contacts_clients_usercard_icone_7853_48;
            this.dataRepeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dataRepeater.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dataRepeater.ItemHeaderSize = 8;
            // 
            // dataRepeater.ItemTemplate
            // 
            this.dataRepeater.ItemTemplate.Controls.Add(this.laTacheTextBox2);
            this.dataRepeater.ItemTemplate.Controls.Add(this.statutTacheLabel3);
            this.dataRepeater.ItemTemplate.Controls.Add(this.tacheAttribueANomLabel3);
            this.dataRepeater.ItemTemplate.Size = new System.Drawing.Size(494, 67);
            this.dataRepeater.Location = new System.Drawing.Point(423, 98);
            this.dataRepeater.Name = "dataRepeater";
            this.dataRepeater.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataRepeater.Size = new System.Drawing.Size(502, 420);
            this.dataRepeater.TabIndex = 0;
            this.dataRepeater.Text = "DataRep";
            // 
            // laTacheTextBox2
            // 
            this.laTacheTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laTacheTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "laTache", true));
            this.laTacheTextBox2.Location = new System.Drawing.Point(34, 8);
            this.laTacheTextBox2.Multiline = true;
            this.laTacheTextBox2.Name = "laTacheTextBox2";
            this.laTacheTextBox2.Size = new System.Drawing.Size(222, 50);
            this.laTacheTextBox2.TabIndex = 5;
            // 
            // statutTacheLabel3
            // 
            this.statutTacheLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "StatutTache", true));
            this.statutTacheLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statutTacheLabel3.Location = new System.Drawing.Point(288, 10);
            this.statutTacheLabel3.Name = "statutTacheLabel3";
            this.statutTacheLabel3.Size = new System.Drawing.Size(164, 23);
            this.statutTacheLabel3.TabIndex = 3;
            this.statutTacheLabel3.Text = "label9";
            // 
            // tacheAttribueANomLabel3
            // 
            this.tacheAttribueANomLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "TacheAttribueANom", true));
            this.tacheAttribueANomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tacheAttribueANomLabel3.Location = new System.Drawing.Point(288, 33);
            this.tacheAttribueANomLabel3.Name = "tacheAttribueANomLabel3";
            this.tacheAttribueANomLabel3.Size = new System.Drawing.Size(164, 23);
            this.tacheAttribueANomLabel3.TabIndex = 1;
            this.tacheAttribueANomLabel3.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(235, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Tache Attribuer à:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(235, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Statut de la tache:";
            // 
            // tacheAttribueANomLabel2
            // 
            this.tacheAttribueANomLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "TacheAttribueANom", true));
            this.tacheAttribueANomLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tacheAttribueANomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tacheAttribueANomLabel2.Location = new System.Drawing.Point(372, 33);
            this.tacheAttribueANomLabel2.Name = "tacheAttribueANomLabel2";
            this.tacheAttribueANomLabel2.Size = new System.Drawing.Size(100, 23);
            this.tacheAttribueANomLabel2.TabIndex = 7;
            this.tacheAttribueANomLabel2.Text = "AttribuéA";
            // 
            // statutTacheLabel2
            // 
            this.statutTacheLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "StatutTache", true));
            this.statutTacheLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.statutTacheLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statutTacheLabel2.Location = new System.Drawing.Point(372, 8);
            this.statutTacheLabel2.Name = "statutTacheLabel2";
            this.statutTacheLabel2.Size = new System.Drawing.Size(100, 23);
            this.statutTacheLabel2.TabIndex = 6;
            this.statutTacheLabel2.Text = "Statut";
            // 
            // laTacheTextBox
            // 
            this.laTacheTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laTacheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "laTache", true));
            this.laTacheTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.laTacheTextBox.Location = new System.Drawing.Point(7, 6);
            this.laTacheTextBox.Multiline = true;
            this.laTacheTextBox.Name = "laTacheTextBox";
            this.laTacheTextBox.ReadOnly = true;
            this.laTacheTextBox.Size = new System.Drawing.Size(222, 50);
            this.laTacheTextBox.TabIndex = 5;
            this.laTacheTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tacheAttribueANomLabel1
            // 
            this.tacheAttribueANomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tacheAttribueANomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "TacheAttribueANom", true));
            this.tacheAttribueANomLabel1.ForeColor = System.Drawing.Color.White;
            this.tacheAttribueANomLabel1.Location = new System.Drawing.Point(61, 26);
            this.tacheAttribueANomLabel1.Name = "tacheAttribueANomLabel1";
            this.tacheAttribueANomLabel1.Size = new System.Drawing.Size(125, 23);
            this.tacheAttribueANomLabel1.TabIndex = 55;
            this.tacheAttribueANomLabel1.Text = "AttribuerA";
            // 
            // statutTacheLabel1
            // 
            this.statutTacheLabel1.BackColor = System.Drawing.Color.Transparent;
            this.statutTacheLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "StatutTache", true));
            this.statutTacheLabel1.ForeColor = System.Drawing.Color.White;
            this.statutTacheLabel1.Location = new System.Drawing.Point(61, 49);
            this.statutTacheLabel1.Name = "statutTacheLabel1";
            this.statutTacheLabel1.Size = new System.Drawing.Size(82, 20);
            this.statutTacheLabel1.TabIndex = 54;
            this.statutTacheLabel1.Text = "Statut";
            // 
            // laTacheTextBox1
            // 
            this.laTacheTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laTacheTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tachesProjBindingSource, "laTache", true));
            this.laTacheTextBox1.Location = new System.Drawing.Point(188, 4);
            this.laTacheTextBox1.MaxLength = 240;
            this.laTacheTextBox1.Multiline = true;
            this.laTacheTextBox1.Name = "laTacheTextBox1";
            this.laTacheTextBox1.ReadOnly = true;
            this.laTacheTextBox1.Size = new System.Drawing.Size(302, 71);
            this.laTacheTextBox1.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(61, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tache Attribuer à:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RlzProj.Properties.Resources.clients_contacts_clients_usercard_icone_7853_481;
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RlzProj.Properties.Resources.bgback;
            this.panel2.Controls.Add(this.tachesProjBindingNavigator);
            this.panel2.Controls.Add(this.dataRepeater);
            this.panel2.Controls.Add(this.lblErrorInfos);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pnlFicheProjet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 545);
            this.panel2.TabIndex = 52;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1055, 46);
            this.panel4.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(438, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "ORGANISER VOS TACHES";
            // 
            // TachesProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TachesProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.TachesProjet_Load);
            this.pnlTacheProjet.ResumeLayout(false);
            this.pnlTacheProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tachesProjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).EndInit();
            this.pnlFicheProjet.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tachesProjBindingNavigator)).EndInit();
            this.tachesProjBindingNavigator.ResumeLayout(false);
            this.tachesProjBindingNavigator.PerformLayout();
            this.dataRepeater.ItemTemplate.ResumeLayout(false);
            this.dataRepeater.ItemTemplate.PerformLayout();
            this.dataRepeater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlTacheProjet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Ajouter_Tache;
        private System.Windows.Forms.TextBox txt_laTache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_tacheAttribueA;
        private System.Windows.Forms.ComboBox txt_statutTache;
        private System.Windows.Forms.Label lblErrorInfos;
        private RlzDs rlzDs;
        private System.Windows.Forms.BindingSource tachesProjBindingSource;
        private RlzDsTableAdapters.TachesProjTableAdapter tachesProjTableAdapter;
        private RlzDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel pnlFicheProjet;
        private System.Windows.Forms.BindingNavigator tachesProjBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmb_FilterTaches;
        private System.Windows.Forms.ToolStripButton btn_Filter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater;
        private System.Windows.Forms.Label tacheAttribueANomLabel1;
        private System.Windows.Forms.Label statutTacheLabel1;
        private System.Windows.Forms.TextBox laTacheTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox laTacheTextBox;
        private Microsoft.VisualBasic.PowerPacks.DataRepeaterItem ItemTemplate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tacheAttribueANomLabel2;
        private System.Windows.Forms.Label statutTacheLabel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox laTacheTextBox2;
        private System.Windows.Forms.Label statutTacheLabel3;
        private System.Windows.Forms.Label tacheAttribueANomLabel3;
    }
}