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
    public partial class EtatProjet : Form
    {
        public EtatProjet()
        {
            InitializeComponent();
        }

        private void EtatProjet_Load(object sender, EventArgs e)
        {

        }
       
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds_Etat = new DataSet();
                // ALL
                SqlDataAdapter da_SommeBudget = new SqlDataAdapter("SELECT   SUM( B.Budget ) FROM BudgetProj B WHERE IDProj = " + Program.IDProj, Program.cnx);
                da_SommeBudget.Fill(ds_Etat, "SommeBudget");
                SqlDataAdapter da_CountBudget = new SqlDataAdapter("SELECT COUNT( B.Budget ) FROM BudgetProj B WHERE IDProj = " + Program.IDProj, Program.cnx);
                da_CountBudget.Fill(ds_Etat, "CountBudget");
                SqlDataAdapter da_CibleBudget = new SqlDataAdapter("SELECT F.CibleProjet FROM FicheProj F WHERE IDProj = " + Program.IDProj, Program.cnx);
                da_CibleBudget.Fill(ds_Etat, "CibleBudget");
                SqlDataAdapter da_CountEquipe = new SqlDataAdapter("SELECT COUNT( E.IDMembreEquipe ) FROM EquipeProj E WHERE IDProj = " + Program.IDProj, Program.cnx);
                da_CountEquipe.Fill(ds_Etat, "CountEquipe");
                SqlDataAdapter da_CountTaches = new SqlDataAdapter("SELECT COUNT( T.IDTache ) FROM TachesProj T WHERE IDProj = " + Program.IDProj, Program.cnx);
                da_CountTaches.Fill(ds_Etat, "CountTaches");
                string SommeBudget = ds_Etat.Tables["SommeBudget"].Rows[0][0].ToString();
                string CountBudget = ds_Etat.Tables["CountBudget"].Rows[0][0].ToString();
                string CibleBudget = ds_Etat.Tables["CibleBudget"].Rows[0][0].ToString();
                string CountEquipe = ds_Etat.Tables["CountEquipe"].Rows[0][0].ToString();
                string BudgetRestant = Convert.ToString(Convert.ToDecimal(CibleBudget) - Convert.ToDecimal(SommeBudget));
                txt_SommeBudget.Text = SommeBudget;
                txt_CibleBudget.Text = CibleBudget;
                txt_CountEquipe.Text = CountEquipe;
                txt_BudgetRestant.Text = BudgetRestant;
                // TASKS
                SqlDataAdapter da_NouvelleTache = new SqlDataAdapter("SELECT COUNT( T.IDTache ) FROM TachesProj T WHERE T.StatutTache = 'Nouvelle tache' AND IDProj = " + Program.IDProj, Program.cnx);
                da_NouvelleTache.Fill(ds_Etat, "NouvelleTache");
                SqlDataAdapter da_EnCours = new SqlDataAdapter("SELECT COUNT( T.IDTache ) FROM TachesProj T WHERE T.StatutTache = 'En cours' AND  IDProj = " + Program.IDProj, Program.cnx);
                da_EnCours.Fill(ds_Etat, "EnCours");
                SqlDataAdapter da_EnAttente = new SqlDataAdapter("SELECT COUNT( T.IDTache ) FROM TachesProj T  WHERE T.StatutTache = 'En Attente' AND IDProj = " + Program.IDProj, Program.cnx);
                da_EnAttente.Fill(ds_Etat, "EnAttente");
                SqlDataAdapter da_Terminer = new SqlDataAdapter("SELECT COUNT( T.IDTache ) FROM TachesProj T  WHERE T.StatutTache = 'Terminer' AND  IDProj = " + Program.IDProj, Program.cnx);
                da_Terminer.Fill(ds_Etat, "Terminer");
                string CountTaches = ds_Etat.Tables["CountTaches"].Rows[0][0].ToString();
                string NouvelleTache = ds_Etat.Tables["NouvelleTache"].Rows[0][0].ToString();
                string EnCours = ds_Etat.Tables["EnCours"].Rows[0][0].ToString();
                string EnAttente = ds_Etat.Tables["EnAttente"].Rows[0][0].ToString();
                string Terminer = ds_Etat.Tables["Terminer"].Rows[0][0].ToString();
                txt_CountTaches.Text = "/" + CountTaches;
                txt_Taches_new.Text = NouvelleTache;
                txt_Taches_EnCours.Text = EnCours;
                txt_Taches_EnAttente.Text = EnAttente;
                txt_Taches_Terminer.Text = Terminer;
                // Date
                SqlDataAdapter da_Jours = new SqlDataAdapter("SELECT DATEDIFF(day, F.DateDebutProj ,F.DateFinProj) FROM FicheProj F WHERE IDProj = " + Program.IDProj, Program.cnx);
                SqlDataAdapter da_JoursRestans = new SqlDataAdapter("SELECT DATEDIFF(day,GETDATE() ,F.DateFinProj) FROM FicheProj F WHERE IDProj = " + Program.IDProj, Program.cnx);
                SqlDataAdapter da_DateDebut = new SqlDataAdapter("SELECT F.DateDebutProj FROM FicheProj F WHERE IDProj = " + Program.IDProj, Program.cnx);
                SqlDataAdapter da_DateFin = new SqlDataAdapter("SELECT F.DateFinProj FROM FicheProj F WHERE  IDProj = " + Program.IDProj, Program.cnx);
                da_Jours.Fill(ds_Etat, "Jours");
                da_JoursRestans.Fill(ds_Etat, "JoursRestans");
                da_DateDebut.Fill(ds_Etat, "DateDebut");
                da_DateFin.Fill(ds_Etat, "DateFin");
                string Jours = ds_Etat.Tables["Jours"].Rows[0][0].ToString();
                string JoursRestans = ds_Etat.Tables["JoursRestans"].Rows[0][0].ToString();
                string DateDebut = ds_Etat.Tables["DateDebut"].Rows[0][0].ToString();
                string DateFin = ds_Etat.Tables["DateFin"].Rows[0][0].ToString();
                string DateNow = DateTime.Now.ToString();
                txt_JoursRestans.Text = JoursRestans;
                txt_DateDebut.Text = DateDebut;
                txt_DateFin.Text = DateFin;
                txt_DatePrevu.Text = Jours;
                // Statut
                SqlDataAdapter da_Statut = new SqlDataAdapter("SELECT F.StatutProj FROM FicheProj F WHERE  IDProj = " + Program.IDProj, Program.cnx);
                da_Statut.Fill(ds_Etat, "Statut"); 
                string Statut = ds_Etat.Tables["Statut"].Rows[0][0].ToString();
                txt_EtatProjet.Text = Statut;

                
                // ALERTS 
                        // 1.Budget
                            try
                            {
                                decimal moyenneBudgetaire = Convert.ToDecimal(CibleBudget) / 2;

                                if (Convert.ToDecimal(SommeBudget) <= moyenneBudgetaire) 
                                {  Alert_Budget.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));  }// ALERT OK
                                else if (Convert.ToDecimal(SommeBudget) > moyenneBudgetaire && Convert.ToDecimal(SommeBudget) < Convert.ToDecimal(CibleBudget)) 
                                {  Alert_Budget.BackColor = Color.Orange;} // ALERT MOYENNE 
                                else if (Convert.ToDecimal(SommeBudget) > Convert.ToDecimal(CibleBudget))
                                {  Alert_Budget.BackColor = Color.Crimson; }// ALERT DANGER 
                                else { Alert_Budget.BackColor = Color.Silver; }
                            }
                            catch { };
                        // 2. Date
                            try
                            {
                                int moyenneJours = Convert.ToInt16(Jours)/2;                           
                                if (Convert.ToInt16(JoursRestans) >= moyenneJours) 
                                { Alert_Date.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));} // ALERT OK 
                                else if (Convert.ToInt16(JoursRestans) < moyenneJours && Convert.ToInt16(JoursRestans) > 1 )
                                {  Alert_Date.BackColor = Color.Orange;} // ALERT MOYENNE 
                                else if ( Convert.ToInt16(JoursRestans) <= 1)
                                { Alert_Date.BackColor = Color.Crimson; }// ALERT DANGER 
                                else { Alert_Date.BackColor = Color.Silver; }
                            }
                            catch { };
                    // 3.Statut 
                            if (Statut == "Intension")
                            { Alert_Etat.BackColor = Color.Crimson; } 
                            else if (Statut == "En cours")
                            { Alert_Etat.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));  } // ALERT NOW
                            else if (Statut == "Terminer")
                            { Alert_Etat.BackColor = Color.SeaGreen; } // ALERT DANGER
                            else if (Statut == "Archiver")
                            { Alert_Etat.BackColor = Color.DimGray; } // ALERT ARCHIVER
                            else { Alert_Etat.BackColor = Color.Silver; }

                    //4.Taches
                          int moyenneTache = Convert.ToInt16( CountTaches ) / 2;
                          int QuartTache = moyenneTache + moyenneTache / 2;
                          if (Convert.ToInt16(Terminer) >= 0 && Convert.ToInt16(Terminer) < moyenneTache)
                          { Alert_Taches.BackColor = Color.Crimson; }// ALERT DANGER 
                          else if (Convert.ToInt16(Terminer) >= moyenneTache && Convert.ToInt16(Terminer) < QuartTache)
                          { Alert_Taches.BackColor = Color.Orange; } // ALERT MOYENNE 
                          else if (Convert.ToInt16(Terminer) >= QuartTache && Convert.ToInt16(Terminer) <= Convert.ToInt16(CountTaches))
                          { Alert_Taches.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); }// ALERT OK }
                          else { Alert_Taches.BackColor = Color.Silver; }
                //5.Equipe
                if( Convert.ToInt16(CountEquipe) == 0)
                { Alert_Members.BackColor = Color.Crimson; }
                else 
                {Alert_Members.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));}
                

            }
            catch { MessageBox.Show("Manque de données pour charger l'etat du projet.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1); }

        }

        
    }
}
