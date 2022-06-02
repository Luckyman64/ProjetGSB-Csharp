using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    internal class AchatMateriel
    {
        private int id;
        private String typeMat;
        private String caractéristique;
        private String lieuVente;
        private String prixVente;
        private String date;

        public AchatMateriel(int id, string typeMat, string caractéristique, string lieuVente, string prixVente, string date)
        {
            this.id = id;
            this.typeMat = typeMat;
            this.caractéristique = caractéristique;
            this.lieuVente = lieuVente;
            this.prixVente = prixVente;
            this.date = date;
        }

        public int Id { get => id; set => id = value; }
        public string TypeMat { get => typeMat; set => typeMat = value; }
        public string Caractéristique { get => caractéristique; set => caractéristique = value; }
        public string LieuVente { get => lieuVente; set => lieuVente = value; }
        public string PrixVente { get => prixVente; set => prixVente = value; }
        public string Date { get => date; set => date = value; }
    }
}
