using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace RlzProj.Profile
{
    public partial class MaMessagerie : Form
    {
        public MaMessagerie()
        {
            InitializeComponent();
        }

        // FONCTION : GET PERSONNNELS EMAIL LISTE.
        public void GetEmailListe()
        {
            try
            {
                Program.cnx.Open();
                SqlCommand command = new SqlCommand("SELECT P.EmailPerso FROM Personnel P", Program.cnx);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmb_PersonnelEmailListe.Items.Add(reader["EmailPerso"].ToString());
                }
                reader.Close();
                Program.cnx.Close();                
            }
            catch { }
        }
        // MINIMIZE /  CLOSE
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // SEND
        private void Send_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                if(to_list.Items.Count !=0) // TEST LIST MEMBERS
                {
                    MessageBox.Show("Veuillez attendre le temps d'envois, Priére de ne pas fermer l'application.", "Merci de patienter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    for (i = 0; i < to_list.Items.Count; i++)
                    {
                        MailMessage mail = new MailMessage(Properties.Settings.Default.SenederEmail, to_list.Items[i].ToString(), Subject.Text, Body.Text);
                        // CONDITION: 3. Vérifier s'il y'a un Attachement ou pas.
                        if (String.IsNullOrEmpty(txtAtachement.Text)) { } else { mail.Attachments.Add(new Attachment(txtAtachement.Text.ToString())); }
                        // SEND.
                        SmtpClient client = new SmtpClient(Program.SmtpServer);
                        mail.IsBodyHtml = true;
                        client.Port = Program.ClientPort;
                        client.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.SenederEmail, Properties.Settings.Default.SenderEmailPassword);
                        client.EnableSsl = true;
                        client.Send(mail);
                        MessageBox.Show("[ " + i + " ] Mail(s) envoyé avec succées.", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                        lblNotif.Text = "[ " + i + " ] Mail(s) envoyé avec succées.";
                    }
                }

            }
            catch (Exception ex)
            {
                lblNotif.BackColor = Color.Crimson;
                lblNotif.Text = "Echéque de l'envoi, vérifier votre connexion internet, ainsi que la validité de vos informations."; MessageBox.Show("Erreur d'envoi! voir l'exception\n\n" + ex);
            }

        }
        // GET ATTACHEMENT
        private void btnAttach_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog openfile = new OpenFileDialog();
                if (openfile.ShowDialog() == DialogResult.OK)
                { string picpath = openfile.FileName.ToString(); txtAtachement.Text = picpath; }
                lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                lblNotif.Text = "Piéce jointe attaché.";
            } catch { }
        }
        // LOAD
        private void MaMessagerie_Load(object sender, EventArgs e)
        {
            GetEmailListe();
        }
        // SELECTED INDEX CMB
        private void cmb_PersonnelEmailListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            to_list.Items.Add(cmb_PersonnelEmailListe.Text);
        }
        // CLEAR LISTE
        private void btn_ClearListe_Click(object sender, EventArgs e)
        {
            to_list.Items.Clear();
            lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            lblNotif.Text = "Liste vidé.";
        }
        // CHECK ON WEB BROWSER
        private void btn_Consulterweb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com");
            lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            lblNotif.Text = "Redirection vers < https://mail.google.com > .";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
