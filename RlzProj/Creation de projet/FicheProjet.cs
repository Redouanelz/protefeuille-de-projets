using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// IMPORT PACKAGES
using System.IO;
using System.Data.SqlClient;


namespace RlzProj.Creation_de_projet
{
    public partial class FicheProjet : Form
    {
        public FicheProjet()
        {
            InitializeComponent();
            // DRAWING
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        // FUNCTIONS
        public void LoadListeChefProjet()
        {
            // LOAD COMBOBOX
            Program.cnx.Open(); txt_ChefProjetName.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT NomPerso,PrenomPerso FROM Personnel;", Program.cnx);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            { txt_ChefProjetName.Items.Add( dr["NomPerso"].ToString() + " " + dr["PrenomPerso"].ToString() ); }
            dr.Close(); Program.cnx.Close();         
        }
        // LOAD
        private void FicheProjet_Load(object sender, EventArgs e)
        {
            // SET .SelectedIndex = 0;
            txt_Statut.SelectedIndex = 0;
            // IMPORT TABLE FicheProj
            Program.da_FicheProj = new SqlDataAdapter("SELECT * FROM FicheProj",Program.cnx);
            Program.da_FicheProj.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Program.da_FicheProj.Fill(Program.ds_RlzProj, "FicheProj");
            Program.dt_FicheProj = Program.ds_RlzProj.Tables["FicheProj"];
            // LOAD COMBOBOX
            LoadListeChefProjet();           
            // HIDE UPDATE AND DELETE BUTTON
            btnModifierProjet.Visible = false;
        }
        // ENREGISTRER - MODIFIER - SUPPRIMER
        private void btnEnregistrerProjet_Click(object sender, EventArgs e)
        {
            int RequiredFielsvalidations = 0;
            lblErrorInfos.Text = "";
            // REQUIRED FIELDS VALIDATION
            if (String.IsNullOrEmpty(txt_NomProjet.Text)) { ErrNomProjet.Icon = Properties.Resources.error; ErrNomProjet.SetError(txt_NomProjet, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrNomProjet.Icon = Properties.Resources.oky; ErrNomProjet.SetError(txt_NomProjet, ""); RequiredFielsvalidations++; }

            if (String.IsNullOrEmpty(txt_Description.Text)) { ErrDescProj.Icon = Properties.Resources.error; ErrDescProj.SetError(txt_Description, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrDescProj.Icon = Properties.Resources.oky; ErrDescProj.SetError(txt_Description, ""); RequiredFielsvalidations++; }

            if (String.IsNullOrEmpty(txt_Code.Text)) { ErrCodeProj.Icon = Properties.Resources.error; ErrCodeProj.SetError(txt_Code, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrCodeProj.Icon = Properties.Resources.oky; ErrCodeProj.SetError(txt_Code, ""); RequiredFielsvalidations++;  }

            if (RequiredFielsvalidations == 3)
            {
                // ENREGISTREMENT OK
                try
                {
                    // DECLARE Binary image 
                    byte[] imageBt = null;
                    FileStream fstream = new FileStream(this.txt_PicPath.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imageBt = br.ReadBytes((int)fstream.Length);

                    SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_FicheProj);
                    DataRow dar;
                    dar = Program.dt_FicheProj.NewRow();
                    //dar["IDProj"] = Program.IDProj;
                    dar["NomProj"] = txt_NomProjet.Text;
                    dar["DescProj"] = txt_Description.Text;
                    dar["StatutProj"] = txt_Statut.Text;
                    dar["CodeProj"] = txt_Code.Text;
                    dar["ChefProj"] = txt_ChefProjetName.Text;
                    dar["ChefProjID"] = Convert.ToInt32(txt_ChefProjetName.SelectedIndex);
                    dar["LogoProj"] = imageBt;
                    dar["DateDebutProj"] = txt_DateDebut.Text;
                    dar["DateFinProj"] = txt_DateFin.Text;
                    dar["CibleProjet"] = Convert.ToDecimal(txt_CibleBudgetaire.Text);

                    Program.dt_FicheProj.Rows.Add(dar);
                    Program.da_FicheProj.Update(Program.dt_FicheProj.Select("", "", DataViewRowState.Added));
                    btnEnregistrerProjet.Enabled = false;
                    btnEnregistrerProjet.Text = "FICHE ENREGISTRER";
                    Program.FicheProjOk = true;
                    btnModifierProjet.Visible = true;
                    lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));; lblErrorInfos.Text = "Fiche enregistrer avec succés.";
                }
                catch { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Fiche non enregistrer,veuillez verifier la validité de tous les champs."; }
            }
            else { lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Fiche non enregistrer,veuillez verifier la validité de tous les champs.";  };
            
        }
        private void btnModifierProjet_Click(object sender, EventArgs e)
        { 
           int RequiredFielsvalidations = 0;
            lblErrorInfos.Text = "";
            // REQUIRED FIELDS VALIDATION
            if (String.IsNullOrEmpty(txt_NomProjet.Text)) { ErrNomProjet.Icon = Properties.Resources.error; ErrNomProjet.SetError(txt_NomProjet, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrNomProjet.Icon = Properties.Resources.oky; ErrNomProjet.SetError(txt_NomProjet, ""); RequiredFielsvalidations++; }

            if (String.IsNullOrEmpty(txt_Description.Text)) { ErrDescProj.Icon = Properties.Resources.error; ErrDescProj.SetError(txt_Description, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrDescProj.Icon = Properties.Resources.oky; ErrDescProj.SetError(txt_Description, ""); RequiredFielsvalidations++; }

            if (String.IsNullOrEmpty(txt_Code.Text)) { ErrCodeProj.Icon = Properties.Resources.error; ErrCodeProj.SetError(txt_Code, "Champs obligatoire, veuillez remplire ce champ."); }
            else { ErrCodeProj.Icon = Properties.Resources.oky; ErrCodeProj.SetError(txt_Code, ""); RequiredFielsvalidations++;  }
            // ALL FIELDS TRY
            if (String.IsNullOrEmpty(txt_NomProjet.Text) || String.IsNullOrEmpty(txt_Description.Text) || String.IsNullOrEmpty(txt_Statut.Text) || String.IsNullOrEmpty(txt_Code.Text) || String.IsNullOrEmpty(txt_ChefProjet.Text))
            {
               lblErrorInfos.BackColor = Color.Crimson; lblErrorInfos.Text = "Fiche non modifier,veuillez verifier la validité de tous les champs.";
            }
            else
            {
                // ENREGISTREMENT DE MODIFICATION OK
                    try
                    {
                        // DECLARE Binary image 
                        byte[] imageBt = null;
                        FileStream fstream = new FileStream(this.txt_PicPath.Text, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fstream);
                        imageBt = br.ReadBytes((int)fstream.Length);

                        SqlCommandBuilder cmb = new SqlCommandBuilder(Program.da_FicheProj);
                        DataRow dar;
                        dar = Program.dt_FicheProj.Rows.Find(Program.IDProj);
                        dar.BeginEdit();
                        //dar["IDProj"] = Program.IDProj;
                        dar["NomProj"] = txt_NomProjet.Text;
                        dar["DescProj"] = txt_Description.Text;
                        dar["StatutProj"] = txt_Statut.Text;
                        dar["CodeProj"] = txt_Code.Text;
                        dar["ChefProj"] = txt_ChefProjetName.Text;
                        dar["ChefProjID"] = Convert.ToInt32(txt_ChefProjetName.SelectedIndex);
                        dar["LogoProj"] = imageBt;
                        dar["DateDebutProj"] = txt_DateDebut.Text;
                        dar["DateFinProj"] = txt_DateFin.Text;
                        dar["CibleProjet"] = Convert.ToDecimal(txt_CibleBudgetaire.Text);
                        dar.EndEdit();
                        Program.da_FicheProj.Update(Program.dt_FicheProj.Select("", "", DataViewRowState.ModifiedCurrent));
                        lblErrorInfos.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));;
                        lblErrorInfos.Text = "Fiche modifier avec succés.";
                    }
                    catch { lblErrorInfos.BackColor = Color.Crimson;  lblErrorInfos.Text = "Fiche non enregistrer,veuillez verifier la validité de tous les champs."; }
            }

          
        }
        private void btnSupprimerProjet_Click(object sender, EventArgs e)
        {
           // RETIRER DU CODE.
        }

        // OPEN FILEDIALOG TO GET PICTURE Path
        private void btn_AjoutLogo_Click(object sender, EventArgs e)
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
        // CIBLE BUDEGTAIRE KEYPRESS
        private void txt_CibleBudgetaire_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == ',') // || e.KeyChar == '.'
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }


        // HIDE & SHOW PICTURE
        private void btn_UpDown_MouseEnter(object sender, EventArgs e)
        {
            pnl_Create_Container.Visible = false;
        }

        private void btn_UpDown_MouseLeave(object sender, EventArgs e)
        {
            pnl_Create_Container.Visible = true;
        }
        //SET THE ID ON THE TEXTBOX
        private void txt_ChefProjetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_ChefProjet.Text = txt_ChefProjetName.SelectedIndex.ToString();
        }


        // END.
      
       
    }
}
