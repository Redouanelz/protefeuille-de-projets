using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// IMPORT PACKAGES
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;


namespace RlzProj.Profile
{
    public partial class MesInfos : Form
    {
        public MesInfos()
        {
            InitializeComponent();
        }
        // DECLARE
        int RequiredValidation =0;
        // REQUIRED VALIDATION REGEX FONCTION
        public int RegexUpdateAccount(int RequiredValidation)
        {
            // RequiredValidation COUNT : 5
            RequiredValidation = 0;
            // NOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtNom.Text, @"^[a-zA-Z]{4,40}$") || String.IsNullOrEmpty(txtNom.Text))
            { Err_Inscription_Nom.Icon = Properties.Resources.error; Err_Inscription_Nom.SetError(txtNom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtNom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Nom.Icon = Properties.Resources.oky; Err_Inscription_Nom.SetError(txtNom, ""); RequiredValidation++; txtNom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // PRENOM  -- @"^[a-zA-Zs]{1,40}$" -- from a-z A-Z spaceing 1 to 40
            if (!Regex.IsMatch(txtPrenom.Text, @"^[a-zA-Z]{4,40}$") || String.IsNullOrEmpty(txtPrenom.Text))
            { Err_Inscription_Prenom.Icon = Properties.Resources.error; Err_Inscription_Prenom.SetError(txtPrenom, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ."); txtPrenom.ForeColor = Color.Crimson; }
            else { Err_Inscription_Prenom.Icon = Properties.Resources.oky; Err_Inscription_Prenom.SetError(txtPrenom, ""); RequiredValidation++; txtPrenom.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // EMAIL ADRESSE -- @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"
            if (!Regex.IsMatch(txtAdresseEmail.Text, @"^[a-zA-Zs.-_]+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$") || String.IsNullOrEmpty(txtAdresseEmail.Text))
            { Err_Inscription_AdresseEmail.Icon = Properties.Resources.error; Err_Inscription_AdresseEmail.SetError(txtAdresseEmail, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ,\nExemple: ( Hello.001-@Exemple.com )."); txtAdresseEmail.ForeColor = Color.Crimson; }
            else { Err_Inscription_AdresseEmail.Icon = Properties.Resources.oky; Err_Inscription_AdresseEmail.SetError(txtAdresseEmail, ""); RequiredValidation++; txtAdresseEmail.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // PSEUDO -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 1 to 40
            if (!Regex.IsMatch(txtPseudo.Text, @"^[a-zA-Z0-9s.-]{4,40}$") || String.IsNullOrEmpty(txtPseudo.Text))
            { Err_Inscription_Pseudo.Icon = Properties.Resources.error; Err_Inscription_Pseudo.SetError(txtPseudo, "Champ invalide,\n le champ doit contenire entre 4 et 10 caractères autorisés,\n veuillez remplire correctement ce champ.\nExemple: ( Hello.00-1 )."); txtPseudo.ForeColor = Color.Crimson; }
            else { Err_Inscription_Pseudo.Icon = Properties.Resources.oky; Err_Inscription_Pseudo.SetError(txtPseudo, ""); RequiredValidation++; txtPseudo.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; }
            // MOT DE PASSE -- @"^[a-zA-Z0-9s.-]{1,40}$" --  from a-z A-Z 0-9 accepte - . no-spaceing 4 to 10
            if (!Regex.IsMatch(txtMotdepasse.Text, @"^[a-zA-Z0-9s.-]{4,10}$") || String.IsNullOrEmpty(txtMotdepasse.Text))
            { Err_Inscription_Motdepasse.Icon = Properties.Resources.error; Err_Inscription_Motdepasse.SetError(txtMotdepasse, "Champs invalide, le mot de passe doit contenire entre 4 et 10 caractères autorisés, veuillez remplire correctement ce champ."); txtMotdepasse.ForeColor = Color.Crimson; }
            else
            {
                Err_Inscription_Motdepasse.Icon = Properties.Resources.oky; Err_Inscription_Motdepasse.SetError(txtMotdepasse, ""); RequiredValidation++; txtMotdepasse.ForeColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
            }            
            return RequiredValidation;
        }  
        // LOAD INFOS
        private void MesInfos_Load(object sender, EventArgs e)
        {
            try // IMPORT ALL INFOS ABOUT IDPerso
            {
                txt_PicPath.Visible = false;
                Program.dt_Personnel.Clear();
               
                Program.da_Personnel = new SqlDataAdapter("SELECT * FROM Personnel WHERE IDPerso =" + Program.IDPerso, Program.cnx);
                Program.da_Personnel.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                Program.da_Personnel.Fill(Program.ds_RlzProj, "Personnel");
                Program.dt_Personnel = Program.ds_RlzProj.Tables["Personnel"];
            }
            catch { }

            try // SET INFOS TO INPUTS
            {
                txtNom.Text = Program.dt_Personnel.Rows[0]["NomPerso"].ToString();
                txtPrenom.Text = Program.dt_Personnel.Rows[0]["PrenomPerso"].ToString();
                txtPseudo.Text = Program.dt_Personnel.Rows[0]["PseudoPerso"].ToString();               
                txtAdresseEmail.Text = Program.dt_Personnel.Rows[0]["EmailPerso"].ToString();
                if (Program.dt_Personnel.Rows[0]["ImagePerso"] != null)
                {  // RETRIVING PICTURE FROM DB 
                    byte[] imageBt = (Byte[])(Program.dt_Personnel.Rows[0]["ImagePerso"]);
                    MemoryStream ms = new MemoryStream(imageBt);
                    pictureBox.Image = Image.FromStream(ms);
                    ms.Close();
                }
                lblName.Text = Program.dt_Personnel.Rows[0]["NomPerso"].ToString() + "  " + Program.dt_Personnel.Rows[0]["PrenomPerso"].ToString();
            }
            catch { MessageBox.Show("Impossible de charger vos informations."); }            
        }
        // LOAD NEW PICTURE
        private void btn_Updateimg_Click(object sender, EventArgs e)
        {
            // PATH FOR THE LOGO
            string picPath;
            // OPEN WINDOWS FILE DIALOG
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files(*.*)|*.*|JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            //dlg.Title = "SELECT USER PICTURE.";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picPath = dlg.FileName.ToString();
                txt_PicPath.Text = picPath;
                pictureBox.ImageLocation = picPath;
            }
        }
        // SAVE UPDATED INFOS 
        private void btnEnregistrerTache_Click(object sender, EventArgs e)
        {
            int ok = RegexUpdateAccount(RequiredValidation); // FUNCTION RETURN        
            if (ok == 5) // RequiredValidation COUNT : 5
            {              
                try
                {
                    // DECLARE Binary image 
                    byte[] imageBt = null;
                    if (txt_PicPath.Text != "")
                    {                      
                        FileStream fstream = new FileStream(this.txt_PicPath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imageBt = br.ReadBytes((int)fstream.Length);
                    }
                    Int64 HashedPassword = txtMotdepasse.Text.GetHashCode();
                    SqlCommandBuilder saver = new SqlCommandBuilder(Program.da_Personnel);
                    DataRow row;
                    row = Program.dt_Personnel.Rows.Find(Program.IDPerso);
                    row.BeginEdit();
                    row["NomPerso"] = txtNom.Text;
                    row["PrenomPerso"] = txtPrenom.Text;
                    row["PseudoPerso"] = txtPseudo.Text;
                    row["MotdepassePerso"] = HashedPassword;
                    row["EmailPerso"] = txtAdresseEmail.Text;
                    if (txt_PicPath.Text != "") { row["ImagePerso"] = imageBt; }
                    row.EndEdit();
                    Program.da_Personnel.Update(Program.dt_Personnel.Select("", "", DataViewRowState.ModifiedCurrent));
                    lblNotif.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); lblNotif.Text = "Compte modifier avec succés.";
                }
                catch { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Modification de compte impossible, vérifier la validité de vos informations."; }          
            }
            else { lblNotif.BackColor = Color.Crimson; lblNotif.Text = "Modification de compte impossible, vérifier la validité de vos informations."; }
      
          }
        // THIS.CLOSE
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
