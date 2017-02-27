using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// IMPORT PACKAGE
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.IO;

namespace RlzProj
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();               
        }
        // DECLARATION
        int RequiredValidation = 0;
        int RequiredConnexion = 0;
        string Mailto;

        // HIDE&SHOW
        private void btnHideShow_Click(object sender, EventArgs e)
        {         
                pnl_Header_Connexion.Dock = DockStyle.Fill;
                pnl_Header_Inscription.Dock = DockStyle.None;
                pnl_Connexion_Enable.Enabled = false;
                pnl_Inscription_Enable.Enabled = true;            
        }
        private void btn_Connexion_OK_Click(object sender, EventArgs e)
        {
            pnl_Header_Inscription.Dock = DockStyle.Fill;
            pnl_Header_Connexion.Dock = DockStyle.None;
            pnl_Connexion_Enable.Enabled = true;
            pnl_Inscription_Enable.Enabled = false;
        }

        // LOAD
        private void Authentification_Load(object sender, EventArgs e)
        {
            pnl_Header_Inscription.Dock = DockStyle.Fill;
            Program.dt_Personnel.Clear();
            // IMPORT TABLE FicheProj for save
            Program.da_Personnel = new SqlDataAdapter("SELECT * FROM Personnel", Program.cnx);
            Program.da_Personnel.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_Personnel.Fill(Program.ds_RlzProj, "Personnel");
            Program.dt_Personnel = Program.ds_RlzProj.Tables["Personnel"];        }
        
        // CONNEXION
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            lblNotifCnx.Text = "";           
            Program.dt_Personnel.Clear();
            // IMPORT TABLE FicheProj for save
            Program.da_Personnel = new SqlDataAdapter("SELECT * FROM Personnel", Program.cnx);
            Program.da_Personnel.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_Personnel.Fill(Program.ds_RlzProj, "Personnel");
            Program.dt_Personnel = Program.ds_RlzProj.Tables["Personnel"];

            RequiredConnexion = 0; // MAX 2
            // PSEUDO -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 1 to 40
            if (!Regex.IsMatch(txtConnexion_Pseudo.Text, @"^[a-zA-Z0-9s@.-]{4,40}$") || String.IsNullOrEmpty(txtConnexion_Pseudo.Text))
            {
                Err_Connexion_Pseudo.Icon = Properties.Resources.error; Err_Connexion_Pseudo.SetError(txtConnexion_Pseudo, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ.\nExemple: ( Hello.00-1 ).");
                txtConnexion_Pseudo.ForeColor = Color.Crimson; 
            }
            else {
                Err_Connexion_Pseudo.Icon = Properties.Resources.oky; Err_Connexion_Pseudo.SetError(txtConnexion_Pseudo, "");
                txtConnexion_Pseudo.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; RequiredConnexion++;
            }
            // MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtConnexion_Motdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtConnexion_Motdepasse.Text))
            {
                Err_Connexion_Motdepasse.Icon = Properties.Resources.error; Err_Connexion_Motdepasse.SetError(txtConnexion_Motdepasse, "Champs invalide, le mot de passe doit contenire entre 4 et 10 caractères autorisés, veuillez remplire correctement ce champ.");
                txtConnexion_Motdepasse.ForeColor = Color.Crimson; 
            }
            else {
                Err_Connexion_Motdepasse.Icon = Properties.Resources.oky; Err_Connexion_Motdepasse.SetError(txtConnexion_Motdepasse, "");
                txtConnexion_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; RequiredConnexion++;
            }
            // IF INPUTS OK
            if (RequiredConnexion == 2)
            {
                bool Find = false;
                string CnxPseudoOrMail = txtConnexion_Pseudo.Text;
                Int64 HashedPassword = txtInscription_Motdepasse.Text.GetHashCode();
                Int64 CnxPassword = txtConnexion_Motdepasse.Text.GetHashCode();
                for (int i = 0; i < Program.dt_Personnel.Rows.Count; i++)
                {
                    if (CnxPseudoOrMail == Program.dt_Personnel.Rows[i]["PseudoPerso"].ToString() || CnxPseudoOrMail == Program.dt_Personnel.Rows[i]["EmailPerso"].ToString())
                    {                        
                        if (CnxPassword.ToString() == Program.dt_Personnel.Rows[i]["MotdepassePerso"].ToString())
                        {
                            Program.IDPerso = Convert.ToInt16(Program.dt_Personnel.Rows[i]["IDPerso"].ToString());
                            Program.NomPerso = Program.dt_Personnel.Rows[i]["NomPerso"].ToString() + "  " +Program.dt_Personnel.Rows[i]["PrenomPerso"].ToString() ;
                            if(Program.dt_Personnel.Rows[i]["isAdmin"].ToString() == "false") { Program.ProfilePerso = "PERSONNELLE" ; }
                            else if (Program.dt_Personnel.Rows[i]["isAdmin"].ToString() == "true") { Program.ProfilePerso = "ADMINISTRATEUR" ; }
                            //Notify.Icon = SystemIcons.Application;
                            Notify.InitializeLifetimeService();
                            Notify.Icon = Properties.Resources.oky;
                            Notify.BalloonTipTitle = "Connexion Réusite.";
                            Notify.BalloonTipText = "\nBienvenue, " + Program.NomPerso + "\nvous étes connecter en tant que " + Program.ProfilePerso + " - [" + Program.IDPerso + "].";
                            Notify.ShowBalloonTip(1000);
                            Find = true;
                            break;
                        }
                    }
                }             
                if (Find == true)
                {
                    this.Hide();               
                    Accueille.Acceuille AllezAccueille = new Accueille.Acceuille();
                    AllezAccueille.Show();
                }
                else { lblNotifCnx.BringToFront();  lblNotifCnx.BackColor = Color.Crimson; lblNotifCnx.Text = "Connexion non réusite,\nIdentifiant ou mot de passe incorrecte."; }
            }
        }
        
        // INSCRIPTION //
        private void btnInscription_Click(object sender, EventArgs e)
        {
            lblNotif.Text = "";           
            int ok = InscriptionNewAccount(RequiredValidation); // FUNCTION RETURN
            if (ok == 6) // RequiredValidation COUNT : 6
            {    
                try
                {
                    using (SqlConnection cnx = new SqlConnection(Program.cnx_string))
                    {
                        // DECLARE Binary image 
                        byte[] imageBt = null;
                        if (string.IsNullOrEmpty(txt_PicPath.Text)) { }
                        else
                        {  
                            FileStream fstream = new FileStream(this.txt_PicPath.Text, FileMode.Open, FileAccess.Read);
                            BinaryReader br = new BinaryReader(fstream);
                            imageBt = br.ReadBytes((int)fstream.Length);
                        }
                        // HASH CODE                                     
                        Int64 HashedPassword = txtInscription_Motdepasse.Text.GetHashCode();                      
                        // PARAMETRED INPUTS
                        DataSet ds_Authentification = new DataSet();
                        Program.cnx.Open();

                        Program.da_Personnel = new SqlDataAdapter("INSERT INTO  Personnel (NomPerso,PrenomPerso,PseudoPerso,EmailPerso,MotdepassePerso,DateNaissancePerso,CivilitePerso,ImagePerso) VALUES (@NomPerso,@PrenomPerso,@PseudoPerso,@EmailPerso,@MotdepassePerso,@DateNaissancePerso,@CivilitePerso,@ImagePerso) ", Program.cnx);
                        SqlParameter PNomPerso = Program.da_Personnel.SelectCommand.Parameters.Add("@NomPerso", SqlDbType.VarChar, 50); PNomPerso.Value = txtInscription_Nom.Text;
                        SqlParameter PPrenomPerso = Program.da_Personnel.SelectCommand.Parameters.Add("@PrenomPerso", SqlDbType.VarChar, 50); PPrenomPerso.Value = txtInscription_Prenom.Text;
                        SqlParameter PPseudoPerso = Program.da_Personnel.SelectCommand.Parameters.Add("@PseudoPerso", SqlDbType.VarChar, 50); PPseudoPerso.Value = txtInscription_Pseudo.Text;
                        SqlParameter PEmailPerso = Program.da_Personnel.SelectCommand.Parameters.Add("@EmailPerso", SqlDbType.VarChar, 50); PEmailPerso.Value = txtInscription_AdresseEmail.Text;
                        SqlParameter PMotdepassePerso = Program.da_Personnel.SelectCommand.Parameters.Add("@MotdepassePerso", SqlDbType.VarChar, 50); PMotdepassePerso.Value = HashedPassword.ToString();
                        SqlParameter PDateNaissancePerso = Program.da_Personnel.SelectCommand.Parameters.Add("@DateNaissancePerso", SqlDbType.Date); PDateNaissancePerso.Value = txtDatedeNaissance.Text;
                        SqlParameter PCivilitePerso = Program.da_Personnel.SelectCommand.Parameters.Add("@CivilitePerso", SqlDbType.VarChar, 30);
                        if (txtInscription_Homme.Checked == true) { PCivilitePerso.Value = "Homme"; } else if (txtInscription_Femme.Checked == true) { PCivilitePerso.Value = "Femme"; }
                        SqlParameter PImagePerso = Program.da_Personnel.SelectCommand.Parameters.Add("@ImagePerso", SqlDbType.Image); PImagePerso.Value = imageBt;
                        Program.da_Personnel.Fill(ds_Authentification, "Personnel");
                        lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); lblNotif.Text = "Création de compte avec sucées.";
                        Mailto = txtInscription_AdresseEmail.Text;
                        // CLEAR INPUTS
                        txtInscription_Nom.Text = ""; txtInscription_Prenom.Text = ""; txtInscription_AdresseEmail.Text = ""; txtInscription_Motdepasse.Text = "";
                        txtInscription_ConfirmationMotdepasse.Text = ""; txtDatedeNaissance.Value = DateTime.Now; txtInscription_Homme.Checked = false; txtInscription_Femme.Checked = false;
                        // SEND MAIL 
                        //Fonction_SendMail(Mailto);
                        //if (Fonction_SendMail(Mailto) == true)
                        //{      lblNotifMail.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); lblNotifMail.Text = "Envoi avec succés."; }
                        //else { lblNotifMail.BackColor = Color.Crimson; lblNotifMail.Text = "la notification par adresse email n'a pas pu étre envoyé, veuillez vérifier vos informations dans la section Profile."; }
                        Program.cnx.Close();
                    }
                }
                catch { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Création de compte impossible, vérifier la validité de vos informations."; }
                Program.cnx.Close();
            }
            else { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Création de compte impossible, vérifier la validité de vos informations."; }
        }
               
        // REGEX LAB //
        public int InscriptionNewAccount(int RequiredValidation)
        {
            // RequiredValidation COUNT : 6
            RequiredValidation = 0;
            // NOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Nom.Text, @"^[a-zA-Zs]{4,40}$") || String.IsNullOrEmpty(txtInscription_Nom.Text))
            { Err_Inscription_Nom.Icon = Properties.Resources.error; Err_Inscription_Nom.SetError(txtInscription_Nom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtInscription_Nom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Nom.Icon = Properties.Resources.oky; Err_Inscription_Nom.SetError(txtInscription_Nom, ""); RequiredValidation++; txtInscription_Nom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // PRENOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Prenom.Text, @"^[a-zA-Zs]{4,40}$") || String.IsNullOrEmpty(txtInscription_Prenom.Text))
            { Err_Inscription_Prenom.Icon = Properties.Resources.error; Err_Inscription_Prenom.SetError(txtInscription_Prenom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtInscription_Prenom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Prenom.Icon = Properties.Resources.oky; Err_Inscription_Prenom.SetError(txtInscription_Prenom, ""); RequiredValidation++; txtInscription_Prenom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // EMAIL ADRESSE -- @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
            if (!Regex.IsMatch(txtInscription_AdresseEmail.Text, @"^[a-zA-Zs.-_]+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$") || String.IsNullOrEmpty(txtInscription_AdresseEmail.Text))
            { Err_Inscription_AdresseEmail.Icon = Properties.Resources.error; Err_Inscription_AdresseEmail.SetError(txtInscription_AdresseEmail, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ,\nExemple: ( Hello.001-@Exemple.com )."); txtInscription_AdresseEmail.ForeColor = Color.Crimson; }
            else { Err_Inscription_AdresseEmail.Icon = Properties.Resources.oky; Err_Inscription_AdresseEmail.SetError(txtInscription_AdresseEmail, ""); RequiredValidation++; txtInscription_AdresseEmail.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // PSEUDO -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Pseudo.Text, @"^[a-zA-Z0-9s.-]{4,40}$") || String.IsNullOrEmpty(txtInscription_Pseudo.Text))
            { Err_Inscription_Pseudo.Icon = Properties.Resources.error; Err_Inscription_Pseudo.SetError(txtInscription_Pseudo, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ.\nExemple: ( Hello.00-1 )."); txtInscription_Pseudo.ForeColor = Color.Crimson; }
            else { Err_Inscription_Pseudo.Icon = Properties.Resources.oky; Err_Inscription_Pseudo.SetError(txtInscription_Pseudo, ""); RequiredValidation++; txtInscription_Pseudo.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtInscription_Motdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtInscription_Motdepasse.Text))
            { Err_Inscription_Motdepasse.Icon = Properties.Resources.error; Err_Inscription_Motdepasse.SetError(txtInscription_Motdepasse, "Champs invalide, le mot de passe doit contenire entre 4 et 10 caractères autorisés, veuillez remplire correctement ce champ."); txtInscription_Motdepasse.ForeColor = Color.Crimson; }
            else {
                Err_Inscription_Motdepasse.Icon = Properties.Resources.oky; Err_Inscription_Motdepasse.SetError(txtInscription_Motdepasse, ""); RequiredValidation++; txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;

                // TESET IF PASSWORD ARE THE SAME.
                if (txtInscription_Motdepasse.Text == txtInscription_ConfirmationMotdepasse.Text)
                {
                    txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_Motdepasse, "");
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_ConfirmationMotdepasse, "");
                }
                else
                {
                    txtInscription_Motdepasse.ForeColor = Color.Crimson; txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson;
                }
            }
            // CONFIRMATION MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtInscription_ConfirmationMotdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtInscription_ConfirmationMotdepasse.Text))
            { Err_Inscription_ConfirmationMotdepasse.Icon = Properties.Resources.error; Err_Inscription_ConfirmationMotdepasse.SetError(txtInscription_ConfirmationMotdepasse, "Champs invalide , le mot de passe doit contenire entre 4 et 10 caractères autorisés, caractères non autorisés veuillez remplire correctement ce champ."); txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson; }
            else {
                Err_Inscription_ConfirmationMotdepasse.Icon = Properties.Resources.oky; Err_Inscription_ConfirmationMotdepasse.SetError(txtInscription_ConfirmationMotdepasse, ""); RequiredValidation++; txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                // TESET IF PASSWORD ARE THE SAME.
                if (txtInscription_Motdepasse.Text == txtInscription_ConfirmationMotdepasse.Text)
                {
                    txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_Motdepasse, "");
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_ConfirmationMotdepasse, "");
                }
                else
                {
                    txtInscription_Motdepasse.ForeColor = Color.Crimson; txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson;
                }
            }
            if (String.IsNullOrEmpty(txtDatedeNaissance.Text))
            { RequiredValidation++; }
            if (txtInscription_Homme.Checked == false && txtInscription_Femme.Checked == false)
            { RequiredValidation++; }
            return RequiredValidation;
        }   // FUNCTION

        private void txtInscription_Nom_Leave(object sender, EventArgs e)
        {
            // NOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Nom.Text, @"^[a-zA-Zs]{4,40}$") || String.IsNullOrEmpty(txtInscription_Nom.Text))
            { Err_Inscription_Nom.Icon = Properties.Resources.error; Err_Inscription_Nom.SetError(txtInscription_Nom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtInscription_Nom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Nom.Icon = Properties.Resources.oky; Err_Inscription_Nom.SetError(txtInscription_Nom, "");    txtInscription_Nom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }
        private void txtInscription_Prenom_Leave(object sender, EventArgs e)
        {
            // PRENOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Prenom.Text, @"^[a-zA-Zs]{4,40}$") || String.IsNullOrEmpty(txtInscription_Prenom.Text))
            { Err_Inscription_Prenom.Icon = Properties.Resources.error; Err_Inscription_Prenom.SetError(txtInscription_Prenom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtInscription_Prenom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Prenom.Icon = Properties.Resources.oky; Err_Inscription_Prenom.SetError(txtInscription_Prenom, ""); txtInscription_Prenom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }
        private void txtInscription_AdresseEmail_Leave(object sender, EventArgs e)
        {
            // EMAIL ADRESSE -- @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
            if (!Regex.IsMatch(txtInscription_AdresseEmail.Text, @"^[a-zA-Zs.-_]+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$") || String.IsNullOrEmpty(txtInscription_AdresseEmail.Text))
            { Err_Inscription_AdresseEmail.Icon = Properties.Resources.error; Err_Inscription_AdresseEmail.SetError(txtInscription_AdresseEmail, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ,\nExemple: ( Hello.001-@Exemple.com )."); txtInscription_AdresseEmail.ForeColor = Color.Crimson; }
            else { Err_Inscription_AdresseEmail.Icon = Properties.Resources.oky; Err_Inscription_AdresseEmail.SetError(txtInscription_AdresseEmail, "");    txtInscription_AdresseEmail.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }
        private void txtInscription_Pseudo_Leave(object sender, EventArgs e)
        {
            // PSEUDO -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 1 to 40
            if (!Regex.IsMatch(txtInscription_Pseudo.Text, @"^[a-zA-Z0-9s.-]{4,40}$") || String.IsNullOrEmpty(txtInscription_Pseudo.Text))
            { Err_Inscription_Pseudo.Icon = Properties.Resources.error; Err_Inscription_Pseudo.SetError(txtInscription_Pseudo, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ.\nExemple: ( Hello.00-1 )."); txtInscription_Pseudo.ForeColor = Color.Crimson; }
            else { Err_Inscription_Pseudo.Icon = Properties.Resources.oky; Err_Inscription_Pseudo.SetError(txtInscription_Pseudo, "");   txtInscription_Pseudo.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }
        private void txtInscription_Motdepasse_Leave(object sender, EventArgs e)
        {
                // MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
                if (!Regex.IsMatch(txtInscription_Motdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtInscription_Motdepasse.Text))
                { Err_Inscription_Motdepasse.Icon = Properties.Resources.error; Err_Inscription_Motdepasse.SetError(txtInscription_Motdepasse, "Champs invalide, le mot de passe doit contenire entre 4 et 10 caractères autorisés, veuillez remplire correctement ce champ."); txtInscription_Motdepasse.ForeColor = Color.Crimson; }
                else {
                Err_Inscription_Motdepasse.Icon = Properties.Resources.oky; Err_Inscription_Motdepasse.SetError(txtInscription_Motdepasse, "");   txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;

                        // TESET IF PASSWORD ARE THE SAME.
                        if (txtInscription_Motdepasse.Text == txtInscription_ConfirmationMotdepasse.Text)
                        {
                            txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                            Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_Motdepasse, "");
                            Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_ConfirmationMotdepasse, "");
                        }
                        else
                        {
                            txtInscription_Motdepasse.ForeColor = Color.Crimson; txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson;                       }
                     }
         }
        private void txtInscription_ConfirmationMotdepasse_Leave(object sender, EventArgs e)
        {
            // CONFIRMATION MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtInscription_ConfirmationMotdepasse.Text, @"^[a-zA-Z0-9s@.-_]{4,10}$") || String.IsNullOrEmpty(txtInscription_ConfirmationMotdepasse.Text))
            { Err_Inscription_ConfirmationMotdepasse.Icon = Properties.Resources.error; Err_Inscription_ConfirmationMotdepasse.SetError(txtInscription_ConfirmationMotdepasse, "Champs invalide , le mot de passe doit contenire entre 4 et 10 caractères autorisés, caractères non autorisés veuillez remplire correctement ce champ."); txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson; }
            else {
                Err_Inscription_ConfirmationMotdepasse.Icon = Properties.Resources.oky; Err_Inscription_ConfirmationMotdepasse.SetError(txtInscription_ConfirmationMotdepasse, "");   txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                // TESET IF PASSWORD ARE THE SAME.
                if (txtInscription_Motdepasse.Text == txtInscription_ConfirmationMotdepasse.Text)
                {
                    txtInscription_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; txtInscription_ConfirmationMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_Motdepasse, "");
                    Err_InscriptionMdpValidation.Icon = Properties.Resources.error; Err_InscriptionMdpValidation.SetError(txtInscription_ConfirmationMotdepasse, "");
                }
                else
                {
                    txtInscription_Motdepasse.ForeColor = Color.Crimson; txtInscription_ConfirmationMotdepasse.ForeColor = Color.Crimson;
                }
            }
        }
        // REGEX LAB //
        private void txtConnexion_Pseudo_Leave(object sender, EventArgs e)
        {           
            // PSEUDO -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 1 to 40
            if (!Regex.IsMatch(txtConnexion_Pseudo.Text, @"^[a-zA-Z0-9s@.-]{4,40}$") || String.IsNullOrEmpty(txtConnexion_Pseudo.Text))
            {
                Err_Connexion_Pseudo.Icon = Properties.Resources.error; Err_Connexion_Pseudo.SetError(txtConnexion_Pseudo, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ.\nExemple: ( Hello.00-1 ).");
                txtConnexion_Pseudo.ForeColor = Color.Crimson;
            }
            else { Err_Connexion_Pseudo.Icon = Properties.Resources.oky; Err_Connexion_Pseudo.SetError(txtConnexion_Pseudo, "");
                txtConnexion_Pseudo.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }
        private void txtConnexion_Motdepasse_Leave(object sender, EventArgs e)
        { 
            // MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtConnexion_Motdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtConnexion_Motdepasse.Text))
            {
                Err_Connexion_Motdepasse.Icon = Properties.Resources.error; Err_Connexion_Motdepasse.SetError(txtConnexion_Motdepasse, "Champs invalide, le mot de passe doit contenire entre 4 et 10 caractères autorisés, veuillez remplire correctement ce champ.");
                txtConnexion_Motdepasse.ForeColor = Color.Crimson; }
            else { Err_Connexion_Motdepasse.Icon = Properties.Resources.oky; Err_Connexion_Motdepasse.SetError(txtConnexion_Motdepasse, "");
                txtConnexion_Motdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btn_Updateimg_Click(object sender, EventArgs e)
        {

            // PATH FOR THE LOGO
            string picPath;
            // OPEN WINDOWS FILE DIALOG
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            //dlg.Title = "SELECT USER PICTURE.";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picPath = dlg.FileName.ToString();
                txt_PicPath.Text = picPath;
                pictureBox.ImageLocation = picPath;

            }
            /*
               // RETRIVING PICTURE FROM DB
                byte[] imageBt2 = (byte[])(dr3["PICTURE"]);
                if (imageBt2 == null)
                { pictureBox.Image = null; }
                else
                {
                    MemoryStream mstream = new MemoryStream(imageBt2);
                    pictureBox.Image = System.Drawing.Image.FromStream(mstream);
                }
            */
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnexion_MouseEnter(object sender, EventArgs e)
        {
            btnConnexion.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnConnexion.ForeColor = Color.Black;
        }

        private void btnConnexion_MouseLeave(object sender, EventArgs e)
        {

            btnConnexion.BackColor = Color.White;
            btnConnexion.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }
        private void btnConnexion_Enter(object sender, EventArgs e)
        {
            btnConnexion.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            btnConnexion.ForeColor = Color.Black;
        }
        private void btnConnexion_Leave(object sender, EventArgs e)
        {

            btnConnexion.BackColor = Color.White;
            btnConnexion.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
     
        }


        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Crimson;
            btnQuitter.ForeColor = Color.Black;
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.White;
            btnQuitter.ForeColor = Color.Crimson;
        }




        private void btnInscription_MouseEnter(object sender, EventArgs e)
        {
            btnInscription.BackColor = Color.Crimson;
            btnInscription.ForeColor = Color.Black;
        }

        private void btnInscription_MouseLeave(object sender, EventArgs e)
        {
            btnInscription.BackColor = Color.White;
            btnInscription.ForeColor = Color.Crimson;
        }

  





        // REGEX LAB //

    }
}
