namespace RlzProj.Profile
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            this.pnl_Fill = new System.Windows.Forms.Panel();
            this.pnl_Header_Menu = new System.Windows.Forms.Panel();
            this.lbl_Header_Menu = new System.Windows.Forms.Label();
            this.pnl_Messagerie = new System.Windows.Forms.Panel();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Taches = new System.Windows.Forms.Panel();
            this.lbl_nbrNvTaches = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_UpdateInfos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Time = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Heur = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_Fill.SuspendLayout();
            this.pnl_Header_Menu.SuspendLayout();
            this.pnl_Messagerie.SuspendLayout();
            this.pnl_Taches.SuspendLayout();
            this.pnl_UpdateInfos.SuspendLayout();
            this.pnl_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Fill
            // 
            this.pnl_Fill.BackColor = System.Drawing.Color.White;
            this.pnl_Fill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fill.Controls.Add(this.pnl_Header_Menu);
            this.pnl_Fill.Controls.Add(this.pnl_Messagerie);
            this.pnl_Fill.Controls.Add(this.pnl_Taches);
            this.pnl_Fill.Controls.Add(this.pnl_UpdateInfos);
            this.pnl_Fill.Controls.Add(this.pnl_Time);
            this.pnl_Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Fill.Location = new System.Drawing.Point(0, 0);
            this.pnl_Fill.Name = "pnl_Fill";
            this.pnl_Fill.Size = new System.Drawing.Size(1055, 545);
            this.pnl_Fill.TabIndex = 1;
            // 
            // pnl_Header_Menu
            // 
            this.pnl_Header_Menu.BackColor = System.Drawing.Color.Crimson;
            this.pnl_Header_Menu.Controls.Add(this.lbl_Header_Menu);
            this.pnl_Header_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header_Menu.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.pnl_Header_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header_Menu.Name = "pnl_Header_Menu";
            this.pnl_Header_Menu.Size = new System.Drawing.Size(1053, 50);
            this.pnl_Header_Menu.TabIndex = 55;
            // 
            // lbl_Header_Menu
            // 
            this.lbl_Header_Menu.AutoSize = true;
            this.lbl_Header_Menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Header_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Header_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Header_Menu.Location = new System.Drawing.Point(11, 8);
            this.lbl_Header_Menu.Name = "lbl_Header_Menu";
            this.lbl_Header_Menu.Size = new System.Drawing.Size(87, 20);
            this.lbl_Header_Menu.TabIndex = 0;
            this.lbl_Header_Menu.Text = "VOTRE MUR";
            this.lbl_Header_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Messagerie
            // 
            this.pnl_Messagerie.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.pnl_Messagerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnl_Messagerie.BackgroundImage = global::RlzProj.Properties.Resources.appbar_email_minimal;
            this.pnl_Messagerie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Messagerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Messagerie.Controls.Add(this.lbl_Email);
            this.pnl_Messagerie.Controls.Add(this.label2);
            this.pnl_Messagerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Messagerie.Location = new System.Drawing.Point(426, 274);
            this.pnl_Messagerie.Name = "pnl_Messagerie";
            this.pnl_Messagerie.Size = new System.Drawing.Size(406, 150);
            this.pnl_Messagerie.TabIndex = 10;
            this.pnl_Messagerie.DoubleClick += new System.EventHandler(this.pnl_Messagerie_DoubleClick);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbl_Email.ForeColor = System.Drawing.Color.White;
            this.lbl_Email.Location = new System.Drawing.Point(215, 119);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(12, 17);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONSULTEZ\r\nVOTRE \r\nMESSAGERIE";
            // 
            // pnl_Taches
            // 
            this.pnl_Taches.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.pnl_Taches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_Taches.BackgroundImage = global::RlzProj.Properties.Resources.appbar_notification_star;
            this.pnl_Taches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Taches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Taches.Controls.Add(this.lbl_nbrNvTaches);
            this.pnl_Taches.Controls.Add(this.label8);
            this.pnl_Taches.Controls.Add(this.label9);
            this.pnl_Taches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Taches.Location = new System.Drawing.Point(220, 118);
            this.pnl_Taches.Name = "pnl_Taches";
            this.pnl_Taches.Size = new System.Drawing.Size(200, 306);
            this.pnl_Taches.TabIndex = 9;
            // 
            // lbl_nbrNvTaches
            // 
            this.lbl_nbrNvTaches.AutoSize = true;
            this.lbl_nbrNvTaches.BackColor = System.Drawing.Color.White;
            this.lbl_nbrNvTaches.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Bold);
            this.lbl_nbrNvTaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_nbrNvTaches.Location = new System.Drawing.Point(50, 110);
            this.lbl_nbrNvTaches.Name = "lbl_nbrNvTaches";
            this.lbl_nbrNvTaches.Size = new System.Drawing.Size(50, 73);
            this.lbl_nbrNvTaches.TabIndex = 1;
            this.lbl_nbrNvTaches.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "VOUS AVEZ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(50, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "TACHES";
            // 
            // pnl_UpdateInfos
            // 
            this.pnl_UpdateInfos.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.pnl_UpdateInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_UpdateInfos.BackgroundImage = global::RlzProj.Properties.Resources.appbar_page1;
            this.pnl_UpdateInfos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_UpdateInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_UpdateInfos.Controls.Add(this.label1);
            this.pnl_UpdateInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_UpdateInfos.Location = new System.Drawing.Point(632, 118);
            this.pnl_UpdateInfos.Name = "pnl_UpdateInfos";
            this.pnl_UpdateInfos.Size = new System.Drawing.Size(200, 150);
            this.pnl_UpdateInfos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "MODIFIER\r\nVOS \r\nINFORMATIONS";
            // 
            // pnl_Time
            // 
            this.pnl_Time.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.pnl_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Time.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Time.Controls.Add(this.lbl_Date);
            this.pnl_Time.Controls.Add(this.lbl_Heur);
            this.pnl_Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_Time.Location = new System.Drawing.Point(426, 118);
            this.pnl_Time.Name = "pnl_Time";
            this.pnl_Time.Size = new System.Drawing.Size(200, 150);
            this.pnl_Time.TabIndex = 6;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Location = new System.Drawing.Point(95, 111);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(14, 19);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "-";
            // 
            // lbl_Heur
            // 
            this.lbl_Heur.AutoSize = true;
            this.lbl_Heur.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heur.ForeColor = System.Drawing.Color.White;
            this.lbl_Heur.Location = new System.Drawing.Point(3, 34);
            this.lbl_Heur.Name = "lbl_Heur";
            this.lbl_Heur.Size = new System.Drawing.Size(56, 80);
            this.lbl_Heur.TabIndex = 1;
            this.lbl_Heur.Text = "-";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 545);
            this.Controls.Add(this.pnl_Fill);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mon Profile";
            this.Load += new System.EventHandler(this.MyProfile_Load);
            this.pnl_Fill.ResumeLayout(false);
            this.pnl_Header_Menu.ResumeLayout(false);
            this.pnl_Header_Menu.PerformLayout();
            this.pnl_Messagerie.ResumeLayout(false);
            this.pnl_Messagerie.PerformLayout();
            this.pnl_Taches.ResumeLayout(false);
            this.pnl_Taches.PerformLayout();
            this.pnl_UpdateInfos.ResumeLayout(false);
            this.pnl_UpdateInfos.PerformLayout();
            this.pnl_Time.ResumeLayout(false);
            this.pnl_Time.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Fill;
        private System.Windows.Forms.Panel pnl_UpdateInfos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_nbrNvTaches;
        private System.Windows.Forms.Panel pnl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Heur;
        private System.Windows.Forms.Panel pnl_Taches;
        private System.Windows.Forms.Panel pnl_Messagerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel pnl_Header_Menu;
        private System.Windows.Forms.Label lbl_Header_Menu;

    }
}