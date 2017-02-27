namespace RlzProj.Creation_de_projet
{
    partial class ShowBudgetChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBudgetChart));
            this.pnlChart = new System.Windows.Forms.Panel();
            this.Chart_Budget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_LoadBudgetChart_Columns = new System.Windows.Forms.Button();
            this.btn_LoadBudgetChart_Pie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Budget)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlChart.Controls.Add(this.Chart_Budget);
            this.pnlChart.Location = new System.Drawing.Point(42, 12);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(970, 380);
            this.pnlChart.TabIndex = 38;
            // 
            // Chart_Budget
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_Budget.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_Budget.Legends.Add(legend1);
            this.Chart_Budget.Location = new System.Drawing.Point(2, 1);
            this.Chart_Budget.Name = "Chart_Budget";
            this.Chart_Budget.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.Legend = "Legend1";
            series1.Name = "Budget";
            this.Chart_Budget.Series.Add(series1);
            this.Chart_Budget.Size = new System.Drawing.Size(968, 377);
            this.Chart_Budget.TabIndex = 0;
            this.Chart_Budget.Text = "BudgetChart";
            // 
            // btn_LoadBudgetChart_Columns
            // 
            this.btn_LoadBudgetChart_Columns.BackColor = System.Drawing.Color.Transparent;
            this.btn_LoadBudgetChart_Columns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadBudgetChart_Columns.FlatAppearance.BorderSize = 2;
            this.btn_LoadBudgetChart_Columns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadBudgetChart_Columns.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_LoadBudgetChart_Columns.ForeColor = System.Drawing.Color.White;
            this.btn_LoadBudgetChart_Columns.Image = global::RlzProj.Properties.Resources.tableau_icone_6011_48;
            this.btn_LoadBudgetChart_Columns.Location = new System.Drawing.Point(382, 398);
            this.btn_LoadBudgetChart_Columns.Name = "btn_LoadBudgetChart_Columns";
            this.btn_LoadBudgetChart_Columns.Size = new System.Drawing.Size(142, 55);
            this.btn_LoadBudgetChart_Columns.TabIndex = 3;
            this.btn_LoadBudgetChart_Columns.UseVisualStyleBackColor = false;
            this.btn_LoadBudgetChart_Columns.Click += new System.EventHandler(this.btn_LoadBudgetChart_Click);
            // 
            // btn_LoadBudgetChart_Pie
            // 
            this.btn_LoadBudgetChart_Pie.BackColor = System.Drawing.Color.Transparent;
            this.btn_LoadBudgetChart_Pie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadBudgetChart_Pie.FlatAppearance.BorderSize = 2;
            this.btn_LoadBudgetChart_Pie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadBudgetChart_Pie.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btn_LoadBudgetChart_Pie.ForeColor = System.Drawing.Color.White;
            this.btn_LoadBudgetChart_Pie.Image = global::RlzProj.Properties.Resources.diagramme_icone_6234_48;
            this.btn_LoadBudgetChart_Pie.Location = new System.Drawing.Point(530, 398);
            this.btn_LoadBudgetChart_Pie.Name = "btn_LoadBudgetChart_Pie";
            this.btn_LoadBudgetChart_Pie.Size = new System.Drawing.Size(142, 55);
            this.btn_LoadBudgetChart_Pie.TabIndex = 39;
            this.btn_LoadBudgetChart_Pie.UseVisualStyleBackColor = false;
            this.btn_LoadBudgetChart_Pie.Click += new System.EventHandler(this.btn_LoadBudgetChart_Pie_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 55);
            this.button1.TabIndex = 40;
            this.button1.Text = "&FERMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowBudgetChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1055, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_LoadBudgetChart_Pie);
            this.Controls.Add(this.btn_LoadBudgetChart_Columns);
            this.Controls.Add(this.pnlChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowBudgetChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphique du Budget";
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Budget)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Button btn_LoadBudgetChart_Columns;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Budget;
        private System.Windows.Forms.Button btn_LoadBudgetChart_Pie;
        private System.Windows.Forms.Button button1;
    }
}