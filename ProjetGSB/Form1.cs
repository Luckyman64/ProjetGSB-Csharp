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
        private void Form1_Load(object sender, EventArgs e)
        {
            lesResponsables = new List<Responsable>();
            lesTechniciens = new List<Technicien>();
            /*Connexion connexion = new Connexion();
            connexion.Show();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreationTicket creationTicket = new CreationTicket();
            creationTicket.Show();
        }

        private void buttonSuiviTickets_Click(object sender, EventArgs e)
        {
            SuiviTicket suiviTicket = new SuiviTicket();
            suiviTicket.ShowDialog();
            this.Close();
        }

        private void buttonAjoutMat_Click(object sender, EventArgs e)
        {
            AjoutMat ajoutMat = new AjoutMat();
            ajoutMat.Show();
        }

        private void buttonSuppMat_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonModifTechUtil_Click(object sender, EventArgs e)
        {
            AjoutModifTechnicienUtilisateur ajoutModifTechnicienUtilisateur = new AjoutModifTechnicienUtilisateur();
            ajoutModifTechnicienUtilisateur.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int rangT;
            rangT = listBoxsuppTech.SelectedIndex;
            foreach(Technicien unTecnicien in lesTechniciens)
            {
                ///if(rangT.Equals(unTecnicien.Id))
                {
                    BdGSB.supprTechnicien(rangT);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Show();
        }
    }
}
