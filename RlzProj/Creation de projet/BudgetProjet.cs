using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// IMPORT PACKAGE
using System.Data.SqlClient;


namespace RlzProj.Creation_de_projet
{
    public partial class BudgetProjet : Form
    {
        public BudgetProjet()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        // DECLARE
        int ID_MembreEquipe;
        // FUNCTIONS
        public void LoadListePersonnel()
        {
            try
            {
                // Load Combobox with EquipeProj Members
                Program.cnx.Open(); txt_Moyens_RH.Items.Clear();
                SqlCommand cmd = new SqlCommand("SELECT NomMembreEquipe FROM EquipeProj  WHERE IDProj=" + Program.IDProj, Program.cnx);
                SqlDataReader dr = cmd.ExecuteReader(); while (dr.Read()) { txt_Moyens_RH.Items.Add( dr["NomMembreEquipe"].ToString() ); } dr.Close(); Program.cnx.Close();
                Program.cnx.Close();
            }
            catch (Exception ex) { MessageBox.Show("Exception: \n" + ex,"Exception!",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }
        public int LoadIdMembreEquipe(string Nom_MembreEquipe)
        {
            try
            {
                Program.cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDMembreEquipe FROM EquipeProj  WHERE IDProj=" + Program.IDProj + "AND NomMembreEquipe='" + Nom_MembreEquipe + "'", Program.cnx);
                SqlDataReader dr = cmd.ExecuteReader(); while (dr.Read()) { ID_MembreEquipe = Convert.ToInt16(dr["IDMembreEquipe"]); } dr.Close(); Program.cnx.Close();
                
            }
            catch (Exception ex) { MessageBox.Show("Exception: \n" + ex, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return ID_MembreEquipe;
        }
        // LOAD
        private void BudgetProjet_Load(object sender, EventArgs e)
        {
            try{
            // TODO: This line of code loads data into the 'rlzDs.BudgetProj' table. You can move, or remove it, as needed.         
            this.budgetProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            this.budgetProjTableAdapter.Fill(this.rlzDs.BudgetProj);
            // IMPORT TABLE BudgetProj
            Program.da_BudgetsProj = new SqlDataAdapter("SELECT * FROM BudgetProj", Program.cnx);
            Program.da_BudgetsProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_BudgetsProj.Fill(Program.ds_RlzProj, "BudgetProj");
            Program.dt_BudgetsProj = Program.ds_RlzProj.Tables["BudgetProj"];
            // Load Combobox with EquipeProj Members
            LoadListePersonnel();
            }
            catch (Exception ex) { MessageBox.Show("Exception: \n" + ex, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        }      
        // AJOUT A LA LISTE
        private void btn_Ajouter_RH_Click(object sender, EventArgs e)
        {
            // CALL FUNCTION TO GET ID_MembreEquipe from Name_MemberEquipe
             ID_MembreEquipe  =  LoadIdMembreEquipe(txt_Moyens_RH.Text);

            lblErrorInfos.Text = "";         
            // ENREGISTREMENT OK
            try
            {
                SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_BudgetsProj);
                DataRow dar;
                dar = Program.dt_BudgetsProj.NewRow();
                dar["IDProj"] = Program.IDProj;
                //dar["IDBugdet"] = PRIMARY KEY not null IDENTITY (0,1),
                dar["Budget"] = Convert.ToDecimal(txt_Budget_RH.Text);
                dar["RaisonBudget"] = "Frais du personnels";
                dar["BudgetAttribueA"] = ID_MembreEquipe;
                dar["BudgetAttribueANom"] = txt_Moyens_RH.Text;
                Program.dt_BudgetsProj.Rows.Add(dar);
                Program.da_BudgetsProj.Update(Program.dt_BudgetsProj.Select("", "", DataViewRowState.Added));        
                lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; lblErrorInfos.Text = "Budget enregistrer avec succés.";
            }
            catch { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Budget non enregistrer,veuillez verifier la validité de tous les champs."; }
       try{
            // TODO: This line of code loads data into the 'rlzDs.BudgetProj' table. You can move, or remove it, as needed.         
            this.budgetProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            this.budgetProjTableAdapter.Fill(this.rlzDs.BudgetProj);
       }
       catch (Exception ex) { MessageBox.Show("Exception: \n" + ex, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void btn_Ajouter_RF_Click(object sender, EventArgs e)
            {
                lblErrorInfos.Text = "";   
                try
                {
                    SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_BudgetsProj);
                    DataRow dar;
                    dar = Program.dt_BudgetsProj.NewRow();
                    dar["IDProj"] = Program.IDProj;
                    //dar["IDBugdet"] = PRIMARY KEY not null IDENTITY (0,1),
                    dar["Budget"] = Convert.ToDecimal( txt_Budget_RF.Text);
                    if (rInvestisement.Checked == true) { dar["RaisonBudget"] = "Investisement"; };
                    if (rDepenseFonctionnement.Checked == true) { dar["RaisonBudget"] = "Dépense de fonctionnement"; };
                    if (rMachinismeVehicules.Checked == true) { dar["RaisonBudget"] = "Machinisme et véhicules"; };
                    if (rAlimentationLogement.Checked == true) { dar["RaisonBudget"] = "Alimentation et Logement"; };
                    if (rAutres.Checked == true) { dar["RaisonBudget"] = txt_Autres_RF.Text; };
                    dar["BudgetAttribueANom"] = "-";
                    Program.dt_BudgetsProj.Rows.Add(dar);
                    Program.da_BudgetsProj.Update(Program.dt_BudgetsProj.Select("", "", DataViewRowState.Added));         
                    lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; lblErrorInfos.Text = "Budget enregistrer avec succés.";
                }
                catch { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Budget non enregistrer,veuillez verifier la validité de tous les champs."; }
            try{
                // TODO: This line of code loads data into the 'rlzDs.BudgetProj' table. You can move, or remove it, as needed.         
                this.budgetProjBindingSource.Filter = "IDProj = " + Program.IDProj;
                this.budgetProjTableAdapter.Fill(this.rlzDs.BudgetProj);
            }
            catch (Exception ex) { MessageBox.Show("Exception: \n" + ex, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        // KEYPRESS
        private void txt_Budget_RH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == ',' ) // || e.KeyChar == '.'
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void txt_Budget_RF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == ',') // || e.KeyChar == '.'
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }      
        // GRAPH CHART
        private void btn_LoadBudgetChart_Click(object sender, EventArgs e)
        {
            ShowBudgetChart ShowBudgetChart = new ShowBudgetChart();
            ShowBudgetChart.Show();    
        }
      
        // WHEN DELETE A BUDGET FROM DataRepeater
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try{
            this.Validate();
            this.budgetProjBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rlzDs);

            lblErrorInfos.BackColor = Color.Crimson;
            lblErrorInfos.Text = "Budget retirer de la lise.";
            }
            catch (Exception ex) { MessageBox.Show("Exception: \n" + ex, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // END.

    }
}
