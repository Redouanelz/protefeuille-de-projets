using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RlzProj.Profile
{
    public partial class MesTaches : Form
    {
        public MesTaches()
        {
            InitializeComponent();
        }
        // FUNCTION TO LOAD TASKS LISTE 
        public void loadTasksTable()
        {
            // LOAD ALL TachesProj table.
            Program.da_TachesProj = new SqlDataAdapter("SELECT * FROM TachesPRoj", Program.cnx);
            Program.da_TachesProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_TachesProj.Fill(Program.ds_RlzProj, "TachesProj");
            Program.dt_TachesProj = Program.ds_RlzProj.Tables["Tachesproj"];
        }
        public void loadTasksListe()
        {
            Program.da_MesTaches = null;
            Program.dt_MesTaches.Clear();
            // IMPORT TABLE MesTaches to show on the DataGridView
            Program.da_MesTaches = new SqlDataAdapter("SELECT distinct T.laTache, T.StatutTache,T.IDTache, T.IDProj ,  F.NomProj , P.IDPerso FROM FicheProj F,Personnel P, EquipeProj E, TachesProj T WHERE P.IDPerso = E.IDPerso and E.IDMembreEquipe = T.TacheAttribueA AND P.IDPerso = " + Program.IDPerso + " AND T.IDProj = F.IDProj", Program.cnx);
            Program.da_MesTaches.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_MesTaches.Fill(Program.ds_RlzProj, "MesTaches");
            Program.dt_MesTaches = Program.ds_RlzProj.Tables["MesTaches"];
           // Program.dv_MesTaches = Program.dt_MesTaches.DefaultView;

            // Program.dv_FicheProj.Sort = "x DESC";            
            dg_MyTasks.DataSource = Program.dt_MesTaches;
           //  DataGridViewColumn column2 = dg_MyTasks.Columns["T.laTache"];
           // column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void MesTaches_Load(object sender, EventArgs e)
        {
            // LOAD DGV
            loadTasksListe();
            loadTasksTable();

        }              
        // FILL INPUTS WHEN CELL CLICK EVE
        private void dg_MyTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dg_MyTasks.SelectedCells[0].RowIndex;
                txt_LaTache.Text = dg_MyTasks.Rows[i].Cells[0].Value.ToString();
                txtStatut.Text = dg_MyTasks.Rows[i].Cells[1].Value.ToString();
                txtIDtache.Text = dg_MyTasks.Rows[i].Cells[2].Value.ToString();
                txtIDProjet.Text = dg_MyTasks.Rows[i].Cells[3].Value.ToString();
                txtNomProjet.Text = dg_MyTasks.Rows[i].Cells[4].Value.ToString();
                txtIDPerso.Text = dg_MyTasks.Rows[i].Cells[5].Value.ToString();
            }
            catch { }
        }
        private void dg_MyTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dg_MyTasks.SelectedCells[0].RowIndex;
                txt_LaTache.Text = dg_MyTasks.Rows[i].Cells[0].Value.ToString();
                txtStatut.Text = dg_MyTasks.Rows[i].Cells[1].Value.ToString();
                txtIDtache.Text = dg_MyTasks.Rows[i].Cells[2].Value.ToString();
                txtIDProjet.Text = dg_MyTasks.Rows[i].Cells[3].Value.ToString();
                txtNomProjet.Text = dg_MyTasks.Rows[i].Cells[4].Value.ToString();
                txtIDPerso.Text = dg_MyTasks.Rows[i].Cells[5].Value.ToString();
            }
            catch { }
        }
        // NEXT - PREVIOUS
        private void btnSuivant_Click(object sender, EventArgs e)
        {
           

            int pos = -1;
            for (int i = 0; i < Program.dt_MesTaches.Rows.Count; i++)
            {
                if (txtIDtache.Text == Program.dt_MesTaches.Rows[i]["IDTache"].ToString() && i < Program.dt_MesTaches.Rows.Count - 1)
                {
                    pos = i;
                    break;
                }
                if (i == Program.dt_MesTaches.Rows.Count - 1)
                {
                    // Dernier Enregistrement - do nothing.
                }
            }
            if (pos != -1)
            {
                int numOfRows = dg_MyTasks.Rows.Count - 1;
                int index = dg_MyTasks.SelectedRows[0].Index;
                if (index < numOfRows)
                { dg_MyTasks.CurrentCell = dg_MyTasks[0, index + 1]; }
                else
                { dg_MyTasks.CurrentCell = dg_MyTasks[0, 0]; }

                txt_LaTache.Text = Program.dt_MesTaches.Rows[pos + 1][0].ToString();
                txtStatut.Text = Program.dt_MesTaches.Rows[pos + 1][1].ToString();
                txtIDtache.Text = Program.dt_MesTaches.Rows[pos + 1][2].ToString();
                txtIDProjet.Text = Program.dt_MesTaches.Rows[pos + 1][3].ToString();
                txtNomProjet.Text = Program.dt_MesTaches.Rows[pos + 1][4].ToString();
                txtIDPerso.Text = Program.dt_MesTaches.Rows[pos + 1][5].ToString();
            }


        }
        private void btnPrecedent_Click(object sender, EventArgs e)
        {


            for (int i = Program.dt_MesTaches.Rows.Count-1 ; i > 0 ; i--)
            {
                if (txtIDtache.Text == Program.dt_MesTaches.Rows[i][2].ToString() && i > 0)
                {
                    int numOfRows = dg_MyTasks.Rows.Count - 1;
                    int index = dg_MyTasks.SelectedRows[0].Index;
                    if (index != 0)
                    { dg_MyTasks.CurrentCell = dg_MyTasks[0, index - 1]; }
                    else
                    { dg_MyTasks.CurrentCell = dg_MyTasks[0, numOfRows]; }

                    txt_LaTache.Text = Program.dt_MesTaches.Rows[i - 1][0].ToString();
                    txtStatut.Text = Program.dt_MesTaches.Rows[i - 1][1].ToString();
                    txtIDtache.Text = Program.dt_MesTaches.Rows[i - 1][2].ToString();
                    txtIDProjet.Text = Program.dt_MesTaches.Rows[i - 1][3].ToString();
                    txtNomProjet.Text = Program.dt_MesTaches.Rows[i - 1][4].ToString();
                    txtIDPerso.Text = Program.dt_MesTaches.Rows[i - 1][5].ToString();
                    break;
                }
            }

        }
        // This.Close
        private void btnFermer_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        // SAVE UPDATED AND DELETED INFOS
        private void btnEnregistrerTache_Click(object sender, EventArgs e)
        {
            loadTasksTable();
            lblNotif.Text = "";
            try
            {
                SqlCommandBuilder saver = new SqlCommandBuilder(Program.da_TachesProj);
                DataRow Row;
                Row = Program.dt_TachesProj.Rows.Find(Convert.ToInt16(txtIDtache.Text));
                Row.BeginEdit();
                Row["LaTache"] = txt_LaTache.Text;
                Row["StatutTache"] = txtStatut.Text;
                Row.EndEdit();
                Program.da_TachesProj.Update(Program.dt_TachesProj.Select("", "", DataViewRowState.ModifiedCurrent));
                lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); lblNotif.Text = "Modification réussite.";
            }
            catch { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Modifications non enregistrer, veuillez vérifier la validité des champs."; }
            loadTasksListe();
        }
        private void btnSupprimerTache_Click(object sender, EventArgs e)
        {
            loadTasksTable();
            lblNotif.Text = "";
            try
            {
                SqlCommandBuilder saver = new SqlCommandBuilder(Program.da_TachesProj);
                int pos = -1;
                bool Find = false;
                for (int i = 0; i < Program.dt_TachesProj.Rows.Count; i++)
                {
                    if (Program.dt_TachesProj.Rows[i]["IDTache"].ToString() == txtIDtache.Text)
                    {
                        pos = i; Find = true;
                        break;
                    }
                }
                if (Find == true && pos != -1)
                {
                    Program.dt_TachesProj.Rows[pos].Delete();
                    Program.da_TachesProj.Update(Program.dt_TachesProj.Select("", "", DataViewRowState.Deleted));
                    lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); lblNotif.Text = "Suppresion réusite.";
                }
                else
                {
                    lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Suppresion non réussite, veuillez vérifier la validité de l'enregistrement.";
                }            
            }
            catch { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Suppresion non réussite, veuillez vérifier la validité de l'enregistrement."; }
            loadTasksListe();
        }

  
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
