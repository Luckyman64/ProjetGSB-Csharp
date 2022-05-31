using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetGSB
{
    public partial class AjoutModifTechnicienUtilisateur : Form
    {
        MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database = gsb; Uid = root; Password=; SSL Mode = None");
        MySqlDataReader dr;
        MySqlCommand cmd;
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
            MembrePersonnel unMembrePerso = new MembrePersonnel(textBoxModUtiMatricule.Text, textBoxModUtiPoste.Text, textBoxModUtiNom.Text, textBoxModUtiPrenom.Text, textBoxModUtiAdresse.Text, textBoxModUtiCp.Text, textBoxModUtiVille.Text, textBoxModUtiDateEmbauche.Text, textBoxModUtiIdMat.Text, textBoxModUtiMatResponsable.Text);
            BdGSB.modifUtilisateur(unMembrePerso);
        }

        private void AjoutModifTechnicienUtilisateur_Load(object sender, EventArgs e)
        {
            
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT matriculeTechnicien FROM technicien";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBoxTech.Items.Add(dr["matriculeTechnicien"]);
            }
            con.Close();

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT matriculePersonnel FROM membrePersonnel";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox2.Items.Add(dr["matriculePersonnel"]);
            }
            con.Close();
        }

        private void buttonModifUtilisateur_Click(object sender, EventArgs e)
        {
            int rang = Convert.ToInt32(listBox2.SelectedIndex.ToString());
            rang = rang + 1;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE membrepersonnel SET nom = @nom, prenom = @prenom, dateEmbauchePersonnel = @dateEmbauchePersonnel, poste = @poste WHERE nom='@matriculePersonnel'";
            cmd.Parameters.AddWithValue("@matriculePersonnel", rang);
            cmd.Parameters.AddWithValue("@nom", textBox23.Text);
            cmd.Parameters.AddWithValue("@prenom", textBox24.Text);
            cmd.Parameters.AddWithValue("@dateEmbauchePersonnel", textBox25.Text);
            cmd.Parameters.AddWithValue("@poste", textBox26.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
