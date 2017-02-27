using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RlzProj.Creation_de_projet
{
    public partial class ShowBudgetChart : Form
    {
        public ShowBudgetChart()
        {
            InitializeComponent();
        }

        private void btn_LoadBudgetChart_Click(object sender, EventArgs e)
        {
            try
            {

                this.Chart_Budget.Series["Budget"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                this.Chart_Budget.Series["Budget"].Points.Clear();
                Program.cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Budget,RaisonBudget FROM BudgetProj WHERE IDProj=" + Program.IDProj, Program.cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.Chart_Budget.Series["Budget"].Points.AddXY(dr["RaisonBudget"], dr["Budget"]);
                }
                dr.Close(); Program.cnx.Close();
            }
            catch { }
        }

        private void btn_LoadBudgetChart_Pie_Click(object sender, EventArgs e)
        {
            try
            {

                this.Chart_Budget.Series["Budget"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                this.Chart_Budget.Series["Budget"].Points.Clear();
                Program.cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Budget,RaisonBudget FROM BudgetProj WHERE IDProj=" + Program.IDProj, Program.cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.Chart_Budget.Series["Budget"].Points.AddXY(dr["RaisonBudget"], dr["Budget"]);
                }
                dr.Close(); Program.cnx.Close();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
