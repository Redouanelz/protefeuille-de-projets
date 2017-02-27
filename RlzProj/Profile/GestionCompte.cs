using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RlzProj.Profile
{
    public partial class GestionCompte : Form
    {

        // FORMS_INITIALIZE
        private MyProfile Profile;
        private MesTaches Taches;
        private MaMessagerie Messagerie;
        private MesInfos Infos;

        public GestionCompte()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        // FONCTION CHARGEMENTS DE FORMS DEPUIS LE MENU 
        public void ChargementForms(Form FormName)
        {

            var SaveFirstActiveForm = ActiveMdiChild;
            // TEST
            if (SaveFirstActiveForm == FormName)
            { /* Rien. */ }
            else if (SaveFirstActiveForm != Profile.ActiveMdiChild)
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
        
        private void GestionCompte_Load(object sender, EventArgs e)
        {
            // FORMS_INSTANCE
            Profile = new MyProfile();   
            Taches = new MesTaches();
            Messagerie = new MaMessagerie();
            Infos = new MesInfos();
            // LOAD_MyProfile
            Profile.MdiParent = this;
            Profile.Dock = DockStyle.Fill;
            Profile.Show();
         
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ChargementForms(Profile);
        }

        private void btn_Taches_Click(object sender, EventArgs e)
        {
            ChargementForms(Taches);
        }

        private void btn_Messagerie_Click(object sender, EventArgs e)
        {
            ChargementForms(Messagerie);
        }

        private void btn_Infos_Click(object sender, EventArgs e)
        {
            ChargementForms(Infos);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_RetourAcueille_Click(object sender, EventArgs e)
        {
            this.Close();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();
        }



        private void btn_RetourAcueille_MouseLeave(object sender, EventArgs e)
        {
            btn_RetourAcueille.Image = Properties.Resources.Accueille;
            btn_RetourAcueille.ImageAlign = ContentAlignment.MiddleCenter;
            btn_RetourAcueille.BackColor = Color.White;
        }

        private void btn_RetourAcueille_MouseEnter(object sender, EventArgs e)
        {
            btn_RetourAcueille.Image = Properties.Resources.accueil_icone_6603_32;
            btn_RetourAcueille.ImageAlign = ContentAlignment.MiddleCenter;
            btn_RetourAcueille.BackColor = Color.White;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btn_RetourAcueille, "[Espace d'Accueille]");
        }



        // EFFECTS
        private void btn_Profile_MouseEnter(object sender, EventArgs e)
        {
            btn_Profile.Image = Properties.Resources.Menux;
            btn_Profile.BackColor = Color.Crimson;
        }
        private void btn_Profile_MouseLeave(object sender, EventArgs e)
        {
            btn_Profile.Image = Properties.Resources.appbar_align1;
            btn_Profile.BackColor = Color.White;

        }

        private void btn_Taches_MouseEnter(object sender, EventArgs e)
        {
            btn_Taches.Image = Properties.Resources.tasksx;
            btn_Taches.BackColor = Color.Crimson;
        }
        private void btn_Taches_MouseLeave(object sender, EventArgs e)
        {
            btn_Taches.Image = Properties.Resources.appbar_notification1;
            btn_Taches.BackColor = Color.White;
        }

        private void btn_Messagerie_MouseEnter(object sender, EventArgs e)
        {
            btn_Messagerie.Image = Properties.Resources.mailx;
            btn_Messagerie.BackColor = Color.Crimson;
        }
        private void btn_Messagerie_MouseLeave(object sender, EventArgs e)
        {
            btn_Messagerie.Image = Properties.Resources.appbar_email1;
            btn_Messagerie.BackColor = Color.White;
        }

        private void btn_Infos_MouseEnter(object sender, EventArgs e)
        {
            btn_Infos.Image = Properties.Resources.infosx;
            btn_Infos.BackColor = Color.Crimson;
        }
        private void btn_Infos_MouseLeave(object sender, EventArgs e)
        {
            btn_Infos.Image = Properties.Resources.appbar_page3;
            btn_Infos.BackColor = Color.White;
        }
    }
}
