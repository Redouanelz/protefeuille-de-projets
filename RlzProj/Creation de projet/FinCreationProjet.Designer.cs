namespace RlzProj.Creation_de_projet
{
    partial class FinCreationProjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinCreationProjet));
            this.RapportCreationProjet = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnLoadRaportFCP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RapportCreationProjet
            // 
            this.RapportCreationProjet.ActiveViewIndex = -1;
            this.RapportCreationProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RapportCreationProjet.Cursor = System.Windows.Forms.Cursors.Default;
            this.RapportCreationProjet.DisplayStatusBar = false;
            this.RapportCreationProjet.Location = new System.Drawing.Point(12, 53);
            this.RapportCreationProjet.Name = "RapportCreationProjet";
            this.RapportCreationProjet.ShowGotoPageButton = false;
            this.RapportCreationProjet.ShowGroupTreeButton = false;
            this.RapportCreationProjet.ShowParameterPanelButton = false;
            this.RapportCreationProjet.ShowRefreshButton = false;
            this.RapportCreationProjet.ShowTextSearchButton = false;
            this.RapportCreationProjet.Size = new System.Drawing.Size(986, 455);
            this.RapportCreationProjet.TabIndex = 0;
            this.RapportCreationProjet.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnLoadRaportFCP
            // 
            this.btnLoadRaportFCP.FlatAppearance.BorderSize = 2;
            this.btnLoadRaportFCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRaportFCP.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadRaportFCP.ForeColor = System.Drawing.Color.White;
            this.btnLoadRaportFCP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadRaportFCP.Location = new System.Drawing.Point(404, 12);
            this.btnLoadRaportFCP.Name = "btnLoadRaportFCP";
            this.btnLoadRaportFCP.Size = new System.Drawing.Size(204, 35);
            this.btnLoadRaportFCP.TabIndex = 0;
            this.btnLoadRaportFCP.Text = "CHARGER LE RAPORT";
            this.btnLoadRaportFCP.UseVisualStyleBackColor = true;
            this.btnLoadRaportFCP.Click += new System.EventHandler(this.btnLoadRaportFCP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "RAPORT DE FIN DE CREATION DU PROJET";
            // 
            // FinCreationProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1010, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoadRaportFCP);
            this.Controls.Add(this.RapportCreationProjet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinCreationProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinCreationProjet";
            this.Load += new System.EventHandler(this.FinCreationProjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RapportCreationProjet;
        private System.Windows.Forms.Button btnLoadRaportFCP;
        private System.Windows.Forms.Label label3;

    }
}