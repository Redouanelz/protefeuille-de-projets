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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds_Profile = new DataSet();
                SqlDataAdapter da_EmailPerso = new SqlDataAdapter("SELECT P.EmailPerso FROM Personnel P WHERE  P.IDPerso =" + Program.IDPerso, Program.cnx);
                da_EmailPerso.Fill(ds_Profile, "EmailPerso");
                lbl_Email.Text = ds_Profile.Tables["EmailPerso"].Rows[0][0].ToString();

                SqlDataAdapter da_NbTaches = new SqlDataAdapter("SELECT COUNT(T.IDTache) FROM Personnel P, EquipeProj E, TachesProj T WHERE P.IDPerso = E.IDPerso and E.IDMembreEquipe = T.TacheAttribueA AND P.IDPerso = " + Program.IDPerso, Program.cnx);
                da_NbTaches.Fill(ds_Profile, "NbTaches");
                lbl_nbrNvTaches.Text = "0"+ds_Profile.Tables["NbTaches"].Rows[0][0].ToString();
            }
            catch { }
        }

        private void btn_Accueille_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueille.Acceuille Accueille = new Accueille.Acceuille();
            Accueille.Show();
        }
        // OPEN TACHES
        private void btn_Taches_Click(object sender, EventArgs e)
        {
            MesTaches MesTaches = new MesTaches();
            MesTaches.Show();
        }


        // MESSAGERIE
        //private void btn_Messagerie_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_Messagerie.Text = "CONSULTEZ";
        //    btn_Messagerie.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))); // 64,0,46
        //    btn_Messagerie.BringToFront();
        //}

        //private void btn_Messagerie_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_Messagerie.Text = "";
        //    btn_Messagerie.BackColor = Color.Transparent;
        //    btn_Messagerie.SendToBack();
        //}
        // TACHES
        //private void btn_Taches_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_Taches.Text = "AFFICHEZ";
        //    btn_Taches.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); // 0,192,192
        //    btn_Taches.BringToFront();
        //}

        //private void btn_Taches_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_Taches.Text = "";
        //    btn_Taches.BackColor = Color.Transparent;
        //    btn_Taches.SendToBack();
        //}
        // UPDATE INFOS
        //private void btn_UpdateInfos_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_UpdateInfos.Text = "MODIFIER";
        //    btn_UpdateInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); // 0,192,192
        //    btn_UpdateInfos.BringToFront();
        //}

        //private void btn_UpdateInfos_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_UpdateInfos.Text = "";
        //    btn_UpdateInfos.BackColor = Color.Transparent;
        //    btn_UpdateInfos.SendToBack();
        //}

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime DateNow = DateTime.Now;
            lbl_Heur.Text = DateNow.ToString("HH:mm");
            lbl_Date.Text = DateNow.ToString("MM/dd/yyyy");
        }


        private void btn_UpdateInfos_Click(object sender, EventArgs e)
        {
            MesInfos MesInfos = new MesInfos();
            MesInfos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Messagerie_Click(object sender, EventArgs e)
        {
            MaMessagerie MaMessagerie = new MaMessagerie();
            MaMessagerie.Show();
        }

        private void pnl_Messagerie_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
        }




    }
}
