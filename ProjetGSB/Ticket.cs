using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Ticket
    {
        private int numeroTicket;
        private string objet;
        private string niveauUrgence;
        private string date;
        private string idMat;
        private string matriculePersonnel;

        public Ticket(int numeroTicket, string objet, string niveauUrgence, string date, string idMat, string matriculePersonnel)
        {
            this.numeroTicket = numeroTicket;
            this.objet = objet;
            this.niveauUrgence = niveauUrgence;
            this.date = date;
            this.idMat = idMat;
            this.matriculePersonnel = matriculePersonnel;
        }

        public int NumeroTicket { get => numeroTicket; set => numeroTicket = value; }
        public string Objet { get => objet; set => objet = value; }
        public string NiveauUrgence { get => niveauUrgence; set => niveauUrgence = value; }
        public string Date { get => date; set => date = value; }
        public string IdMat { get => idMat; set => idMat = value; }
        public string MatriculePersonnel { get => matriculePersonnel; set => matriculePersonnel = value; }
    }
}
