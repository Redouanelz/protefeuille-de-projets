namespace RlzProj._Config
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_DBState = new System.Windows.Forms.Label();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.btnConfigurer = new System.Windows.Forms.Button();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pnl_State = new System.Windows.Forms.Panel();
            this.lbl_Header_Menu = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Body.SuspendLayout();
            this.pnl_State.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RlzProj.Properties.Resources.appbar_database;
            this.pictureBox1.Location = new System.Drawing.Point(103, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_DBState
            // 
            this.lbl_DBState.AutoSize = true;
            this.lbl_DBState.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbl_DBState.Location = new System.Drawing.Point(165, 286);
            this.lbl_DBState.Name = "lbl_DBState";
            this.lbl_DBState.Size = new System.Drawing.Size(14, 19);
            this.lbl_DBState.TabIndex = 1;
            this.lbl_DBState.Text = "-";
            this.lbl_DBState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinuer
            // 
            this.btnContinuer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinuer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnContinuer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnContinuer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnContinuer.Location = new System.Drawing.Point(122, 102);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(243, 35);
            this.btnContinuer.TabIndex = 3;
            this.btnContinuer.Text = "CONTINUER";
            this.btnContinuer.UseVisualStyleBackColor = true;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // btnConfigurer
            // 
            this.btnConfigurer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnConfigurer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfigurer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfigurer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConfigurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigurer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfigurer.Location = new System.Drawing.Point(122, 184);
            this.btnConfigurer.Name = "btnConfigurer";
            this.btnConfigurer.Size = new System.Drawing.Size(243, 35);
            this.btnConfigurer.TabIndex = 4;
            this.btnConfigurer.Text = "CONFIGURER";
            this.btnConfigurer.UseVisualStyleBackColor = true;
            this.btnConfigurer.Click += new System.EventHandler(this.btnConfigurer_Click);
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackgroundImage = global::RlzProj.Properties.Resources.bgback;
            this.pnl_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Body.Controls.Add(this.btn_Refresh);
            this.pnl_Body.Controls.Add(this.btnQuitter);
            this.pnl_Body.Controls.Add(this.btnContinuer);
            this.pnl_Body.Controls.Add(this.btnConfigurer);
            this.pnl_Body.Controls.Add(this.pnl_State);
            this.pnl_Body.Controls.Add(this.lbl_DBState);
            this.pnl_Body.Controls.Add(this.pictureBox2);
            this.pnl_Body.Controls.Add(this.pictureBox1);
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Location = new System.Drawing.Point(0, 0);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(466, 414);
            this.pnl_Body.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Refresh.Location = new System.Drawing.Point(122, 143);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(243, 35);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "RAFRÂICHIRE";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.Color.Crimson;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuitter.Location = new System.Drawing.Point(122, 225);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(243, 35);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pnl_State
            // 
            this.pnl_State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_State.Controls.Add(this.lbl_Header_Menu);
            this.pnl_State.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_State.Location = new System.Drawing.Point(0, 0);
            this.pnl_State.Name = "pnl_State";
            this.pnl_State.Size = new System.Drawing.Size(464, 37);
            this.pnl_State.TabIndex = 2;
            // 
            // lbl_Header_Menu
            // 
            this.lbl_Header_Menu.AutoSize = true;
            this.lbl_Header_Menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Header_Menu.ForeColor = System.Drawing.Color.White;
            this.lbl_Header_Menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Header_Menu.Location = new System.Drawing.Point(66, 7);
            this.lbl_Header_Menu.Name = "lbl_Header_Menu";
            this.lbl_Header_Menu.Size = new System.Drawing.Size(330, 20);
            this.lbl_Header_Menu.TabIndex = 7;
            this.lbl_Header_Menu.Text = "GESTIONNAIRE DE PORTEFEUILLES DE PROJETS\r\n";
            this.lbl_Header_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RlzProj.Properties.Resources.ONEP_logo;
            this.pictureBox2.Location = new System.Drawing.Point(337, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 414);
            this.Controls.Add(this.pnl_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Body.PerformLayout();
            this.pnl_State.ResumeLayout(false);
            this.pnl_State.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_DBState;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.Button btnConfigurer;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Panel pnl_State;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Header_Menu;
        private System.Windows.Forms.Button btn_Refresh;
    }
}