namespace RlzProj.Profile
{
    partial class MaMessagerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaMessagerie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.txtAtachement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.to_list = new System.Windows.Forms.ListBox();
            this.btn_ClearListe = new System.Windows.Forms.Button();
            this.cmb_PersonnelEmailListe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Header_Menu = new System.Windows.Forms.Panel();
            this.lbl_Header_Menu = new System.Windows.Forms.Label();
            this.btn_Consulterweb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Header_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pnl_Header_Menu);
            this.panel1.Controls.Add(this.btn_Consulterweb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 545);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::RlzProj.Properties.Resources.bgbackx;
            this.panel3.Controls.Add(this.lblNotif);
            this.panel3.Controls.Add(this.Body);
            this.panel3.Controls.Add(this.Subject);
            this.panel3.Controls.Add(this.Send);
            this.panel3.Controls.Add(this.txtAtachement);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnAttach);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(237, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 413);
            this.panel3.TabIndex = 56;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.BackColor = System.Drawing.Color.Crimson;
            this.lblNotif.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.lblNotif.ForeColor = System.Drawing.Color.White;
            this.lblNotif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNotif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNotif.Location = new System.Drawing.Point(367, 352);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(107, 13);
            this.lblNotif.TabIndex = 56;
            this.lblNotif.Text = "Notifications : Aucune";
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Body.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Body.Location = new System.Drawing.Point(364, 112);
            this.Body.Margin = new System.Windows.Forms.Padding(10);
            this.Body.Name = "Body";
            this.Body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.Body.Size = new System.Drawing.Size(388, 110);
            this.Body.TabIndex = 5;
            this.Body.Text = "";
            // 
            // Subject
            // 
            this.Subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Subject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Subject.Location = new System.Drawing.Point(367, 45);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(385, 27);
            this.Subject.TabIndex = 2;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.Crimson;
            this.Send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Send.FlatAppearance.BorderSize = 2;
            this.Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.Send.ForeColor = System.Drawing.Color.White;
            this.Send.Location = new System.Drawing.Point(364, 316);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(388, 33);
            this.Send.TabIndex = 6;
            this.Send.Text = "&ENVOYER";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // txtAtachement
            // 
            this.txtAtachement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAtachement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAtachement.Location = new System.Drawing.Point(364, 283);
            this.txtAtachement.Name = "txtAtachement";
            this.txtAtachement.Size = new System.Drawing.Size(348, 27);
            this.txtAtachement.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F);
            this.label6.Location = new System.Drawing.Point(364, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 51);
            this.label6.TabIndex = 19;
            this.label6.Text = "vouslez-vous attacher\r\nune image ou un document\r\nà votre email?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.to_list);
            this.panel2.Controls.Add(this.btn_ClearListe);
            this.panel2.Controls.Add(this.cmb_PersonnelEmailListe);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(59, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 304);
            this.panel2.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F);
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Liste d\'adresses mails \r\nsouhaitez pour l\'envoi :";
            // 
            // to_list
            // 
            this.to_list.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.to_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.to_list.FormattingEnabled = true;
            this.to_list.ItemHeight = 19;
            this.to_list.Location = new System.Drawing.Point(14, 105);
            this.to_list.Name = "to_list";
            this.to_list.Size = new System.Drawing.Size(261, 194);
            this.to_list.TabIndex = 20;
            // 
            // btn_ClearListe
            // 
            this.btn_ClearListe.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_ClearListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearListe.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_ClearListe.ForeColor = System.Drawing.Color.Crimson;
            this.btn_ClearListe.Location = new System.Drawing.Point(167, 69);
            this.btn_ClearListe.Name = "btn_ClearListe";
            this.btn_ClearListe.Size = new System.Drawing.Size(108, 32);
            this.btn_ClearListe.TabIndex = 52;
            this.btn_ClearListe.Text = "&Vider la liste?";
            this.btn_ClearListe.UseVisualStyleBackColor = false;
            this.btn_ClearListe.Click += new System.EventHandler(this.btn_ClearListe_Click);
            // 
            // cmb_PersonnelEmailListe
            // 
            this.cmb_PersonnelEmailListe.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb_PersonnelEmailListe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_PersonnelEmailListe.FormattingEnabled = true;
            this.cmb_PersonnelEmailListe.Location = new System.Drawing.Point(14, 28);
            this.cmb_PersonnelEmailListe.Name = "cmb_PersonnelEmailListe";
            this.cmb_PersonnelEmailListe.Size = new System.Drawing.Size(261, 27);
            this.cmb_PersonnelEmailListe.TabIndex = 19;
            this.cmb_PersonnelEmailListe.SelectedIndexChanged += new System.EventHandler(this.cmb_PersonnelEmailListe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Envoyé à (multiple selection possible) :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F);
            this.label4.Location = new System.Drawing.Point(364, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 34);
            this.label4.TabIndex = 53;
            this.label4.Text = "Message à envoyé \r\n( il peut étre ecrit en html) :";
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Crimson;
            this.btnAttach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttach.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnAttach.Location = new System.Drawing.Point(718, 282);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(34, 27);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "---";
            this.btnAttach.UseVisualStyleBackColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F);
            this.label2.Location = new System.Drawing.Point(364, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Objet de votre email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 53);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(228, 112);
            this.label7.TabIndex = 59;
            this.label7.Text = "Gérer votre messagerie personnelles:\r\n\r\nVous pouvez contacter facilement\r\nles per" +
                "sonnelles inscrits, ainsi que\r\n consultez votre bôite email\r\ndepuis votre naviga" +
                "teur web.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 68);
            this.label5.TabIndex = 18;
            this.label5.Text = "Consultez votre messagerie\r\n dans votre navigateur web?\r\n( redirection vers\r\n htt" +
                "ps://mail.google.com )";
            // 
            // pnl_Header_Menu
            // 
            this.pnl_Header_Menu.BackColor = System.Drawing.Color.Crimson;
            this.pnl_Header_Menu.Controls.Add(this.lbl_Header_Menu);
            this.pnl_Header_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header_Menu.Name = "pnl_Header_Menu";
            this.pnl_Header_Menu.Size = new System.Drawing.Size(1053, 50);
            this.pnl_Header_Menu.TabIndex = 56;
            // 
            // lbl_Header_Menu
            // 
            this.lbl_Header_Menu.AutoSize = true;
            this.lbl_Header_Menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Header_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Header_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Header_Menu.Location = new System.Drawing.Point(11, 8);
            this.lbl_Header_Menu.Name = "lbl_Header_Menu";
            this.lbl_Header_Menu.Size = new System.Drawing.Size(204, 20);
            this.lbl_Header_Menu.TabIndex = 0;
            this.lbl_Header_Menu.Text = "VOTRE ESPACE MESSAGERIE";
            this.lbl_Header_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Consulterweb
            // 
            this.btn_Consulterweb.BackColor = System.Drawing.Color.Crimson;
            this.btn_Consulterweb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Consulterweb.FlatAppearance.BorderSize = 2;
            this.btn_Consulterweb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Consulterweb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consulterweb.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Consulterweb.ForeColor = System.Drawing.Color.White;
            this.btn_Consulterweb.Location = new System.Drawing.Point(37, 322);
            this.btn_Consulterweb.Name = "btn_Consulterweb";
            this.btn_Consulterweb.Size = new System.Drawing.Size(165, 35);
            this.btn_Consulterweb.TabIndex = 17;
            this.btn_Consulterweb.Text = "&CONSULTER";
            this.btn_Consulterweb.UseVisualStyleBackColor = false;
            this.btn_Consulterweb.Click += new System.EventHandler(this.btn_Consulterweb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RlzProj.Properties.Resources.appbar_email_hardedge;
            this.pictureBox1.Location = new System.Drawing.Point(74, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // MaMessagerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaMessagerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaMessagerie";
            this.Load += new System.EventHandler(this.MaMessagerie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnl_Header_Menu.ResumeLayout(false);
            this.pnl_Header_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Header_Menu;
        private System.Windows.Forms.Label lbl_Header_Menu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Consulterweb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox txtAtachement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox to_list;
        private System.Windows.Forms.Button btn_ClearListe;
        private System.Windows.Forms.ComboBox cmb_PersonnelEmailListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label label2;
    }
}