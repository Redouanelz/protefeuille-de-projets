namespace RlzProj.Profile
{
    partial class MesInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesInfos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotdepasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPseudo = new System.Windows.Forms.TextBox();
            this.txtAdresseEmail = new System.Windows.Forms.TextBox();
            this.pnl_Back = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new RlzProj._Config.OvalPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNotif = new System.Windows.Forms.Label();
            this.txt_PicPath = new System.Windows.Forms.TextBox();
            this.btnEnregistrerTache = new System.Windows.Forms.Button();
            this.btn_Updateimg = new System.Windows.Forms.Button();
            this.Err_Inscription_Nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.Err_Inscription_Prenom = new System.Windows.Forms.ErrorProvider(this.components);
            this.Err_Inscription_Pseudo = new System.Windows.Forms.ErrorProvider(this.components);
            this.Err_Inscription_AdresseEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.Err_Inscription_Motdepasse = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnl_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Prenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Pseudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_AdresseEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Motdepasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 50);
            this.panel1.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "MODIFIER VOS INFORMATIONS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(246, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Prenom*";
            // 
            // txtPrenom
            // 
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrenom.ForeColor = System.Drawing.Color.Black;
            this.Err_Inscription_Prenom.SetIconPadding(this.txtPrenom, -20);
            this.txtPrenom.Location = new System.Drawing.Point(321, 110);
            this.txtPrenom.MaxLength = 49;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(321, 27);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.White;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.Err_Inscription_Nom.SetIconPadding(this.txtNom, -20);
            this.txtNom.Location = new System.Drawing.Point(321, 68);
            this.txtNom.MaxLength = 49;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(321, 27);
            this.txtNom.TabIndex = 5;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(126, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "votre nouveaux mot de passe*";
            // 
            // txtMotdepasse
            // 
            this.txtMotdepasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotdepasse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtMotdepasse.ForeColor = System.Drawing.Color.Black;
            this.Err_Inscription_Motdepasse.SetIconPadding(this.txtMotdepasse, -20);
            this.txtMotdepasse.Location = new System.Drawing.Point(321, 236);
            this.txtMotdepasse.MaxLength = 49;
            this.txtMotdepasse.Name = "txtMotdepasse";
            this.txtMotdepasse.PasswordChar = '•';
            this.txtMotdepasse.Size = new System.Drawing.Size(321, 27);
            this.txtMotdepasse.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(212, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Adresse Email*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(250, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Pseudo*";
            // 
            // txtPseudo
            // 
            this.txtPseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPseudo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtPseudo.ForeColor = System.Drawing.Color.Black;
            this.Err_Inscription_Pseudo.SetIconPadding(this.txtPseudo, -20);
            this.txtPseudo.Location = new System.Drawing.Point(321, 152);
            this.txtPseudo.MaxLength = 49;
            this.txtPseudo.Name = "txtPseudo";
            this.txtPseudo.Size = new System.Drawing.Size(321, 27);
            this.txtPseudo.TabIndex = 7;
            // 
            // txtAdresseEmail
            // 
            this.txtAdresseEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdresseEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAdresseEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAdresseEmail.ForeColor = System.Drawing.Color.Black;
            this.Err_Inscription_AdresseEmail.SetIconPadding(this.txtAdresseEmail, -20);
            this.txtAdresseEmail.Location = new System.Drawing.Point(321, 194);
            this.txtAdresseEmail.MaxLength = 49;
            this.txtAdresseEmail.Name = "txtAdresseEmail";
            this.txtAdresseEmail.Size = new System.Drawing.Size(321, 27);
            this.txtAdresseEmail.TabIndex = 10;
            // 
            // pnl_Back
            // 
            this.pnl_Back.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Back.Controls.Add(this.lblName);
            this.pnl_Back.Controls.Add(this.label1);
            this.pnl_Back.Controls.Add(this.pictureBox);
            this.pnl_Back.Controls.Add(this.panel2);
            this.pnl_Back.Controls.Add(this.btn_Updateimg);
            this.pnl_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Back.Location = new System.Drawing.Point(0, 0);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Size = new System.Drawing.Size(1055, 545);
            this.pnl_Back.TabIndex = 49;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 303);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 19);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(207, 95);
            this.label1.TabIndex = 57;
            this.label1.Text = "Gérer votre compte personnelles:\r\n\r\nVous pouvez mettre à jours\r\ntous vos informat" +
                "ions rapidement\r\ndepuis cette inteface.";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(58, 183);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 110);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 56;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::RlzProj.Properties.Resources.bgbackx1;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNotif);
            this.panel2.Controls.Add(this.txtMotdepasse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_PicPath);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPseudo);
            this.panel2.Controls.Add(this.btnEnregistrerTache);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.txtAdresseEmail);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(239, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 415);
            this.panel2.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(263, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nom*";
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.BackColor = System.Drawing.Color.Crimson;
            this.lblNotif.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.lblNotif.ForeColor = System.Drawing.Color.White;
            this.lblNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNotif.Location = new System.Drawing.Point(322, 316);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(107, 13);
            this.lblNotif.TabIndex = 55;
            this.lblNotif.Text = "Notifications : Aucune\r\n";
            // 
            // txt_PicPath
            // 
            this.txt_PicPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_PicPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PicPath.Font = new System.Drawing.Font("Calibri", 12F);
            this.txt_PicPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PicPath.Location = new System.Drawing.Point(-1, 373);
            this.txt_PicPath.MaxLength = 49;
            this.txt_PicPath.Name = "txt_PicPath";
            this.txt_PicPath.ReadOnly = true;
            this.txt_PicPath.Size = new System.Drawing.Size(10, 27);
            this.txt_PicPath.TabIndex = 52;
            // 
            // btnEnregistrerTache
            // 
            this.btnEnregistrerTache.BackColor = System.Drawing.Color.White;
            this.btnEnregistrerTache.FlatAppearance.BorderSize = 2;
            this.btnEnregistrerTache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEnregistrerTache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerTache.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnregistrerTache.ForeColor = System.Drawing.Color.Crimson;
            this.btnEnregistrerTache.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrerTache.Location = new System.Drawing.Point(321, 279);
            this.btnEnregistrerTache.Name = "btnEnregistrerTache";
            this.btnEnregistrerTache.Size = new System.Drawing.Size(323, 35);
            this.btnEnregistrerTache.TabIndex = 49;
            this.btnEnregistrerTache.Text = "&ENREGSITRER MODIFICATION";
            this.btnEnregistrerTache.UseVisualStyleBackColor = false;
            this.btnEnregistrerTache.Click += new System.EventHandler(this.btnEnregistrerTache_Click);
            // 
            // btn_Updateimg
            // 
            this.btn_Updateimg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Updateimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Updateimg.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_Updateimg.ForeColor = System.Drawing.Color.White;
            this.btn_Updateimg.Location = new System.Drawing.Point(19, 328);
            this.btn_Updateimg.Name = "btn_Updateimg";
            this.btn_Updateimg.Size = new System.Drawing.Size(207, 31);
            this.btn_Updateimg.TabIndex = 51;
            this.btn_Updateimg.Text = "&Changer votre photo de profile\r\n";
            this.btn_Updateimg.UseVisualStyleBackColor = false;
            this.btn_Updateimg.Click += new System.EventHandler(this.btn_Updateimg_Click);
            // 
            // Err_Inscription_Nom
            // 
            this.Err_Inscription_Nom.BlinkRate = 0;
            this.Err_Inscription_Nom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err_Inscription_Nom.ContainerControl = this;
            // 
            // Err_Inscription_Prenom
            // 
            this.Err_Inscription_Prenom.BlinkRate = 0;
            this.Err_Inscription_Prenom.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err_Inscription_Prenom.ContainerControl = this;
            // 
            // Err_Inscription_Pseudo
            // 
            this.Err_Inscription_Pseudo.BlinkRate = 0;
            this.Err_Inscription_Pseudo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err_Inscription_Pseudo.ContainerControl = this;
            // 
            // Err_Inscription_AdresseEmail
            // 
            this.Err_Inscription_AdresseEmail.BlinkRate = 0;
            this.Err_Inscription_AdresseEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err_Inscription_AdresseEmail.ContainerControl = this;
            // 
            // Err_Inscription_Motdepasse
            // 
            this.Err_Inscription_Motdepasse.BlinkRate = 0;
            this.Err_Inscription_Motdepasse.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Err_Inscription_Motdepasse.ContainerControl = this;
            // 
            // MesInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MesInfos";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Infos";
            this.Load += new System.EventHandler(this.MesInfos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Back.ResumeLayout(false);
            this.pnl_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Prenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Pseudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_AdresseEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err_Inscription_Motdepasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotdepasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPseudo;
        private System.Windows.Forms.TextBox txtAdresseEmail;
        private System.Windows.Forms.Panel pnl_Back;
        private System.Windows.Forms.Button btnEnregistrerTache;
        private System.Windows.Forms.Button btn_Updateimg;
        private System.Windows.Forms.TextBox txt_PicPath;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.ErrorProvider Err_Inscription_Nom;
        private System.Windows.Forms.ErrorProvider Err_Inscription_Prenom;
        private System.Windows.Forms.ErrorProvider Err_Inscription_Pseudo;
        private System.Windows.Forms.ErrorProvider Err_Inscription_AdresseEmail;
        private System.Windows.Forms.ErrorProvider Err_Inscription_Motdepasse;
        private _Config.OvalPictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label11;
    }
}