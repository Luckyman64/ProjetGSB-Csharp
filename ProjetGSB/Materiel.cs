using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Materiel
    {
        private string id;
        private string processeur;
        private string memoire;
        private string disque;
        private string date_achat;
        private string garantie;
        private string fournisseur;

        public Materiel(string id, string processeur, string memoire, string disque, string date_achat, string garantie, string fournisseur)
        {
            this.id = id;
            this.processeur = processeur;
            this.memoire = memoire;
            this.disque = disque;
            this.date_achat = date_achat;
            this.garantie = garantie;
            this.fournisseur = fournisseur;
        }

        public string Id { get => id; set => id = value; }
        public string Processeur { get => processeur; set => processeur = value; }
        public string Memoire { get => memoire; set => memoire = value; }
        public string Disque { get => disque; set => disque = value; }
        public string Date_achat { get => date_achat; set => date_achat = value; }
        public string Garantie { get => garantie; set => garantie = value; }
        public string Fournisseur { get => fournisseur; set => fournisseur = value; }
    }
}
