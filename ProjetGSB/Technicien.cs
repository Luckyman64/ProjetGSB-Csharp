using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Technicien : Employe
    {
        private string niveauIntervention;
        private string formation;
        private string matriculeResponsable;

        public Technicien(string matricule, string nom, string prenom, string adresse, string cp, string ville, string dateEmbauche, string niveauIntervention, string formation, string matriculeResponsable) 
            : base(matricule, nom, prenom, adresse, cp, ville, dateEmbauche)
        {
            this.niveauIntervention = niveauIntervention;
            this.formation = formation;
            this.matriculeResponsable = matriculeResponsable;
        }

        public string NiveauIntervention { get => niveauIntervention; set => niveauIntervention = value; }
        public string Formation { get => formation; set => formation = value; }
        public string MatriculeResponsable { get => matriculeResponsable; set => matriculeResponsable = value; }
    }
}
