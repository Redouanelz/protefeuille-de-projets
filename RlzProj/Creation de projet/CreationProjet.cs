using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Imported Packages
using RlzProj.Creation_de_projet;
using System.Data.SqlClient;

namespace RlzProj
{
    public partial class CreationProjet : Form
    {

        // FORMS_INITIALIZE
            private FicheProjet Fiche;
            private EquipeProjet Equipe;
            private BudgetProjet Budget;
            private TachesProjet Taches;
            private FinCreationProjet FinCreation;

        // WORK_INITIALIZE
         public CreationProjet()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        // FONCTION CHARGEMENTS DE FORMS DEPUIS LE MENU DE CREATION DE PROJETS -- RETIRER.
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
        // FORM_LOAD
       private void CreationProjet_Load(object sender, EventArgs e)
        {
           // ENABLE STEPS TURN TO FALSE
            btn_Equipe.Enabled = false;
            btn_Budget.Enabled = false;
            btn_TachesJalons.Enabled = false;
            btn_FinCreation.Enabled = false;           
            // FORMS_INSTANCE
            Fiche = new FicheProjet();
            Equipe = new EquipeProjet();
            Budget = new BudgetProjet();
            Taches = new TachesProjet();
            FinCreation = new FinCreationProjet();
            // LOAD_Fiche
            Fiche.MdiParent = this;
            Fiche.Dock = DockStyle.Fill;
            Fiche.Show();
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
                Program.da_FicheProj = new SqlDataAdapter("SELECT * FROM FicheProj", Program.cnx);
                Program.da_FicheProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.da_FicheProj.Fill(Program.ds_RlzProj, "FicheProj");
                Program.dt_FicheProj = Program.ds_RlzProj.Tables["FicheProj"];
                int lastIDProj = Convert.ToInt32(Program.dt_FicheProj.Rows[Program.dt_FicheProj.Rows.Count - 1]["IDProj"]);
                Program.IDProj = lastIDProj + 1;
                // Program.IDProj = Convert.ToInt32(Program.dt_FicheProj.Rows.Count);
                lbl_REF_PROJ.Text = "REFERENCE DU PROJET : " + Program.IDProj.ToString();
            }
            catch { }
        }

        // MENU CREATION DE PROJETS
        private void btn_Fiche_Click(object sender, EventArgs e)
        {
            if (Program.FicheProjOk == true)
            {
                //ChargementForms(Fiche);
                btn_Fiche.Enabled = false;
                btn_Equipe.Enabled = true;
                // CONFIRME FICHE + OPEN EQUIPE
                Equipe.MdiParent = this;
                Equipe.Dock = DockStyle.Fill;
                Equipe.Show();
            }
            else { MessageBox.Show("Veuillez enregistrer votre fiche avant de continuer", "FICHE NON ENREGISTRER!",MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); }
        }

        private void btn_Equipe_Click(object sender, EventArgs e)
        {
                //ChargementForms(Equipe);
                btn_Equipe.Enabled = false;
                btn_Budget.Enabled = true;
                // CONFIRME EQUIPE + OPEN BUDGET
                Budget.MdiParent = this;
                Budget.Dock = DockStyle.Fill;
                Budget.Show();
        }

        private void btn_Budget_Click(object sender, EventArgs e)
        {

                //ChargementForms(Budget);
                btn_Budget.Enabled = false;
                btn_TachesJalons.Enabled = true;
                // CONFIRME BUDGET + OPEN TACHES
                Taches.MdiParent = this;
                Taches.Dock = DockStyle.Fill;
                Taches.Show();
        }

        private void btn_TachesJalons_Click(object sender, EventArgs e)
        {           
            ChargementForms(Taches);
            btn_TachesJalons.Enabled = false;
            btn_FinCreation.Enabled = true;
            // CONFIRME TACHES + OPEN FIN CREATION
            FinCreation.MdiParent = this;
            FinCreation.Dock = DockStyle.Fill;
            FinCreation.Show();
        }

        private void btn_FinCreation_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();     
        }

        private void btn_RetourAcueille_Click(object sender, EventArgs e)
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
        // FIN CREATION
        private void btn_FinCreation_MouseEnter(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseEnter(btn_FinCreation);
        }
        private void btn_FinCreation_MouseLeave(object sender, EventArgs e)
        {
            Program.ChangeMenuBg_MouseLeave(btn_FinCreation);
        }


        // Minmize & Exit
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
