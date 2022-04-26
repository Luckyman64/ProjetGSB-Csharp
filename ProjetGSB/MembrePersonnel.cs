using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class MembrePersonnel : Employe
    {
        private string poste;
        private string idMat;
        private string matriculeResponsable;
        public MembrePersonnel(string matricule, string poste, string nom, string prenom, string adresse, string cp, string ville, string dateEmbauche, string idMat, string matriculeResponsable) 
            : base(matricule, nom, prenom, adresse, cp, ville, dateEmbauche)
        {
            this.poste = poste;
            this.idMat = idMat;
            this.matriculeResponsable = matriculeResponsable;
        }

        public string Poste { get => poste; set => poste = value; }
        public string IdMat { get => idMat; set => idMat = value; }
        public string MatriculeResponsable { get => matriculeResponsable; set => matriculeResponsable = value; }
    }
}
