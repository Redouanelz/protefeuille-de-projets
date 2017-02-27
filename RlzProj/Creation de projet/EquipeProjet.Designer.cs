namespace RlzProj.Creation_de_projet
{
    partial class EquipeProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipeProjet));
            this.label3 = new System.Windows.Forms.Label();
            this.lblErrorInfos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PersonnelChoisi = new System.Windows.Forms.TextBox();
            this.txt_Role = new System.Windows.Forms.ComboBox();
            this.txt_PersonnelID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ChefProjet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAjouterAEquipe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roleSurProjTextBox = new System.Windows.Forms.TextBox();
            this.equipeProjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rlzDs = new RlzProj.RlzDs();
            this.nomMembreEquipeTextBox = new System.Windows.Forms.TextBox();
            this.equipeProjBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roleSurProjLabel1 = new System.Windows.Forms.Label();
            this.nomMembreEquipeLabel1 = new System.Windows.Forms.Label();
            this.equipeProjTableAdapter = new RlzProj.RlzDsTableAdapters.EquipeProjTableAdapter();
            this.tableAdapterManager = new RlzProj.RlzDsTableAdapters.TableAdapterManager();
            this.ficheProjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ficheProjTableAdapter = new RlzProj.RlzDsTableAdapters.FicheProjTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.nomMembreEquipeTextBox1 = new System.Windows.Forms.TextBox();
            this.roleSurProjTextBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFicheProjet = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeProjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeProjBindingNavigator)).BeginInit();
            this.equipeProjBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficheProjBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.dataRepeater.ItemTemplate.SuspendLayout();
            this.dataRepeater.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlFicheProjet.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "EQUIPE DU PROJET";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(42, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choisir membre d\'equipe*";
            // 
            // txt_PersonnelChoisi
            // 
            this.txt_PersonnelChoisi.BackColor = System.Drawing.Color.White;
            this.txt_PersonnelChoisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PersonnelChoisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_PersonnelChoisi.ForeColor = System.Drawing.Color.Black;
            this.txt_PersonnelChoisi.Location = new System.Drawing.Point(98, 78);
            this.txt_PersonnelChoisi.MaxLength = 49;
            this.txt_PersonnelChoisi.Name = "txt_PersonnelChoisi";
            this.txt_PersonnelChoisi.ReadOnly = true;
            this.txt_PersonnelChoisi.Size = new System.Drawing.Size(159, 27);
            this.txt_PersonnelChoisi.TabIndex = 31;
            this.txt_PersonnelChoisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Role
            // 
            this.txt_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Role.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Role.ForeColor = System.Drawing.Color.Black;
            this.txt_Role.FormattingEnabled = true;
            this.txt_Role.Items.AddRange(new object[] {
            "Organisateur",
            "Promoteur",
            "Concepteur",
            "Ingenieur",
            "Expert",
            "Priseur",
            "Perfectionneur",
            "Coordinateur",
            "Propulseurs",
            "Soutien",
            "Secrétaire"});
            this.txt_Role.Location = new System.Drawing.Point(41, 135);
            this.txt_Role.Name = "txt_Role";
            this.txt_Role.Size = new System.Drawing.Size(216, 27);
            this.txt_Role.TabIndex = 1;
            // 
            // txt_PersonnelID
            // 
            this.txt_PersonnelID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_PersonnelID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txt_PersonnelID.ForeColor = System.Drawing.Color.Black;
            this.txt_PersonnelID.FormattingEnabled = true;
            this.txt_PersonnelID.Location = new System.Drawing.Point(41, 78);
            this.txt_PersonnelID.Name = "txt_PersonnelID";
            this.txt_PersonnelID.Size = new System.Drawing.Size(51, 27);
            this.txt_PersonnelID.TabIndex = 0;
            this.txt_PersonnelID.SelectedIndexChanged += new System.EventHandler(this.txt_Personnel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Rôle sur le projet*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_ChefProjet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(28, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 99);
            this.panel1.TabIndex = 50;
            // 
            // lbl_ChefProjet
            // 
            this.lbl_ChefProjet.AutoSize = true;
            this.lbl_ChefProjet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_ChefProjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ChefProjet.Location = new System.Drawing.Point(61, 34);
            this.lbl_ChefProjet.Name = "lbl_ChefProjet";
            this.lbl_ChefProjet.Size = new System.Drawing.Size(17, 19);
            this.lbl_ChefProjet.TabIndex = 2;
            this.lbl_ChefProjet.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chef de projet : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RlzProj.Properties.Resources.gens_icone_8612_48;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnAjouterAEquipe
            // 
            this.btnAjouterAEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAjouterAEquipe.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAjouterAEquipe.FlatAppearance.BorderSize = 0;
            this.btnAjouterAEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterAEquipe.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnAjouterAEquipe.ForeColor = System.Drawing.Color.White;
            this.btnAjouterAEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterAEquipe.Location = new System.Drawing.Point(275, 0);
            this.btnAjouterAEquipe.Name = "btnAjouterAEquipe";
            this.btnAjouterAEquipe.Size = new System.Drawing.Size(43, 179);
            this.btnAjouterAEquipe.TabIndex = 2;
            this.btnAjouterAEquipe.Text = "+";
            this.btnAjouterAEquipe.UseVisualStyleBackColor = false;
            this.btnAjouterAEquipe.Click += new System.EventHandler(this.btnAjouterAEquipe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(714, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Rôle sur le projet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(497, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Membre d\'equipe:";
            // 
            // roleSurProjTextBox
            // 
            this.roleSurProjTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roleSurProjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "RoleSurProj", true));
            this.roleSurProjTextBox.Location = new System.Drawing.Point(204, 10);
            this.roleSurProjTextBox.Name = "roleSurProjTextBox";
            this.roleSurProjTextBox.ReadOnly = true;
            this.roleSurProjTextBox.Size = new System.Drawing.Size(169, 20);
            this.roleSurProjTextBox.TabIndex = 3;
            this.roleSurProjTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipeProjBindingSource
            // 
            this.equipeProjBindingSource.DataMember = "EquipeProj";
            this.equipeProjBindingSource.DataSource = this.rlzDs;
            // 
            // rlzDs
            // 
            this.rlzDs.DataSetName = "RlzDs";
            this.rlzDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomMembreEquipeTextBox
            // 
            this.nomMembreEquipeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomMembreEquipeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "NomMembreEquipe", true));
            this.nomMembreEquipeTextBox.Location = new System.Drawing.Point(29, 10);
            this.nomMembreEquipeTextBox.Name = "nomMembreEquipeTextBox";
            this.nomMembreEquipeTextBox.ReadOnly = true;
            this.nomMembreEquipeTextBox.Size = new System.Drawing.Size(169, 20);
            this.nomMembreEquipeTextBox.TabIndex = 1;
            this.nomMembreEquipeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // equipeProjBindingNavigator
            // 
            this.equipeProjBindingNavigator.AddNewItem = null;
            this.equipeProjBindingNavigator.AutoSize = false;
            this.equipeProjBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.equipeProjBindingNavigator.BindingSource = this.equipeProjBindingSource;
            this.equipeProjBindingNavigator.CountItem = null;
            this.equipeProjBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.equipeProjBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.equipeProjBindingNavigator.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.equipeProjBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.equipeProjBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem});
            this.equipeProjBindingNavigator.Location = new System.Drawing.Point(133, 87);
            this.equipeProjBindingNavigator.MoveFirstItem = null;
            this.equipeProjBindingNavigator.MoveLastItem = null;
            this.equipeProjBindingNavigator.MoveNextItem = null;
            this.equipeProjBindingNavigator.MovePreviousItem = null;
            this.equipeProjBindingNavigator.Name = "equipeProjBindingNavigator";
            this.equipeProjBindingNavigator.PositionItem = null;
            this.equipeProjBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.equipeProjBindingNavigator.Size = new System.Drawing.Size(320, 32);
            this.equipeProjBindingNavigator.TabIndex = 3;
            this.equipeProjBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorDeleteItem.Image = global::RlzProj.Properties.Resources.fermer_icone_3776_32;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(253, 29);
            this.bindingNavigatorDeleteItem.Text = "Exclure le membre selectionner de l\'Equipe";
            this.bindingNavigatorDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RlzProj.Properties.Resources.clients_groupe_utilisateurs_icone_4112_32;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // roleSurProjLabel1
            // 
            this.roleSurProjLabel1.BackColor = System.Drawing.Color.Transparent;
            this.roleSurProjLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "RoleSurProj", true));
            this.roleSurProjLabel1.ForeColor = System.Drawing.Color.White;
            this.roleSurProjLabel1.Location = new System.Drawing.Point(211, 9);
            this.roleSurProjLabel1.Name = "roleSurProjLabel1";
            this.roleSurProjLabel1.Size = new System.Drawing.Size(152, 23);
            this.roleSurProjLabel1.TabIndex = 5;
            this.roleSurProjLabel1.Text = "+";
            this.roleSurProjLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomMembreEquipeLabel1
            // 
            this.nomMembreEquipeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nomMembreEquipeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "NomMembreEquipe", true));
            this.nomMembreEquipeLabel1.ForeColor = System.Drawing.Color.White;
            this.nomMembreEquipeLabel1.Location = new System.Drawing.Point(69, 9);
            this.nomMembreEquipeLabel1.Name = "nomMembreEquipeLabel1";
            this.nomMembreEquipeLabel1.Size = new System.Drawing.Size(136, 23);
            this.nomMembreEquipeLabel1.TabIndex = 3;
            this.nomMembreEquipeLabel1.Text = "+";
            this.nomMembreEquipeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equipeProjTableAdapter
            // 
            this.equipeProjTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetProjTableAdapter = null;
            this.tableAdapterManager.EquipeProjTableAdapter = this.equipeProjTableAdapter;
            this.tableAdapterManager.FicheProjTableAdapter = null;
            this.tableAdapterManager.TachesProjTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RlzProj.RlzDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ficheProjBindingSource
            // 
            this.ficheProjBindingSource.DataMember = "FicheProj";
            this.ficheProjBindingSource.DataSource = this.rlzDs;
            // 
            // ficheProjTableAdapter
            // 
            this.ficheProjTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RlzProj.Properties.Resources.bgback;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataRepeater);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.equipeProjBindingNavigator);
            this.panel2.Controls.Add(this.lblErrorInfos);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pnlFicheProjet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 545);
            this.panel2.TabIndex = 51;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataRepeater
            // 
            this.dataRepeater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataRepeater.BackgroundImage = global::RlzProj.Properties.Resources.clients_groupe_utilisateurs_icone_4112_48__1_;
            this.dataRepeater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dataRepeater.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.dataRepeater.ItemHeaderSize = 8;
            // 
            // dataRepeater.ItemTemplate
            // 
            this.dataRepeater.ItemTemplate.Controls.Add(this.nomMembreEquipeTextBox1);
            this.dataRepeater.ItemTemplate.Controls.Add(this.roleSurProjTextBox1);
            this.dataRepeater.ItemTemplate.Size = new System.Drawing.Size(477, 52);
            this.dataRepeater.Location = new System.Drawing.Point(460, 87);
            this.dataRepeater.Name = "dataRepeater";
            this.dataRepeater.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataRepeater.Size = new System.Drawing.Size(485, 418);
            this.dataRepeater.TabIndex = 0;
            this.dataRepeater.Text = "DataRep";
            // 
            // nomMembreEquipeTextBox1
            // 
            this.nomMembreEquipeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomMembreEquipeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "NomMembreEquipe", true));
            this.nomMembreEquipeTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.nomMembreEquipeTextBox1.Location = new System.Drawing.Point(28, 12);
            this.nomMembreEquipeTextBox1.Name = "nomMembreEquipeTextBox1";
            this.nomMembreEquipeTextBox1.ReadOnly = true;
            this.nomMembreEquipeTextBox1.Size = new System.Drawing.Size(203, 27);
            this.nomMembreEquipeTextBox1.TabIndex = 2;
            this.nomMembreEquipeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleSurProjTextBox1
            // 
            this.roleSurProjTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roleSurProjTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipeProjBindingSource, "RoleSurProj", true));
            this.roleSurProjTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.roleSurProjTextBox1.Location = new System.Drawing.Point(237, 12);
            this.roleSurProjTextBox1.Name = "roleSurProjTextBox1";
            this.roleSurProjTextBox1.ReadOnly = true;
            this.roleSurProjTextBox1.Size = new System.Drawing.Size(203, 27);
            this.roleSurProjTextBox1.TabIndex = 1;
            this.roleSurProjTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnAjouterAEquipe);
            this.panel4.Controls.Add(this.txt_Role);
            this.panel4.Controls.Add(this.txt_PersonnelID);
            this.panel4.Controls.Add(this.txt_PersonnelChoisi);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(133, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 181);
            this.panel4.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(14, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "NOUVEAUX MEMBRES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1053, 46);
            this.panel3.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMER VOTRE EQUIPE";
            // 
            // pnlFicheProjet
            // 
            this.pnlFicheProjet.BackColor = System.Drawing.Color.Transparent;
            this.pnlFicheProjet.Controls.Add(this.panel1);
            this.pnlFicheProjet.Font = new System.Drawing.Font("Calibri", 12F);
            this.pnlFicheProjet.Location = new System.Drawing.Point(105, 87);
            this.pnlFicheProjet.Name = "pnlFicheProjet";
            this.pnlFicheProjet.Size = new System.Drawing.Size(842, 421);
            this.pnlFicheProjet.TabIndex = 35;
            // 
            // EquipeProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipeProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EquipeProjet";
            this.Load += new System.EventHandler(this.EquipeProjet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeProjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlzDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeProjBindingNavigator)).EndInit();
            this.equipeProjBindingNavigator.ResumeLayout(false);
            this.equipeProjBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficheProjBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dataRepeater.ItemTemplate.ResumeLayout(false);
            this.dataRepeater.ItemTemplate.PerformLayout();
            this.dataRepeater.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlFicheProjet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_Role;
        private System.Windows.Forms.ComboBox txt_PersonnelID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PersonnelChoisi;
        private System.Windows.Forms.Label lblErrorInfos;
        private RlzDs rlzDs;
        private System.Windows.Forms.BindingSource equipeProjBindingSource;
        private RlzDsTableAdapters.EquipeProjTableAdapter equipeProjTableAdapter;
        private RlzDsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator equipeProjBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingSource ficheProjBindingSource;
        private RlzDsTableAdapters.FicheProjTableAdapter ficheProjTableAdapter;
        private System.Windows.Forms.Label roleSurProjLabel1;
        private System.Windows.Forms.Label nomMembreEquipeLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjouterAEquipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_ChefProjet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roleSurProjTextBox;
        private System.Windows.Forms.TextBox nomMembreEquipeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFicheProjet;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater;
        private System.Windows.Forms.TextBox roleSurProjTextBox1;
        private System.Windows.Forms.TextBox nomMembreEquipeTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
    }
}