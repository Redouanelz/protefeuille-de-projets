using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// IMPORTED
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace RlzProj._Config
{
    public partial class ConfigurationConnexion : Form
    {
        public ConfigurationConnexion()
        {
            InitializeComponent();

            pnl_State.Dock = DockStyle.Fill;
            pnl_ChangeCnxString.Visible = false;
        }

        // LOAD 
        private void ConfigurationConnexion_Load(object sender, EventArgs e)
        {
            // Initialize the ipunt Paths
            txt_XmlPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txt_Source_MdfPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\";
            txt_target_MdfPath.Text = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+"\\StartConfig\\";
            txt_MdfName.Text = "RlzProject.mdf"; 
            txt_LDFName.Text = "RlzProject_log.LDF";
            // ENABLED = false; TO THE "UserID.Text" And "Password.Text"
            txt_UserID.Enabled = false;
            txt_Password.Enabled = false;
            // GET THE CURRENT CONNEXION STRING "Rlzcnx" FROM App.Config >> AND SHOW IT ON THE  "txt_OldConnectionString.Text" INPUT
            string GetOldCnxString = Properties.Settings.Default.Rlzcnx;
            txt_OldConnectionString.Text = GetOldCnxString;
        }
        // VALIDATE / CHANGE THE CONNEXION STRING
        private void btnConfigurer_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Rlzcnx = txt_NewConnexionString.Text;
                Properties.Settings.Default.Save();
                btnValider.Enabled = false; btnValider.Text = "BIEN ENREGISTRER";
                txt_NewConnexionString.Enabled = false;
                txt_OldConnectionString.Enabled = false;
            }
            catch { }

            MessageBox.Show("Nouvelle chaîne de connexion:\n" + Properties.Settings.Default.Rlzcnx);

        }
        // MAKE AND SHOW NEW CONNECION STRING 
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            string SetNewCnxString_withSecurity = @"Data Source=" + txt_DataSource.Text + ";Initial Catalog=" + txt_InitialCatalog.Text + ";Persist Security Info=True;User ID=" + txt_UserID.Text + ";Password=" + txt_Password.Text;
            string SetNewCnxString_withoutSecurity = @"Data Source=" + txt_DataSource.Text + ";Initial Catalog=" + txt_InitialCatalog.Text + ";Integrated Security=True";
            if (Check_IntegreatedSecurity.Checked == true)
            {
                txt_NewConnexionString.Text = SetNewCnxString_withSecurity;
            }
            else if (Check_IntegreatedSecurity.Checked == false)
            {
                txt_NewConnexionString.Text = SetNewCnxString_withoutSecurity;
            }
        }
        // CHECKED / UNCHEKED EVENT
        private void Check_IntegreatedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_IntegreatedSecurity.Checked == true)
            {
                txt_UserID.Enabled = true;
                txt_Password.Enabled = true;
            }
            if (Check_IntegreatedSecurity.Checked == false)
            {
                txt_UserID.Enabled = false;
                txt_Password.Enabled = false;
            }
        }              
        // THIS.CLOSE
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relancer l'application pour que les modification soit prise en compte.","Fermeture.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Application.Exit();
        }
        // HELP LINK
        private void lbl_Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://msdn.microsoft.com/fr-fr/library/bb545450.aspx");
        }
        // WRITE XML
        private void btn_Write_xml_xsd_Click(object sender, EventArgs e)
        {
            try
            {                
                StartConfig.RlzDsFull ds = new StartConfig.RlzDsFull();
                ds.WriteXml(txt_XmlPath.Text + "\\Sauvgarde.xml");
                ds.WriteXmlSchema(txt_XmlPath.Text + "\\Sauvgarde.xsd");

                MessageBox.Show("Ecriture réusite.", "Ecriture réusite.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            }
            catch { MessageBox.Show("Veuillez Spécifier un chemin valide.", "Chemin Invalide.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // TESTE NEW CONNEXION
        private void btn_Test_Click(object sender, EventArgs e)
        {
            SqlConnection cnx_try = new SqlConnection(txt_NewConnexionString.Text);
            try
            {
                cnx_try.Open();
                MessageBox.Show("Connexion bien établie, Information de connection valide.", "Tester la connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch { MessageBox.Show("Connexion non établie, Veuillez vérifier la validité des informations.", "Tester la connexion", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        // SAVE
        private void btn_AttachDB_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName_MDF = txt_MdfName.Text;
                string fileName_LDF = txt_LDFName.Text; 
                string targetPath = txt_target_MdfPath.Text;
                string sourcePath = txt_Source_MdfPath.Text;
                // MDF
                string sourceFile_MDF = System.IO.Path.Combine(sourcePath, fileName_MDF);
                string MDF_File = System.IO.Path.Combine(targetPath, fileName_MDF);
                if (!System.IO.Directory.Exists(targetPath)) // To copy a folder's contents to a new location: Create a new target folder, if necessary.
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                System.IO.File.Copy(sourceFile_MDF, MDF_File, true);   // To copy a file to another location and overwrite the destination file if it already exists.
                // LDF
                string sourceFile_LDF = System.IO.Path.Combine(sourcePath, fileName_LDF);
                string LDF_File = System.IO.Path.Combine(targetPath, fileName_LDF);
                if (!System.IO.Directory.Exists(targetPath)) 
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }

                System.IO.File.Copy(sourceFile_LDF, LDF_File, true);
                txt_NewConnexionString.Text = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\StartConfig\\RlzProject.mdf;Integrated Security=True;User Instance=True";
          
                MessageBox.Show("Imoprtation réusite.", "Imoprtation réusite.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
            }
            catch {
                txt_NewConnexionString.Text = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\StartConfig\\RlzProject.mdf;Integrated Security=True;User Instance=True"; 
                MessageBox.Show("Imoprtation non réusite.", "Imoprtation non réusite.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // GET THE SOURCE PATH
        private void btn_ImportDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_Source_MdfPath.Text = System.IO.Directory.GetParent(open.FileName).ToString() + "\\";                 
            }
        }
        // FIRST FRAM LOGIN
        private void btn_ContinuerConfig_Click(object sender, EventArgs e)
        {
            lbl_Incorrecte.Text = "";
            string MdpConfiguration = Properties.Settings.Default.MdpConfiguration;
            if (txt_MdpConfig.Text == MdpConfiguration)
            {
                pnl_State.Dock = DockStyle.None;
                pnl_ChangeCnxString.Visible = true;
            }
            else
            {
                lbl_Incorrecte.Text = "X  Incorrecte";
            }
        }


    }
}
