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
    public partial class AjoutMat : Form
    {
        public AjoutMat()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Materiel unMateriel = new Materiel(TBProcesseur.Text, TBMemoire.Text, TBDisque.Text, TBDateAchat.Text, TBGarantie.Text, TBFournisseur.Text);
            BdGSB.ajoutMateriel(unMateriel);
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
