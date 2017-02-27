namespace RlzProj.Tableau_de_bord
{
    partial class EspaceProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspaceProjet));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Etat = new System.Windows.Forms.Button();
            this.btn_TachesJalons = new System.Windows.Forms.Button();
            this.btn_Budget = new System.Windows.Forms.Button();
            this.btn_RetourAcueille = new System.Windows.Forms.Button();
            this.btn_Equipe = new System.Windows.Forms.Button();
            this.btn_Fiche = new System.Windows.Forms.Button();
            this.lbl_EtatDb = new System.Windows.Forms.Label();
            this.lbl_REF_PROJ = new System.Windows.Forms.Label();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.pnl_Header_Menu = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.lbl_Header_Menu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.pnl_Header_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.White;
            this.panel_Menu.Controls.Add(this.btn_Etat);
            this.panel_Menu.Controls.Add(this.btn_TachesJalons);
            this.panel_Menu.Controls.Add(this.btn_Budget);
            this.panel_Menu.Controls.Add(this.btn_RetourAcueille);
            this.panel_Menu.Controls.Add(this.btn_Equipe);
            this.panel_Menu.Controls.Add(this.btn_Fiche);
            this.panel_Menu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(0, 71);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1055, 84);
            this.panel_Menu.TabIndex = 17;
            // 
            // btn_Etat
            // 
            this.btn_Etat.BackColor = System.Drawing.Color.White;
            this.btn_Etat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Etat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Etat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Etat.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Etat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Etat.Image = global::RlzProj.Properties.Resources.augmenter_icone_9349_32;
            this.btn_Etat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Etat.Location = new System.Drawing.Point(95, 3);
            this.btn_Etat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Etat.Name = "btn_Etat";
            this.btn_Etat.Size = new System.Drawing.Size(180, 79);
            this.btn_Etat.TabIndex = 44;
            this.btn_Etat.Text = "\r\nETAT DU PROJET";
            this.btn_Etat.UseCompatibleTextRendering = true;
            this.btn_Etat.UseVisualStyleBackColor = false;
            this.btn_Etat.Click += new System.EventHandler(this.btn_Etat_Click);
            this.btn_Etat.MouseEnter += new System.EventHandler(this.btn_Etat_MouseEnter);
            this.btn_Etat.MouseLeave += new System.EventHandler(this.btn_Etat_MouseLeave);
            // 
            // btn_TachesJalons
            // 
            this.btn_TachesJalons.BackColor = System.Drawing.Color.White;
            this.btn_TachesJalons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TachesJalons.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TachesJalons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TachesJalons.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TachesJalons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_TachesJalons.Image = global::RlzProj.Properties.Resources.clients_contacts_clients_usercard_icone_7853_32;
            this.btn_TachesJalons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TachesJalons.Location = new System.Drawing.Point(778, 3);
            this.btn_TachesJalons.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_TachesJalons.Name = "btn_TachesJalons";
            this.btn_TachesJalons.Size = new System.Drawing.Size(181, 79);
            this.btn_TachesJalons.TabIndex = 5;
            this.btn_TachesJalons.Text = "\r\nCONFIRMER LES TACHES";
            this.btn_TachesJalons.UseCompatibleTextRendering = true;
            this.btn_TachesJalons.UseVisualStyleBackColor = false;
            this.btn_TachesJalons.Click += new System.EventHandler(this.btn_TachesJalons_Click);
            this.btn_TachesJalons.MouseEnter += new System.EventHandler(this.btn_TachesJalons_MouseEnter);
            this.btn_TachesJalons.MouseLeave += new System.EventHandler(this.btn_TachesJalons_MouseLeave);
            // 
            // btn_Budget
            // 
            this.btn_Budget.BackColor = System.Drawing.Color.White;
            this.btn_Budget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Budget.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Budget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Budget.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Budget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Budget.Image = global::RlzProj.Properties.Resources.simulateur_icone_7870_32;
            this.btn_Budget.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Budget.Location = new System.Drawing.Point(609, 3);
            this.btn_Budget.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Budget.Name = "btn_Budget";
            this.btn_Budget.Size = new System.Drawing.Size(181, 79);
            this.btn_Budget.TabIndex = 4;
            this.btn_Budget.Text = "\r\nCONFIRMER LE BUDGET";
            this.btn_Budget.UseCompatibleTextRendering = true;
            this.btn_Budget.UseVisualStyleBackColor = false;
            this.btn_Budget.Click += new System.EventHandler(this.btn_Budget_Click);
            this.btn_Budget.MouseEnter += new System.EventHandler(this.btn_Budget_MouseEnter);
            this.btn_Budget.MouseLeave += new System.EventHandler(this.btn_Budget_MouseLeave);
            // 
            // btn_RetourAcueille
            // 
            this.btn_RetourAcueille.BackColor = System.Drawing.Color.White;
            this.btn_RetourAcueille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RetourAcueille.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_RetourAcueille.FlatAppearance.BorderSize = 0;
            this.btn_RetourAcueille.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_RetourAcueille.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_RetourAcueille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RetourAcueille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_RetourAcueille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_RetourAcueille.Image = global::RlzProj.Properties.Resources.Accueille;
            this.btn_RetourAcueille.Location = new System.Drawing.Point(3, 3);
            this.btn_RetourAcueille.Name = "btn_RetourAcueille";
            this.btn_RetourAcueille.Size = new System.Drawing.Size(87, 78);
            this.btn_RetourAcueille.TabIndex = 6;
            this.btn_RetourAcueille.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RetourAcueille.UseVisualStyleBackColor = false;
            this.btn_RetourAcueille.Click += new System.EventHandler(this.btn_RetourAcueille_Click_2);
            this.btn_RetourAcueille.MouseEnter += new System.EventHandler(this.btn_RetourAcueille_MouseEnter);
            this.btn_RetourAcueille.MouseLeave += new System.EventHandler(this.btn_RetourAcueille_MouseLeave);
            // 
            // btn_Equipe
            // 
            this.btn_Equipe.BackColor = System.Drawing.Color.White;
            this.btn_Equipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Equipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Equipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Equipe.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Equipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Equipe.Image = global::RlzProj.Properties.Resources.clients_groupe_utilisateurs_icone_4112_321;
            this.btn_Equipe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Equipe.Location = new System.Drawing.Point(440, 3);
            this.btn_Equipe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Equipe.Name = "btn_Equipe";
            this.btn_Equipe.Size = new System.Drawing.Size(181, 79);
            this.btn_Equipe.TabIndex = 3;
            this.btn_Equipe.Text = "\r\nCONFIRMER L\'EQUIPE";
            this.btn_Equipe.UseCompatibleTextRendering = true;
            this.btn_Equipe.UseVisualStyleBackColor = false;
            this.btn_Equipe.Click += new System.EventHandler(this.btn_Equipe_Click);
            this.btn_Equipe.MouseEnter += new System.EventHandler(this.btn_Equipe_MouseEnter);
            this.btn_Equipe.MouseLeave += new System.EventHandler(this.btn_Equipe_MouseLeave);
            // 
            // btn_Fiche
            // 
            this.btn_Fiche.BackColor = System.Drawing.Color.White;
            this.btn_Fiche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fiche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Fiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fiche.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fiche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Fiche.Image = global::RlzProj.Properties.Resources.dossier_icone_3857_32;
            this.btn_Fiche.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Fiche.Location = new System.Drawing.Point(271, 3);
            this.btn_Fiche.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Fiche.Name = "btn_Fiche";
            this.btn_Fiche.Size = new System.Drawing.Size(181, 79);
            this.btn_Fiche.TabIndex = 2;
            this.btn_Fiche.Text = "\r\nCONFIRMER LA FICHE DU PROJET";
            this.btn_Fiche.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Fiche.UseCompatibleTextRendering = true;
            this.btn_Fiche.UseVisualStyleBackColor = false;
            this.btn_Fiche.Click += new System.EventHandler(this.btn_Fiche_Click);
            this.btn_Fiche.MouseEnter += new System.EventHandler(this.btn_Fiche_MouseEnter);
            this.btn_Fiche.MouseLeave += new System.EventHandler(this.btn_Fiche_MouseLeave);
            // 
            // lbl_EtatDb
            // 
            this.lbl_EtatDb.AutoSize = true;
            this.lbl_EtatDb.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EtatDb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EtatDb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_EtatDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_EtatDb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_EtatDb.Location = new System.Drawing.Point(3, 20);
            this.lbl_EtatDb.Name = "lbl_EtatDb";
            this.lbl_EtatDb.Size = new System.Drawing.Size(15, 17);
            this.lbl_EtatDb.TabIndex = 43;
            this.lbl_EtatDb.Text = "+";
            // 
            // lbl_REF_PROJ
            // 
            this.lbl_REF_PROJ.AutoSize = true;
            this.lbl_REF_PROJ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_REF_PROJ.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REF_PROJ.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_REF_PROJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_REF_PROJ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_REF_PROJ.Location = new System.Drawing.Point(3, 3);
            this.lbl_REF_PROJ.Name = "lbl_REF_PROJ";
            this.lbl_REF_PROJ.Size = new System.Drawing.Size(15, 17);
            this.lbl_REF_PROJ.TabIndex = 42;
            this.lbl_REF_PROJ.Text = "+";
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.White;
            this.panel_Header.Controls.Add(this.pnl_Header_Menu);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1055, 71);
            this.panel_Header.TabIndex = 16;
            // 
            // pnl_Header_Menu
            // 
            this.pnl_Header_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Header_Menu.Controls.Add(this.button1);
            this.pnl_Header_Menu.Controls.Add(this.btn_Close);
            this.pnl_Header_Menu.Controls.Add(this.lbl_EtatDb);
            this.pnl_Header_Menu.Controls.Add(this.btn_Minimize);
            this.pnl_Header_Menu.Controls.Add(this.lbl_REF_PROJ);
            this.pnl_Header_Menu.Controls.Add(this.lbl_Header_Menu);
            this.pnl_Header_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Header_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header_Menu.Name = "pnl_Header_Menu";
            this.pnl_Header_Menu.Size = new System.Drawing.Size(1055, 71);
            this.pnl_Header_Menu.TabIndex = 55;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(989, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(63, 23);
            this.btn_Close.TabIndex = 33;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(946, 3);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 23);
            this.btn_Minimize.TabIndex = 32;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // lbl_Header_Menu
            // 
            this.lbl_Header_Menu.AutoSize = true;
            this.lbl_Header_Menu.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Header_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Header_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Header_Menu.Location = new System.Drawing.Point(396, 22);
            this.lbl_Header_Menu.Name = "lbl_Header_Menu";
            this.lbl_Header_Menu.Size = new System.Drawing.Size(263, 23);
            this.lbl_Header_Menu.TabIndex = 0;
            this.lbl_Header_Menu.Text = "&ESPACE DE GESTION DE PROJETS";
            this.lbl_Header_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(904, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EspaceProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 700);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "EspaceProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Espace de gestion de projet";
            this.Load += new System.EventHandler(this.EspaceProjet_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.pnl_Header_Menu.ResumeLayout(false);
            this.pnl_Header_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_Etat;
        private System.Windows.Forms.Label lbl_EtatDb;
        private System.Windows.Forms.Button btn_TachesJalons;
        private System.Windows.Forms.Label lbl_REF_PROJ;
        private System.Windows.Forms.Button btn_Budget;
        private System.Windows.Forms.Button btn_Equipe;
        private System.Windows.Forms.Button btn_Fiche;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel pnl_Header_Menu;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_RetourAcueille;
        private System.Windows.Forms.Label lbl_Header_Menu;
        private System.Windows.Forms.Button button1;
    }
}