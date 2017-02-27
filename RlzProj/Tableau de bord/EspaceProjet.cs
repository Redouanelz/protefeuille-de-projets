using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Imported Packages
using System.Data.SqlClient;

namespace RlzProj.Tableau_de_bord
{
    public partial class EspaceProjet : Form
    {
        // FORMS_INITIALIZE
        private Tableau_de_bord.FicheProjet Fiche;
        private Creation_de_projet.EquipeProjet Equipe;
        private Creation_de_projet.BudgetProjet Budget;
        private Creation_de_projet.TachesProjet Taches;
        private Tableau_de_bord.EtatProjet Etat;

        public EspaceProjet()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
         // FONCTION CHARGEMENTS DE FORMS DEPUIS LE MENU DE CREATION DE PROJETS
         public void ChargementForms(Form FormName)
        {

            var SaveFirstActiveForm = ActiveMdiChild;
            // TEST
            if (SaveFirstActiveForm == FormName)
            { /* Rien. */ }
            else if (SaveFirstActiveForm != Fiche.ActiveMdiChild)
            {
                FormName.SuspendLayout();
                // SAVE.
                SaveFirstActiveForm = ActiveMdiChild;
                // SHOW.
                FormName.MdiParent = this;
                FormName.Dock = DockStyle.Fill;
                FormName.Show();
                // HIDE.
                SaveFirstActiveForm.Hide();
                FormName.ResumeLayout();
            }
        }       
        // BACK TO HOME. BACK TO DASHBOARD
        private void btn_RetourAcueille_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();    
        }
        private void btn_DashBoard_Click(object sender, EventArgs e)
        {
            RlzProj.Tableau_de_bord.TableauBord DashBoard = new RlzProj.Tableau_de_bord.TableauBord();
            DashBoard.Show();
            this.Close();
        }
        // LOAD
        private void EspaceProjet_Load(object sender, EventArgs e)
        {
            // FORMS_INSTANCE
            Fiche = new FicheProjet();
            Equipe = new Creation_de_projet.EquipeProjet();
            Budget = new Creation_de_projet.BudgetProjet();
            Taches = new Creation_de_projet.TachesProjet();
            Etat = new EtatProjet();
            // LOAD_Fiche
            Etat.MdiParent = this;
            Etat.Dock = DockStyle.Fill;
            Etat.Show();
            // TEST CNX TO DATABASE
            try
            {
                Program.cnx.Open();
                lbl_EtatDb.Text = "BASE DE DONNEES : ON";
                lbl_EtatDb.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                Program.cnx.Close(); 
            }
            catch
            {
                lbl_EtatDb.Text = "BASE DE DONNEES : OFF";
                lbl_EtatDb.ForeColor = Color.Crimson;
            }

            // LOAD A NEW PROJECT ID to work in/out
            // FicheProj
            try
            {                              
                // Program.IDProj = Convert.ToInt32(Program.dt_FicheProj.Rows.Count);
                lbl_REF_PROJ.Text = "REFERENCE DU PROJET : " + Program.IDProj.ToString();
            }
            catch { }
        }



        // MENU CREATION DE PROJETS
        private void btn_Fiche_Click(object sender, EventArgs e)
        {
            ChargementForms(Fiche);
        }

        private void btn_Equipe_Click(object sender, EventArgs e)
        {
            ChargementForms(Equipe);
        }

        private void btn_Budget_Click(object sender, EventArgs e)
        {
            ChargementForms(Budget);
        }

        private void btn_TachesJalons_Click(object sender, EventArgs e)
        {
            ChargementForms(Taches);
        }

        private void btn_Etat_Click(object sender, EventArgs e)
        {
            ChargementForms(Etat);
        }


        private void btn_RetourAcueille_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();
        }

        // EFFECTS LAB. //
        // Accueille effect back button.
        private void btn_RetourAcueille_MouseEnter(object sender, EventArgs e)
        {
            btn_RetourAcueille.Image = Properties.Resources.accueil_icone_6603_32;
            btn_RetourAcueille.ImageAlign = ContentAlignment.MiddleCenter;
            btn_RetourAcueille.BackColor = Color.White;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_RetourAcueille, "[Espace d'Accueille]");
        }

        private void btn_RetourAcueille_MouseLeave(object sender, EventArgs e)
        {
            btn_RetourAcueille.Image = Properties.Resources.Accueille;
            btn_RetourAcueille.ImageAlign = ContentAlignment.MiddleCenter;
            btn_RetourAcueille.BackColor = Color.White;
        }

        // EFFECTS LAB //
        // ETAT
        private void btn_Etat_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_Etat);
        }
        private void btn_Etat_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_Etat);
        }
        // FICHE
        private void btn_Fiche_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_Fiche);
        }

        private void btn_Fiche_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_Fiche);
        }
        // EQUIPE
        private void btn_Equipe_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_Equipe);
        }

        private void btn_Equipe_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_Equipe);
        }
        // BUDGET
        private void btn_Budget_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_Budget);
        }

        private void btn_Budget_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_Budget);
        }
        // TACHES/JALONS
        private void btn_TachesJalons_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_TachesJalons);
        }

        private void btn_TachesJalons_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_TachesJalons);
        }
        // Minimized and Exit
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_RetourAcueille_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
