using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Employe
    {
        private string matricule;
        private string nom;
        private string prenom;
        private string adresse;
        private string cp;
        private string ville;
        private string dateEmbauche;

        public Employe(string matricule, string nom, string prenom, string adresse, string cp, string ville, string dateEmbauche)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string DateEmbauche { get => dateEmbauche; set => dateEmbauche = value; }
    }
}
