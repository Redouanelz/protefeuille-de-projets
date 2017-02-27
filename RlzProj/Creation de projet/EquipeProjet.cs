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
    public partial class EquipeProjet : Form
    {
        public EquipeProjet()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        // FUNCTION
        public void LoadListePersonnel()
        {
            // Load Combobox
            Program.cnx.Open(); txt_PersonnelID.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT IDPerso FROM Personnel", Program.cnx);
            SqlDataReader dr = cmd.ExecuteReader(); while (dr.Read()) { txt_PersonnelID.Items.Add(dr["IDPerso"]); } dr.Close(); Program.cnx.Close();
        }
        // LOAD
        private void EquipeProjet_Load(object sender, EventArgs e)
        {
            // IMPORT ChefProj
            Program.cnx.Open(); 
            SqlCommand cmd = new SqlCommand("SELECT ChefProj FROM FicheProj Where IDProj="+Program.IDProj, Program.cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader(); while (dr.Read()) { lbl_ChefProjet.Text = dr["ChefProj"].ToString(); } dr.Close(); Program.cnx.Close();
            // IMPORT TABLE EquipeProj
            Program.da_EquipeProj = new SqlDataAdapter("SELECT * FROM EquipeProj", Program.cnx);
            Program.da_EquipeProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_EquipeProj.Fill(Program.ds_RlzProj, "EquipeProj");
            Program.dt_EquipeProj = Program.ds_RlzProj.Tables["EquipeProj"];
            // LOAD COMBOBOX
            LoadListePersonnel();
            // TODO: This line of code loads data into the 'rlzDs.EquipeProj' table. You can move, or remove it, as needed.
            this.equipeProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            this.equipeProjTableAdapter.Fill(this.rlzDs.EquipeProj);
        }
        // WHEN SELECT AN INDEX, GET FULL NAME OF Personnel
        private void txt_Personnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cnx.Open(); txt_PersonnelChoisi.Clear();
            SqlCommand cmd = new SqlCommand("SELECT NomPerso,PrenomPerso FROM Personnel WHERE IDPerso=" +txt_PersonnelID.Text+";", Program.cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader(); while (dr.Read()) { txt_PersonnelChoisi.Text = dr["NomPerso"].ToString() + " " + dr["PrenomPerso"].ToString(); } dr.Close(); Program.cnx.Close();           
        }
        // WHEN DELETE A MEMEBER FROM DataRepeater
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.equipeProjBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.rlzDs);

                lblErrorInfos.BackColor = Color.Crimson;
                lblErrorInfos.Text = "Membre d'equipe Exclu du groupe.";
            }
            catch { }
        }
        // AJOUT A L'EQUIPE
        private void btnAjouterAEquipe_Click(object sender, EventArgs e)
        {
            // CHECK IF PROJECT ALREADY EXIST TO ADD SQUAD MEMBERS
            lblErrorInfos.Text = "";
                bool Find = false;
                lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; lblErrorInfos.Text = "OK";
                for (int i = 0; i < Program.dt_EquipeProj.Rows.Count; i++)
                {
                    if (Program.dt_EquipeProj.Rows[i]["IDProj"].ToString() == Program.IDProj.ToString() && Program.dt_EquipeProj.Rows[i]["IDPerso"].ToString() == txt_PersonnelID.Text)
                    {
                        lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                        lblErrorInfos.Text = "Déjà Ajouter ou exclu de l'équipe.";
                        Find = true;
                        break;
                    }
                    else
                    {
                        Find = false;
                    }
                }
                if (Find == false)
                {
                    // ADD SQUAD MEMBERS
                    try
                    {
                        SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_EquipeProj);
                        DataRow dar;
                        dar = Program.dt_EquipeProj.NewRow();
                        dar["IDProj"] = Program.IDProj;
                        dar["IDPerso"] = Convert.ToInt32(txt_PersonnelID.Text);
                        // dar["IDMembreEquipe"] = IDENTITY(0,1) Auto-Increment
                        dar["NomMembreEquipe"] = txt_PersonnelChoisi.Text;
                        dar["RoleSurProj"] = txt_Role.Text;

                        Program.dt_EquipeProj.Rows.Add(dar);
                        Program.da_EquipeProj.Update(Program.dt_EquipeProj.Select("", "", DataViewRowState.Added));
                        lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                        lblErrorInfos.Text = "Membre d'équipe [ " + dar["NomMembreEquipe"].ToString() + " ] ajouter.";
                    }
                    catch { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Membre d'equipe non ajouter veuillez verifier la validité de tous les champs."; }
                }
            // TODO: This line of code loads data into the 'rlzDs.EquipeProj' table. You can move, or remove it, as needed.
            this.equipeProjBindingSource.Filter = "IDProj = " + Program.IDProj;
            this.equipeProjTableAdapter.Fill(this.rlzDs.EquipeProj);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // END.


    }
}
