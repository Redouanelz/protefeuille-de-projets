using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using RlzProj.Profile;

namespace RlzProj.Accueille
{
    public partial class Acceuille : Form
    {

        public Acceuille()
        {
            InitializeComponent();
        }

        // CREATION DE PROJET -- CP
            private void btn_CP_Titre_MouseEnter(object sender, EventArgs e)
            {
                btn_CP_Titre.Text = "Crée une nouvelle fiche de projet\nformer l'équipe de travaille,\ngérer le budgets\nest partager les taches\npour une meilleur gestion.";
                btn_CP_Titre.TextAlign = ContentAlignment.MiddleCenter;
                lbl_CP_Titre.Text = "";
                btn_CP_Titre.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); 
            }
            private void btn_CP_Titre_MouseLeave(object sender, EventArgs e)
            {
                btn_CP_Titre.Text = "";
                lbl_CP_Titre.Text = "CREATION DE PROJET";
                btn_CP_Titre.BackColor = Color.Transparent; 
            }
        // TABLEAU DE BORD -- DASH BOARD -- DB
            private void btn_DB_Titre_MouseEnter(object sender, EventArgs e)
            {
                btn_DB_Titre.Text = "Suivre, consulter est mettre à jours\ntous vos projets facilement \ndepuis le tableau de bord.";
                btn_DB_Titre.TextAlign = ContentAlignment.MiddleCenter;
                lbl_DB_Titre.Text = "";
                btn_DB_Titre.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); 
            }
            private void btn_DB_Titre_MouseLeave(object sender, EventArgs e)
            {
                btn_DB_Titre.Text = "";
                lbl_DB_Titre.Text = "TABLEAU DE BORD";
                btn_DB_Titre.BackColor = Color.Transparent; 
            }
        // MON PROFILE -- MP
            private void btn_MP_Titre_MouseEnter(object sender, EventArgs e)
            {
                btn_MP_Titre.Text = "Consulter votre profile,\nVérifier votre messagerie,\nest mettre à jours vos informations.";
                btn_MP_Titre.TextAlign = ContentAlignment.MiddleCenter;
                lbl_MP_Titre.Text = "";
                btn_MP_Titre.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); 
            }
            private void btn_MP_Titre_MouseLeave(object sender, EventArgs e)
            {

                btn_MP_Titre.Text = "";
                lbl_MP_Titre.Text = "MON PROFILE";
                btn_MP_Titre.BackColor = Color.Transparent;
            }       

        // LOAD
        private void Acceuille_Load(object sender, EventArgs e)
        {
            lbl_CP_Text.Text = "";
            lbl_MP_Text.Text = "";
            lbl_DB_Text.Text = "";
            if (Program.ProfilePerso == "ADMINISTRATEUR")
            {
                btn_CP_Titre.Enabled = true;
                btn_DB_Titre.Enabled = true;
                btn_MP_Titre.Enabled = true; 

            }
            if (Program.ProfilePerso == "PERSONNELLE")
            {
                btn_CP_Titre.Visible = false;
                btn_DB_Titre.Visible = false;
                btn_MP_Titre.Enabled = true; // Turn to false;
            }
            try // IMPORT ALL INFOS ABOUT IDPerso
            {               
                Program.dt_Personnel.Clear();
                Program.da_Personnel = new SqlDataAdapter("SELECT ImagePerso FROM Personnel WHERE IDPerso =" + Program.IDPerso, Program.cnx);
                Program.da_Personnel.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.da_Personnel.Fill(Program.ds_RlzProj, "Personnel");
                Program.dt_Personnel = Program.ds_RlzProj.Tables["Personnel"];
            }
            catch { }

            try // SET INFOS TO INPUT
            {
                lbl_NomAuth.Text = Program.NomPerso;
                if (Program.dt_Personnel.Rows[0]["ImagePerso"] != null)
                {  // RETRIVING PICTURE FROM DB 
                    byte[] imageBt = (Byte[])(Program.dt_Personnel.Rows[0]["ImagePerso"]);
                    MemoryStream ms = new MemoryStream(imageBt);
                    pictureBox.Image = Image.FromStream(ms);
                    ms.Close();
                }
            }
            catch {}            
        }
        // WORK CLICK
        private void btn_CP_Titre_Click(object sender, EventArgs e)
        {            
            CreationProjet CreationNouveauxProjet = new CreationProjet();           
            CreationNouveauxProjet.Show();
            this.Hide();
        }
        private void btn_DB_Titre_Click(object sender, EventArgs e)
        {
            Tableau_de_bord.TableauBord TableauBord = new Tableau_de_bord.TableauBord();
            TableauBord.Show();
            this.Hide();
        }
        private void btn_MP_Titre_Click(object sender, EventArgs e)
        {
            GestionCompte GestionCompte = new GestionCompte();
            GestionCompte.Show();
            this.Hide();
            //Profile.MyProfile Profile = new Profile.MyProfile();
            //Profile.Show();
            //this.Hide();
        }
        // MMINIMIZED & EXIT
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // UPDOWN EFFECT
        bool updown = false;
        private void btn_UpDown_Click(object sender, EventArgs e)
        {
            if (updown == false)
            {
                pnl_Header_Menu.Dock = DockStyle.Fill;
                btn_UpDown.Image = Properties.Resources.up;
                updown = true;
            }
            else if (updown == true)
            {
                pnl_Header_Menu.Dock = DockStyle.None;
                btn_UpDown.Image = Properties.Resources.Down;
                updown = false;
            }
        }
        // DECONNECTION
        private void btn_Deconnection_Click(object sender, EventArgs e)
        {            
            Program.IDPerso = -1;
            Program.ProfilePerso = null;
            Program.NomPerso = null;
            Authentification New_Authentification_Session = new Authentification();
            New_Authentification_Session.Show();
            this.Close();
        }


    }
}
