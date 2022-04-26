using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Ticket
    {
        private string objet;
        private string niveauUrgence;
        private string dateHeure;
        private string idMat;
        private string matriculePersonnel;

        public Ticket(string objet, string niveauUrgence, string dateHeure, string idMat, string matriculePersonnel)
        {
            this.objet = objet;
            this.niveauUrgence = niveauUrgence;
            this.dateHeure = dateHeure;
            this.idMat = idMat;
            this.matriculePersonnel = matriculePersonnel;
        }

        public string Objet { get => objet; set => objet = value; }
        public string NiveauUrgence { get => niveauUrgence; set => niveauUrgence = value; }
        public string DateHeure { get => dateHeure; set => dateHeure = value; }
        public string IdMat { get => idMat; set => idMat = value; }
        public string MatriculePersonnel { get => matriculePersonnel; set => matriculePersonnel = value; }
    }
}
