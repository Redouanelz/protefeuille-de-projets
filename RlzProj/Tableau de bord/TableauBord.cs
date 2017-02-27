using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RlzProj.Tableau_de_bord
{
    public partial class TableauBord : Form
    {
        public TableauBord()
        {
            InitializeComponent();
        }
        // BACK TO HOME.
        private void btn_RetourAcueille_Click(object sender, EventArgs e)
        {
           
        }
        // LOAD -- IMPORT TABLE FicheProj to show on the DataGridView
        private void TableauBord_Load(object sender, EventArgs e)
        {
            Program.da_FicheProj = null;
            Program.dt_FicheProj.Clear();
            // IMPORT TABLE FicheProj to show on the DataGridView
            Program.da_FicheProj = new SqlDataAdapter("SELECT * FROM FicheProj", Program.cnx);
            Program.da_FicheProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_FicheProj.Fill(Program.ds_RlzProj, "FicheProj");
            Program.dt_FicheProj = Program.ds_RlzProj.Tables["FicheProj"];
            Program.dv_FicheProj = Program.dt_FicheProj.DefaultView;
            Program.dv_FicheProj.Sort = "IDProj DESC";            
            dg_dashBoard.DataSource = Program.dv_FicheProj;
        }
        // AT THE CELL CONTENT CLICK
        private void dg_dashBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dg_dashBoard.SelectedCells[0].RowIndex;
            txt_ID.Text = dg_dashBoard.Rows[i].Cells[0].Value.ToString();          
            txt_Code.Text = dg_dashBoard.Rows[i].Cells[2].Value.ToString();           
        }
        private void dg_dashBoard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dg_dashBoard.SelectedCells[0].RowIndex;
            txt_ID.Text = dg_dashBoard.Rows[i].Cells[0].Value.ToString();
            txt_Code.Text = dg_dashBoard.Rows[i].Cells[2].Value.ToString();  
        }
        // FILTER DATA
        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            if (txt_Statut.Text == "Tous")
            {
                Program.dv_FicheProj.RowFilter = "";
            }
            if (txt_Statut.Text == "Intension")
            {
                Program.dv_FicheProj.RowFilter = "StatutProj = 'Intension'";
            }
            if (txt_Statut.Text == "En cours")
            {
                Program.dv_FicheProj.RowFilter = "StatutProj = 'En cours'";
            }
            if (txt_Statut.Text == "Terminer")
            {
                Program.dv_FicheProj.RowFilter = "StatutProj = 'Terminer'";
            }
            if (txt_Statut.Text == "Archiver")
            {
                Program.dv_FicheProj.RowFilter = "StatutProj = 'Archiver'";
            }
        }
        // GO > EspaceProjet
        private void btnAfficherProjet_Click(object sender, EventArgs e)
        {
            // IMPORT TABLE FicheProj to TEST IF EXIST OR NOT 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT IDProj FROM FicheProj", Program.cnx);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(Program.ds_RlzProj, "FicheProj_toFilter");
            dt = Program.ds_RlzProj.Tables["FicheProj_toFilter"];
            // TEST IF EXIST + TESTE IF IsNullOrEmpty
            bool ok = false;
            if (String.IsNullOrEmpty(txt_ID.Text)) { ErrID.Icon = Properties.Resources.error; ErrID.SetError(txt_ID, "Champs obligatoire, veuillez remplire ce champ."); }
            else
            {
                ErrID.Icon = Properties.Resources.oky; ErrID.SetError(txt_ID, "");
                for (int i = 0; i < Program.dt_FicheProj.Rows.Count; i++)
                {
                    if (dt.Rows[i]["IDProj"].ToString() == txt_ID.Text)
                    {
                        ok = true; break;
                    }
                } 
            }
            // IF OK OPEN EspaceProjet AND SET  Program.IDProj
            if (ok == true)
            {
                string IDProj = txt_ID.Text;
                Program.IDProj = Convert.ToInt32(IDProj);
                RlzProj.Tableau_de_bord.EspaceProjet Work_Space = new RlzProj.Tableau_de_bord.EspaceProjet();
                Work_Space.Show();
                this.Close();
            } else {
                MessageBox.Show("Fiche introuvable.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);                 
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_RetourAcueille_Click_1(object sender, EventArgs e)
        {
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();
            this.Close();
        }
    }
}
