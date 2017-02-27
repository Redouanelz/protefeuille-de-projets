using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RlzProj.Creation_de_projet
{
    public partial class FinCreationProjet : Form
    {
        public FinCreationProjet()
        {
            InitializeComponent();
        }

        private void FinCreationProjet_Load(object sender, EventArgs e)
        {
        }

        private void btnLoadRaportFCP_Click(object sender, EventArgs e)
        {

            try
            {
                Program.cnx.Open();
                Raport_FCP Raport_FinCreationProjet = new Raport_FCP();
                //Raport_FinCreationProjet.SetParameterValue("IDProjx", Program.IDProj);
                RapportCreationProjet.ReportSource = Raport_FinCreationProjet;
                RapportCreationProjet.Refresh();
                Program.cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Charegement inpossible.\n" + ex.Message);
            }

        }
    }
}
