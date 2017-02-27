namespace RlzProj.Creation_de_projet
{
    partial class BudgetProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetProjet));
            this.txt_Autres_RF = new System.Windows.Forms.TextBox();
            this.rAutres = new System.Windows.Forms.RadioButton();
            this.rAlimentationLogement = new System.Windows.Forms.RadioButton();
            this.rInvestisement = new System.Windows.Forms.RadioButton();
            this.rMachinismeVehicules = new System.Windows.Forms.RadioButton();
            this.rDepenseFonctionnement = new System.Windows.Forms.RadioButton();
            this.txt_Budget_RF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Ajouter_RF = new System.Windows.Forms.Button();
            this.txt_Moyens_RH = new System.Windows.Forms.ComboBox();
            this.txt_Budget_RH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ajouter_RH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFicheProjet = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.btn_ShowBudgetChart = new System.Windows.Forms.Button();
            this.dataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.raisonBudgetTextBox1 = new System.Windows.Forms.TextBox();
            this.budgetProjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlzDs = new RlzProj.RlzDs();
            this.budgetAttribueANomTextBox1 = new System.Windows.Forms.TextBox();
            this.budgetTextBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.budgetAttribueANomTextBox = new System.Windows.Forms.TextBox();
            this.raisonBudgetTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.budgetLabel1 = new System.Windows.Forms.Label();
            this.raisonBudgetLabel1 = new System.Windows.Forms.Label();
            this.budgetAttribueANomLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorInfos = new System.Windows.Forms.Label();
            this.budgetProjTableAdapter = new RlzProj.RlzDsTableAdapters.BudgetProjTableAdapter();
            this.tableAdapterManager = new RlzProj.RlzDsTableAdapters.TableAdapterManager();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlFicheProjet.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.dataRepeater.ItemTemplate.SuspendLayout();
            this.dataRepeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetProjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Autres_RF
            // 
            this.txt_Autres_RF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Autres_RF.Font = new System.Drawing.Font("Calibri", 8F);
            this.txt_Autres_RF.ForeColor = System.Drawing.Color.Black;
            this.txt_Autres_RF.Location = new System.Drawing.Point(80, 152);
            this.txt_Autres_RF.MaxLength = 49;
            this.txt_Autres_RF.Name = "txt_Autres_RF";
            this.txt_Autres_RF.Size = new System.Drawing.Size(150, 21);
            this.txt_Autres_RF.TabIndex = 9;
            // 
            // rAutres
            // 
            this.rAutres.AutoSize = true;
            this.rAutres.BackColor = System.Drawing.Color.Transparent;
            this.rAutres.Font = new System.Drawing.Font("Calibri", 9F);
            this.rAutres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rAutres.Location = new System.Drawing.Point(19, 153);
            this.rAutres.Name = "rAutres";
            this.rAutres.Size = new System.Drawing.Size(60, 18);
            this.rAutres.TabIndex = 8;
            this.rAutres.TabStop = true;
            this.rAutres.Text = "Autres";
            this.rAutres.UseVisualStyleBackColor = false;
            // 
            // rAlimentationLogement
            // 
            this.rAlimentationLogement.AutoSize = true;
            this.rAlimentationLogement.BackColor = System.Drawing.Color.Transparent;
            this.rAlimentationLogement.Font = new System.Drawing.Font("Calibri", 9F);
            this.rAlimentationLogement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rAlimentationLogement.Location = new System.Drawing.Point(19, 135);
            this.rAlimentationLogement.Name = "rAlimentationLogement";
            this.rAlimentationLogement.Size = new System.Drawing.Size(166, 18);
            this.rAlimentationLogement.TabIndex = 7;
            this.rAlimentationLogement.TabStop = true;
            this.rAlimentationLogement.Text = "Alimentation et Logement";
            this.rAlimentationLogement.UseVisualStyleBackColor = false;
            // 
            // rInvestisement
            // 
            this.rInvestisement.AutoSize = true;
            this.rInvestisement.BackColor = System.Drawing.Color.Transparent;
            this.rInvestisement.Font = new System.Drawing.Font("Calibri", 9F);
            this.rInvestisement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rInvestisement.Location = new System.Drawing.Point(19, 81);
            this.rInvestisement.Name = "rInvestisement";
            this.rInvestisement.Size = new System.Drawing.Size(102, 18);
            this.rInvestisement.TabIndex = 4;
            this.rInvestisement.TabStop = true;
            this.rInvestisement.Text = "Investisement";
            this.rInvestisement.UseVisualStyleBackColor = false;
            // 
            // rMachinismeVehicules
            // 
            this.rMachinismeVehicules.AutoSize = true;
            this.rMachinismeVehicules.BackColor = System.Drawing.Color.Transparent;
            this.rMachinismeVehicules.Font = new System.Drawing.Font("Calibri", 9F);
            this.rMachinismeVehicules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rMachinismeVehicules.Location = new System.Drawing.Point(19, 117);
            this.rMachinismeVehicules.Name = "rMachinismeVehicules";
            this.rMachinismeVehicules.Size = new System.Drawing.Size(161, 18);
            this.rMachinismeVehicules.TabIndex = 6;
            this.rMachinismeVehicules.TabStop = true;
            this.rMachinismeVehicules.Text = "Machinisme et véhicules";
            this.rMachinismeVehicules.UseVisualStyleBackColor = false;
            // 
            // rDepenseFonctionnement
            // 
            this.rDepenseFonctionnement.AutoSize = true;
            this.rDepenseFonctionnement.BackColor = System.Drawing.Color.Transparent;
            this.rDepenseFonctionnement.Font = new System.Drawing.Font("Calibri", 9F);
            this.rDepenseFonctionnement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rDepenseFonctionnement.Location = new System.Drawing.Point(19, 99);
            this.rDepenseFonctionnement.Name = "rDepenseFonctionnement";
            this.rDepenseFonctionnement.Size = new System.Drawing.Size(180, 18);
            this.rDepenseFonctionnement.TabIndex = 5;
            this.rDepenseFonctionnement.TabStop = true;
            this.rDepenseFonctionnement.Text = "Dépense de fonctionnement";
            this.rDepenseFonctionnement.UseVisualStyleBackColor = false;
            // 
            // txt_Budget_RF
            // 
            this.txt_Budget_RF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Budget_RF.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Budget_RF.ForeColor = System.Drawing.Color.Black;
            this.txt_Budget_RF.Location = new System.Drawing.Point(17, 48);
            this.txt_Budget_RF.MaxLength = 49;
            this.txt_Budget_RF.Name = "txt_Budget_RF";
            this.txt_Budget_RF.Size = new System.Drawing.Size(213, 30);
            this.txt_Budget_RF.TabIndex = 3;
            this.txt_Budget_RF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Budget_RF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Budget_RF_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Budget (DH)*";
            // 
            // btn_Ajouter_RF
            // 
            this.btn_Ajouter_RF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Ajouter_RF.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Ajouter_RF.FlatAppearance.BorderSize = 0;
            this.btn_Ajouter_RF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter_RF.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter_RF.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter_RF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ajouter_RF.Location = new System.Drawing.Point(234, 0);
            this.btn_Ajouter_RF.Name = "btn_Ajouter_RF";
            this.btn_Ajouter_RF.Size = new System.Drawing.Size(43, 186);
            this.btn_Ajouter_RF.TabIndex = 10;
            this.btn_Ajouter_RF.Text = "+";
            this.btn_Ajouter_RF.UseVisualStyleBackColor = false;
            this.btn_Ajouter_RF.Click += new System.EventHandler(this.btn_Ajouter_RF_Click);
            // 
            // txt_Moyens_RH
            // 
            this.txt_Moyens_RH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Moyens_RH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Moyens_RH.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Moyens_RH.ForeColor = System.Drawing.Color.Black;
            this.txt_Moyens_RH.FormattingEnabled = true;
            this.txt_Moyens_RH.Location = new System.Drawing.Point(16, 96);
            this.txt_Moyens_RH.Name = "txt_Moyens_RH";
            this.txt_Moyens_RH.Size = new System.Drawing.Size(214, 27);
            this.txt_Moyens_RH.TabIndex = 1;
            // 
            // txt_Budget_RH
            // 
            this.txt_Budget_RH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Budget_RH.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Budget_RH.ForeColor = System.Drawing.Color.Black;
            this.txt_Budget_RH.Location = new System.Drawing.Point(16, 46);
            this.txt_Budget_RH.MaxLength = 49;
            this.txt_Budget_RH.Name = "txt_Budget_RH";
            this.txt_Budget_RH.Size = new System.Drawing.Size(214, 30);
            this.txt_Budget_RH.TabIndex = 0;
            this.txt_Budget_RH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Budget_RH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Budget_RH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Budget (DH)*";
            // 
            // btn_Ajouter_RH
            // 
            this.btn_Ajouter_RH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Ajouter_RH.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Ajouter_RH.FlatAppearance.BorderSize = 0;
            this.btn_Ajouter_RH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajouter_RH.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ajouter_RH.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter_RH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ajouter_RH.Location = new System.Drawing.Point(234, 0);
            this.btn_Ajouter_RH.Name = "btn_Ajouter_RH";
            this.btn_Ajouter_RH.Size = new System.Drawing.Size(43, 139);
            this.btn_Ajouter_RH.TabIndex = 2;
            this.btn_Ajouter_RH.Text = "+";
            this.btn_Ajouter_RH.UseVisualStyleBackColor = false;
            this.btn_Ajouter_RH.Click += new System.EventHandler(this.btn_Ajouter_RH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Moyens Humains";
            // 
            // pnlFicheProjet
            // 
            this.pnlFicheProjet.BackColor = System.Drawing.Color.Transparent;
            this.pnlFicheProjet.Controls.Add(this.panel2);
            this.pnlFicheProjet.Controls.Add(this.pnlChart);
            this.pnlFicheProjet.Controls.Add(this.dataRepeater);
            this.pnlFicheProjet.Controls.Add(this.bindingNavigator1);
            this.pnlFicheProjet.Controls.Add(this.panel1);
            this.pnlFicheProjet.Location = new System.Drawing.Point(104, 80);
            this.pnlFicheProjet.Name = "pnlFicheProjet";
            this.pnlFicheProjet.Size = new System.Drawing.Size(844, 423);
            this.pnlFicheProjet.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Ajouter_RH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Moyens_RH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_Budget_RH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(38, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 141);
            this.panel2.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "RESOURCES HUMAINES";
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.Crimson;
            this.pnlChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlChart.Controls.Add(this.btn_ShowBudgetChart);
            this.pnlChart.Location = new System.Drawing.Point(322, 373);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(519, 47);
            this.pnlChart.TabIndex = 37;
            // 
            // btn_ShowBudgetChart
            // 
            this.btn_ShowBudgetChart.FlatAppearance.BorderSize = 2;
            this.btn_ShowBudgetChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowBudgetChart.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ShowBudgetChart.ForeColor = System.Drawing.Color.White;
            this.btn_ShowBudgetChart.Image = global::RlzProj.Properties.Resources.diagramme_icone_6234_48;
            this.btn_ShowBudgetChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowBudgetChart.Location = new System.Drawing.Point(15, 6);
            this.btn_ShowBudgetChart.Name = "btn_ShowBudgetChart";
            this.btn_ShowBudgetChart.Size = new System.Drawing.Size(209, 35);
            this.btn_ShowBudgetChart.TabIndex = 12;
            this.btn_ShowBudgetChart.Text = "AFFICHER LE GRAPHIQUE";
            this.btn_ShowBudgetChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ShowBudgetChart.UseVisualStyleBackColor = true;
            this.btn_ShowBudgetChart.Click += new System.EventHandler(this.btn_LoadBudgetChart_Click);
            // 
            // dataRepeater
            // 
            this.dataRepeater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataRepeater.BackgroundImage = global::RlzProj.Properties.Resources.simulateur_icone_7870_48;
            this.dataRepeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dataRepeater.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dataRepeater.ItemHeaderSize = 8;
            // 
            // dataRepeater.ItemTemplate
            // 
            this.dataRepeater.ItemTemplate.Controls.Add(this.raisonBudgetTextBox1);
            this.dataRepeater.ItemTemplate.Controls.Add(this.budgetAttribueANomTextBox1);
            this.dataRepeater.ItemTemplate.Controls.Add(this.budgetTextBox1);
            this.dataRepeater.ItemTemplate.Size = new System.Drawing.Size(511, 46);
            this.dataRepeater.Location = new System.Drawing.Point(322, 0);
            this.dataRepeater.Name = "dataRepeater";
            this.dataRepeater.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataRepeater.Size = new System.Drawing.Size(519, 367);
            this.dataRepeater.TabIndex = 0;
            this.dataRepeater.Text = "DataRep";
            // 
            // raisonBudgetTextBox1
            // 
            this.raisonBudgetTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raisonBudgetTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "RaisonBudget", true));
            this.raisonBudgetTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.raisonBudgetTextBox1.Location = new System.Drawing.Point(169, 11);
            this.raisonBudgetTextBox1.Name = "raisonBudgetTextBox1";
            this.raisonBudgetTextBox1.ReadOnly = true;
            this.raisonBudgetTextBox1.Size = new System.Drawing.Size(149, 27);
            this.raisonBudgetTextBox1.TabIndex = 5;
            this.raisonBudgetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // budgetProjBindingSource
            // 
            this.budgetProjBindingSource.DataMember = "BudgetProj";
            this.budgetProjBindingSource.DataSource = this.rlzDs;
            // 
            // rlzDs
            // 
            this.rlzDs.DataSetName = "RlzDs";
            this.rlzDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetAttribueANomTextBox1
            // 
            this.budgetAttribueANomTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetAttribueANomTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "BudgetAttribueANom", true));
            this.budgetAttribueANomTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.budgetAttribueANomTextBox1.Location = new System.Drawing.Point(324, 11);
            this.budgetAttribueANomTextBox1.Name = "budgetAttribueANomTextBox1";
            this.budgetAttribueANomTextBox1.ReadOnly = true;
            this.budgetAttribueANomTextBox1.Size = new System.Drawing.Size(149, 27);
            this.budgetAttribueANomTextBox1.TabIndex = 3;
            this.budgetAttribueANomTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // budgetTextBox1
            // 
            this.budgetTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "Budget", true));
            this.budgetTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.budgetTextBox1.Location = new System.Drawing.Point(14, 11);
            this.budgetTextBox1.Name = "budgetTextBox1";
            this.budgetTextBox1.ReadOnly = true;
            this.budgetTextBox1.Size = new System.Drawing.Size(149, 27);
            this.budgetTextBox1.TabIndex = 1;
            this.budgetTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bindingNavigator1.BindingSource = this.budgetProjBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.toolStripButton1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(38, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(279, 32);
            this.bindingNavigator1.TabIndex = 52;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::RlzProj.Properties.Resources.fermer_icone_3776_32;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(184, 29);
            this.toolStripButton1.Text = "Retirer le budget selectionner";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Autres_RF);
            this.panel1.Controls.Add(this.btn_Ajouter_RF);
            this.panel1.Controls.Add(this.txt_Budget_RF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rAlimentationLogement);
            this.panel1.Controls.Add(this.rInvestisement);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.rMachinismeVehicules);
            this.panel1.Controls.Add(this.rDepenseFonctionnement);
            this.panel1.Controls.Add(this.rAutres);
            this.panel1.Location = new System.Drawing.Point(38, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 188);
            this.panel1.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "RESOURCES FINANCIERS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(764, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Budget Attribuer à:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(459, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Budget (DH):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(609, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Budget Attribuer pour:";
            // 
            // budgetAttribueANomTextBox
            // 
            this.budgetAttribueANomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetAttribueANomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "BudgetAttribueANom", true));
            this.budgetAttribueANomTextBox.Location = new System.Drawing.Point(295, 14);
            this.budgetAttribueANomTextBox.Name = "budgetAttribueANomTextBox";
            this.budgetAttribueANomTextBox.ReadOnly = true;
            this.budgetAttribueANomTextBox.Size = new System.Drawing.Size(155, 20);
            this.budgetAttribueANomTextBox.TabIndex = 5;
            this.budgetAttribueANomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raisonBudgetTextBox
            // 
            this.raisonBudgetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raisonBudgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "RaisonBudget", true));
            this.raisonBudgetTextBox.Location = new System.Drawing.Point(135, 14);
            this.raisonBudgetTextBox.Name = "raisonBudgetTextBox";
            this.raisonBudgetTextBox.ReadOnly = true;
            this.raisonBudgetTextBox.Size = new System.Drawing.Size(155, 20);
            this.raisonBudgetTextBox.TabIndex = 3;
            this.raisonBudgetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "Budget", true));
            this.budgetTextBox.Location = new System.Drawing.Point(17, 14);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.ReadOnly = true;
            this.budgetTextBox.Size = new System.Drawing.Size(113, 20);
            this.budgetTextBox.TabIndex = 1;
            this.budgetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // budgetLabel1
            // 
            this.budgetLabel1.BackColor = System.Drawing.Color.Maroon;
            this.budgetLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "Budget", true));
            this.budgetLabel1.ForeColor = System.Drawing.Color.White;
            this.budgetLabel1.Location = new System.Drawing.Point(47, 13);
            this.budgetLabel1.Name = "budgetLabel1";
            this.budgetLabel1.Size = new System.Drawing.Size(80, 23);
            this.budgetLabel1.TabIndex = 11;
            this.budgetLabel1.Text = "LeBudget";
            this.budgetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raisonBudgetLabel1
            // 
            this.raisonBudgetLabel1.BackColor = System.Drawing.Color.Transparent;
            this.raisonBudgetLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "RaisonBudget", true));
            this.raisonBudgetLabel1.ForeColor = System.Drawing.Color.White;
            this.raisonBudgetLabel1.Location = new System.Drawing.Point(127, 13);
            this.raisonBudgetLabel1.Name = "raisonBudgetLabel1";
            this.raisonBudgetLabel1.Size = new System.Drawing.Size(147, 23);
            this.raisonBudgetLabel1.TabIndex = 10;
            this.raisonBudgetLabel1.Text = "LaRaison";
            this.raisonBudgetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // budgetAttribueANomLabel1
            // 
            this.budgetAttribueANomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.budgetAttribueANomLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetProjBindingSource, "BudgetAttribueANom", true));
            this.budgetAttribueANomLabel1.ForeColor = System.Drawing.Color.White;
            this.budgetAttribueANomLabel1.Location = new System.Drawing.Point(280, 13);
            this.budgetAttribueANomLabel1.Name = "budgetAttribueANomLabel1";
            this.budgetAttribueANomLabel1.Size = new System.Drawing.Size(139, 23);
            this.budgetAttribueANomLabel1.TabIndex = 8;
            this.budgetAttribueANomLabel1.Text = "LeNom";
            this.budgetAttribueANomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RlzProj.Properties.Resources.simulateur_icone_7870_32;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorInfos
            // 
            this.lblErrorInfos.AutoSize = true;
            this.lblErrorInfos.BackColor = System.Drawing.Color.Crimson;
            this.lblErrorInfos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErrorInfos.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblErrorInfos.ForeColor = System.Drawing.Color.White;
            this.lblErrorInfos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorInfos.Location = new System.Drawing.Point(0, 526);
            this.lblErrorInfos.Name = "lblErrorInfos";
            this.lblErrorInfos.Size = new System.Drawing.Size(15, 17);
            this.lblErrorInfos.TabIndex = 46;
            this.lblErrorInfos.Text = "+";
            // 
            // budgetProjTableAdapter
            // 
            this.budgetProjTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetProjTableAdapter = this.budgetProjTableAdapter;
            this.tableAdapterManager.EquipeProjTableAdapter = null;
            this.tableAdapterManager.FicheProjTableAdapter = null;
            this.tableAdapterManager.TachesProjTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RlzProj.RlzDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::RlzProj.Properties.Resources.bgback;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblErrorInfos);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.pnlFicheProjet);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 545);
            this.panel3.TabIndex = 52;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1053, 46);
            this.panel6.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(445, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "GERER VOTRE BUDGET";
            // 
            // BudgetProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BudgetProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BudgetProjet";
            this.Load += new System.EventHandler(this.BudgetProjet_Load);
            this.pnlFicheProjet.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.dataRepeater.ItemTemplate.ResumeLayout(false);
            this.dataRepeater.ItemTemplate.PerformLayout();
            this.dataRepeater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.budgetProjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_Moyens_RH;
        private System.Windows.Forms.Button btn_Ajouter_RF;
        private System.Windows.Forms.RadioButton rAutres;
        private System.Windows.Forms.RadioButton rAlimentationLogement;
        private System.Windows.Forms.RadioButton rInvestisement;
        private System.Windows.Forms.RadioButton rMachinismeVehicules;
        private System.Windows.Forms.RadioButton rDepenseFonctionnement;
        private System.Windows.Forms.TextBox txt_Budget_RF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Budget_RH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Ajouter_RH;
        private System.Windows.Forms.Panel pnlFicheProjet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErrorInfos;
        private System.Windows.Forms.TextBox txt_Autres_RF;
        private RlzDs rlzDs;
        private System.Windows.Forms.BindingSource budgetProjBindingSource;
        private RlzDsTableAdapters.BudgetProjTableAdapter budgetProjTableAdapter;
        private RlzDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label raisonBudgetLabel1;
        private System.Windows.Forms.Label budgetAttribueANomLabel1;
        private System.Windows.Forms.Label budgetLabel1;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Button btn_ShowBudgetChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox budgetAttribueANomTextBox;
        private System.Windows.Forms.TextBox raisonBudgetTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox raisonBudgetTextBox1;
        private System.Windows.Forms.TextBox budgetAttribueANomTextBox1;
        private System.Windows.Forms.TextBox budgetTextBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}