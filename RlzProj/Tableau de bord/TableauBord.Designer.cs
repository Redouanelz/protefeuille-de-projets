namespace RlzProj.Tableau_de_bord
{
    partial class TableauBord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableauBord));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_RetourAcueille = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.dg_dashBoard = new System.Windows.Forms.DataGridView();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Statut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAfficherProjet = new System.Windows.Forms.Button();
            this.ErrID = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.AutoSize = true;
            this.pnl_Menu.BackColor = System.Drawing.Color.White;
            this.pnl_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Menu.Controls.Add(this.btn_RetourAcueille);
            this.pnl_Menu.Controls.Add(this.label3);
            this.pnl_Menu.Controls.Add(this.btnFiltrer);
            this.pnl_Menu.Controls.Add(this.txt_ID);
            this.pnl_Menu.Controls.Add(this.dg_dashBoard);
            this.pnl_Menu.Controls.Add(this.txt_Code);
            this.pnl_Menu.Controls.Add(this.txt_Statut);
            this.pnl_Menu.Controls.Add(this.label6);
            this.pnl_Menu.Controls.Add(this.btnAfficherProjet);
            this.pnl_Menu.Font = new System.Drawing.Font("Calibri", 12F);
            this.pnl_Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Menu.Location = new System.Drawing.Point(0, 55);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1174, 597);
            this.pnl_Menu.TabIndex = 11;
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
            this.btn_RetourAcueille.Location = new System.Drawing.Point(45, 20);
            this.btn_RetourAcueille.Name = "btn_RetourAcueille";
            this.btn_RetourAcueille.Size = new System.Drawing.Size(69, 122);
            this.btn_RetourAcueille.TabIndex = 38;
            this.btn_RetourAcueille.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RetourAcueille.UseVisualStyleBackColor = false;
            this.btn_RetourAcueille.Click += new System.EventHandler(this.btn_RetourAcueille_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(203, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 51);
            this.label3.TabIndex = 37;
            this.label3.Text = "Consultez l\'état d\'avancement\r\nainsi que afficher est modifiez\r\nles informations " +
                "d\'un projet en detaille :";
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFiltrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFiltrer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFiltrer.FlatAppearance.BorderSize = 2;
            this.btnFiltrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiltrer.ForeColor = System.Drawing.Color.White;
            this.btnFiltrer.Image = global::RlzProj.Properties.Resources.loupe_icone_4171_32;
            this.btnFiltrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrer.Location = new System.Drawing.Point(509, 107);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(227, 35);
            this.btnFiltrer.TabIndex = 36;
            this.btnFiltrer.Text = "&FILTRER";
            this.btnFiltrer.UseVisualStyleBackColor = false;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ID.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_ID.ForeColor = System.Drawing.Color.Black;
            this.ErrID.SetIconPadding(this.txt_ID, -20);
            this.txt_ID.Location = new System.Drawing.Point(206, 74);
            this.txt_ID.MaxLength = 49;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(66, 27);
            this.txt_ID.TabIndex = 34;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dg_dashBoard
            // 
            this.dg_dashBoard.AllowUserToAddRows = false;
            this.dg_dashBoard.AllowUserToDeleteRows = false;
            this.dg_dashBoard.AllowUserToResizeColumns = false;
            this.dg_dashBoard.AllowUserToResizeRows = false;
            this.dg_dashBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dg_dashBoard.BackgroundColor = System.Drawing.Color.White;
            this.dg_dashBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg_dashBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_dashBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_dashBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_dashBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_dashBoard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_dashBoard.Location = new System.Drawing.Point(45, 162);
            this.dg_dashBoard.MultiSelect = false;
            this.dg_dashBoard.Name = "dg_dashBoard";
            this.dg_dashBoard.ReadOnly = true;
            this.dg_dashBoard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dg_dashBoard.RowHeadersWidth = 20;
            this.dg_dashBoard.RowTemplate.Height = 40;
            this.dg_dashBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_dashBoard.Size = new System.Drawing.Size(1085, 384);
            this.dg_dashBoard.TabIndex = 31;
            this.dg_dashBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dashBoard_CellClick);
            this.dg_dashBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_dashBoard_CellContentClick);
            // 
            // txt_Code
            // 
            this.txt_Code.BackColor = System.Drawing.Color.White;
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Code.Font = new System.Drawing.Font("Calibri", 10F);
            this.txt_Code.ForeColor = System.Drawing.Color.Black;
            this.txt_Code.Location = new System.Drawing.Point(278, 74);
            this.txt_Code.MaxLength = 49;
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(195, 24);
            this.txt_Code.TabIndex = 2;
            this.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Statut
            // 
            this.txt_Statut.BackColor = System.Drawing.Color.White;
            this.txt_Statut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Statut.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_Statut.FormattingEnabled = true;
            this.txt_Statut.Items.AddRange(new object[] {
            "Tous",
            "Intension",
            "En cours",
            "Terminer",
            "Archiver"});
            this.txt_Statut.Location = new System.Drawing.Point(509, 74);
            this.txt_Statut.Name = "txt_Statut";
            this.txt_Statut.Size = new System.Drawing.Size(227, 27);
            this.txt_Statut.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(506, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 34);
            this.label6.TabIndex = 33;
            this.label6.Text = "vous pouvez filtrer les projets \r\npar leurs statut actuelle :";
            // 
            // btnAfficherProjet
            // 
            this.btnAfficherProjet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAfficherProjet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAfficherProjet.FlatAppearance.BorderSize = 2;
            this.btnAfficherProjet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherProjet.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnAfficherProjet.ForeColor = System.Drawing.Color.White;
            this.btnAfficherProjet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherProjet.Location = new System.Drawing.Point(206, 107);
            this.btnAfficherProjet.Name = "btnAfficherProjet";
            this.btnAfficherProjet.Size = new System.Drawing.Size(267, 35);
            this.btnAfficherProjet.TabIndex = 9;
            this.btnAfficherProjet.Text = "&CONSULTEZ LA FICHE";
            this.btnAfficherProjet.UseVisualStyleBackColor = false;
            this.btnAfficherProjet.Click += new System.EventHandler(this.btnAfficherProjet_Click);
            // 
            // ErrID
            // 
            this.ErrID.BlinkRate = 0;
            this.ErrID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrID.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 57);
            this.panel1.TabIndex = 46;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Close.Location = new System.Drawing.Point(1110, 3);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(63, 23);
            this.btn_Close.TabIndex = 35;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(1067, 3);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(40, 23);
            this.btn_Minimize.TabIndex = 34;
            this.btn_Minimize.Text = "—";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "TABLEAU DE BORD";
            // 
            // TableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableauBord";
            this.Load += new System.EventHandler(this.TableauBord_Load);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.DataGridView dg_dashBoard;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.ComboBox txt_Statut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAfficherProjet;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.ErrorProvider ErrID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_RetourAcueille;
    }
}