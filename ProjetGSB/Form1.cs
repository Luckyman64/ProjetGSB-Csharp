using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Technicien> lesTechniciens;
        List<Responsable> lesResponsables;
        List<Materiel> lesMaterieles;
        private void Form1_Load(object sender, EventArgs e)
        {
            lesResponsables = new List<Responsable>();
            lesTechniciens = new List<Technicien>();
            lesMaterieles = new List<Materiel>();
            listBoxsuppTech.DataSource = lesTechniciens;
            ListeBoxMateriels.DataSource = lesMaterieles;
        }

        private void buttonCreationTicket_Click(object sender, EventArgs e)
        {
            CreationTicket creationTicket = new CreationTicket();
            creationTicket.Show();
        }

        private void buttonSuiviTickets_Click(object sender, EventArgs e)
        {
            SuiviTicket suiviTicket = new SuiviTicket();
            suiviTicket.Show();
        }

        private void buttonAjoutMat_Click(object sender, EventArgs e)
        {
            AjoutMat ajoutMat = new AjoutMat();
            ajoutMat.Show();
        }

        private void buttonSuppMat_Click(object sender, EventArgs e)
        {
            int rangM;
            rangM = ListeBoxMateriels.SelectedIndex;
            BdGSB.supprMateriel(rangM);
            lesMaterieles.Remove(lesMaterieles[rangM]);
        }

        private void buttonModifTechUtil_Click(object sender, EventArgs e)
        {
            AjoutModifTechnicienUtilisateur ajoutModifTechnicienUtilisateur = new AjoutModifTechnicienUtilisateur();
            ajoutModifTechnicienUtilisateur.Show();
        }

        private void ButtonSupprTech_Click(object sender, EventArgs e)
        {
            int rangT;
            rangT = listBoxsuppTech.SelectedIndex;
            foreach(Technicien unTecnicien in lesTechniciens)
            {
                if(rangT.Equals(unTecnicien.Matricule))
                {
                    BdGSB.supprTechnicien(rangT);
                    lesTechniciens.Remove(lesTechniciens[rangT]);
                }
            }
        }

        private void buttonConsultIncident_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Show();
        }
    }
}
