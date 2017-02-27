using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RlzProj._Config
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            try {
                Program.cnx.Open();                   
                    lbl_DBState.ForeColor = Color.Teal; lbl_DBState.Text = "Tentative de connexion réussie\nBase de donnée : Connect."; 
                Program.cnx.Close(); } catch  { lbl_DBState.ForeColor = Color.Crimson; btnContinuer.ForeColor = Color.Crimson; pnl_State.BackColor = Color.Crimson;  lbl_DBState.Text = "Tentative de connexion échoué\nBase de donnée : Déonnecté."; }
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            this.Hide(); Authentification New_Authentification_Session = new Authentification(); New_Authentification_Session.Show(); 
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfigurer_Click(object sender, EventArgs e)
        {
            ConfigurationConnexion ConfigurationConnexion = new ConfigurationConnexion();
            ConfigurationConnexion.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lbl_DBState.Text = "";
            try
            {
                Program.cnx.Open();
                lbl_DBState.ForeColor = Color.Teal; lbl_DBState.Text = "Tentative de connexion réussie\nBase de donnée : Connect.";
                Program.cnx.Close();
            }
            catch { lbl_DBState.ForeColor = Color.Crimson; btnContinuer.ForeColor = Color.Crimson; pnl_State.BackColor = Color.Crimson; lbl_DBState.Text = "Tentative de connexion échoué\nBase de donnée : Déonnecté."; }
    
        }


    }
}
