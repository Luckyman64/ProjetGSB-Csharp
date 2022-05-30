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
    public partial class AjoutModifTechnicienUtilisateur : Form
    {
        public AjoutModifTechnicienUtilisateur()
        {
            InitializeComponent();
        }

        private void buttonAjouterTechnicien_Click(object sender, EventArgs e)
        {
            Technicien unTechnicien = new Technicien(textBoxModTechMatricule.Text, textBoxModTechNom.Text, textBoxModTechPrenom.Text, textBoxModTechAdresse.Text, textBoxModTechCp.Text, textBoxModifTechVille.Text, textBoxModTechDateEmbauche.Text, textBoxModTechNiveauIntervention.Text, textBoxModTechFormation.Text, textBoxModifMatriculeResponsable.Text);
            BdGSB.ajoutTechnicien(unTechnicien);
        }

        private void buttonAjoutUtilisateur_Click(object sender, EventArgs e)
        {
            MembrePersonnel unMembrePerso = new MembrePersonnel(textBoxModUtiMatricule.Text, textBoxModUtiPoste.Text, textBoxModUtiNom.Text, textBoxModUtiPrenom.Text, textBoxModUtiAdresse.Text, textBoxModUtiCp.Text, textBoxModUtiVille.Text, textBoxModUtiDateEmbauche.Text, textBoxModUtiIdMat.Text, textBoxModUtiMatResponsable.Text);
            BdGSB.ajoutUtilisateur(unMembrePerso);
        }

        private void buttonModifTechnicien_Click(object sender, EventArgs e)
        {
            
        }

        private void AjoutModifTechnicienUtilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
