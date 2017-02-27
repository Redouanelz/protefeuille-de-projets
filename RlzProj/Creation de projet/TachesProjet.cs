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
    public partial class TachesProjet : Form
    {
        public TachesProjet()
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
            // Load Combobox with EquipeProj Members
            Program.cnx.Open(); txt_tacheAttribueA.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT NomMembreEquipe FROM EquipeProj  WHERE IDProj=" + Program.IDProj, Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read()) 
            { txt_tacheAttribueA.Items.Add(dr["NomMembreEquipe"].ToString()); } 
            dr.Close(); Program.cnx.Close();
        }
        public int LoadIdMembreEquipe(string Nom_MembreEquipe)
        {
            Program.cnx.Open();
            SqlCommand cmd = new SqlCommand("SELECT IDMembreEquipe FROM EquipeProj  WHERE IDProj=" + Program.IDProj + "AND NomMembreEquipe='" + Nom_MembreEquipe + "'", Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read())
            { ID_MembreEquipe = Convert.ToInt16(dr["IDMembreEquipe"]); } 
            dr.Close(); Program.cnx.Close();
            return ID_MembreEquipe;

        }
        // LOAD
        private void TachesProjet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
            this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
            this.tachesProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            // IMPORT TABLE TachesProj
            Program.da_TachesProj = new SqlDataAdapter("SELECT * FROM TachesProj", Program.cnx);
            Program.da_TachesProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_TachesProj.Fill(Program.ds_RlzProj, "TachesProj");
            Program.dt_TachesProj = Program.ds_RlzProj.Tables["TachesProj"];
            // LOAD Combobox
            LoadListePersonnel();
        }
        // ADD TO LISTE
        private void btn_Ajouter_Tache_Click(object sender, EventArgs e)
        {
            // CALL FUNCTION TO GET ID_MembreEquipe from Name_MemberEquipe
            ID_MembreEquipe = LoadIdMembreEquipe(txt_tacheAttribueA.Text);

            lblErrorInfos.Text = "";
            // ENREGISTREMENT OK
            try
            {
                SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_TachesProj);
                DataRow dar;
                dar = Program.dt_TachesProj.NewRow();
                dar["IDProj"] = Program.IDProj;
                //dar["IDTache"] = PRIMARY KEY not null IDENTITY (0,1),
                dar["LaTache"] = txt_laTache.Text;
                dar["StatutTache"] = txt_statutTache.Text;
                dar["TacheAttribueA"] = ID_MembreEquipe;
                dar["TacheAttribueANom"] = txt_tacheAttribueA.Text;
                Program.dt_TachesProj.Rows.Add(dar);
                Program.da_TachesProj.Update(Program.dt_TachesProj.Select("", "", DataViewRowState.Added));
                txt_laTache.Clear();        
                lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; lblErrorInfos.Text = "Tache enregistrer avec succés.";
            }
            catch { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Tache non enregistrer,veuillez verifier la validité de tous les champs."; }

            // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
            this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
            this.tachesProjBindingSource.Filter = "IDProj = " + Program.IDProj;
        }
        // DELETE FROM THE LISTE
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tachesProjBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rlzDs);

            // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
            this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
            this.tachesProjBindingSource.Filter = "IDProj = " + Program.IDProj;
        }
               

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tachesProjBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rlzDs);

            lblErrorInfos.BackColor = Color.Crimson;
            lblErrorInfos.Text = "Membre d'equipe Exclu du groupe.";
        }

        // FILTER TASKS
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (cmb_FilterTaches.Text == "Tous")
            {
                // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
                this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
                this.tachesProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            }
            if (cmb_FilterTaches.Text == "Nouvelle tache")
            {
                // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
                this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
                this.tachesProjBindingSource.Filter = "StatutTache = 'Nouvelle tache' AND IDProj = " + Program.IDProj;
            }
            if (cmb_FilterTaches.Text == "En cours")
            {
                // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
                this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
                this.tachesProjBindingSource.Filter = "StatutTache = 'En cours' AND IDProj = " + Program.IDProj;
            }
            if (cmb_FilterTaches.Text == "Terminer")
            {
                // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
                this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
                this.tachesProjBindingSource.Filter = "StatutTache = 'Terminer' AND IDProj = " + Program.IDProj;
            }
            if (cmb_FilterTaches.Text == "En Attente")
            {
                // TODO: This line of code loads data into the 'rlzDs.TachesProj' table. You can move, or remove it, as needed.
                this.tachesProjTableAdapter.Fill(this.rlzDs.TachesProj);
                this.tachesProjBindingSource.Filter = "StatutTache = 'En Attente' AND IDProj = " + Program.IDProj;
            }
        }




   
    }
}
