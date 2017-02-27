using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// IMPORTED NAMESPACES
using System.Data;
using System.Data.SqlClient;
using RlzProj.Tableau_de_bord;
using System.Drawing;
using RlzProj.Profile;
using System.Net.Mail;
using System.Configuration;
using System.IO;

namespace RlzProj
{
    static class Program
    {
        public static string cnx_string = Properties.Settings.Default.Rlzcnx;
        // public static string cnx_string = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+ "\\StartConfig\\RlzProject.mdf;Integrated Security=True;User Instance=True";
        // public static string cnx_string = @"Data Source=RLZ-PC\RLZ;Initial Catalog=RlzProject;Persist Security Info=True;User ID=Login_Admin;Password=Login_Admin";

        public static SqlConnection cnx = new SqlConnection(@cnx_string);
        // DataSet
        public static DataSet ds_RlzProj = new DataSet();
        // DataAdapters
        public static SqlDataAdapter da_Personnel;
        public static SqlDataAdapter da_FicheProj;
        public static SqlDataAdapter da_EquipeProj;
        public static SqlDataAdapter da_BudgetsProj;
        public static SqlDataAdapter da_TachesProj;
            //Profile
             public static SqlDataAdapter da_MesTaches;

        // DataTables
        public static DataTable dt_Personnel = new DataTable();
        public static DataTable dt_FicheProj = new DataTable();
        public static DataTable dt_EquipeProj = new DataTable();
        public static DataTable dt_BudgetsProj = new DataTable();
        public static DataTable dt_TachesProj = new DataTable();
            //Profile
             public static DataTable dt_MesTaches = new DataTable();
        // DataViews
        public static DataView dv_FicheProj = new DataView();
           public static DataView dv_MesTaches = new DataView();
        // Global 
        public static int IDPerso; public static string NomPerso; public static string ProfilePerso;
        public static int IDProj;
        public static bool FicheProjOk = false;
        // EMAIL
        public static string TheMail = "Bienvenue sur notre plateforme \nRlz Organisation.";
        public static string MailSubject = "Notification d'Inscription.";
        public static string SenderMail = "Redouane.Louzi@gmail.com";
        public static string SenderPassword = "**";
        public static string SmtpServer = "smtp.gmail.com";
        public static int ClientPort = 587;
        // Functions

        public static void ChangeMenuBg_MouseEnter(Control Button)
        {
            // 0; 142; 119
            Button.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Button.ForeColor = Color.White;
        }
        public static void ChangeMenuBg_MouseLeave(Control Button)
        {
            // 0; 142; 119
            Button.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Button.BackColor = Color.White;
        }

        public static bool Fonction_SendMail(string Mailto)
        {
            bool SendResult = false;
            try
            {
                MailMessage mail = new MailMessage(Program.SenderMail, Mailto, Program.MailSubject, Program.TheMail);
                // SEND.
                SmtpClient client = new SmtpClient(Program.SmtpServer);
                client.Port = Program.ClientPort;
                client.Credentials = new System.Net.NetworkCredential(Program.SenderMail, Program.SenderPassword);
                client.EnableSsl = true;
                client.Send(mail);
                SendResult = true;
            }
            catch { SendResult = false; }

            return SendResult;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new _Config.Start());
        }
    }
}