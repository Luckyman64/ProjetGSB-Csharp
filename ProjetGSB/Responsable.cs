using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Responsable : Employe
    {
        
        public Responsable(string matricule, string nom, string prenom, string adresse, string cp, string ville, string dateEmbauche)
            :base(matricule, nom, prenom, adresse, cp, ville, dateEmbauche)
        {
        }

    }
}
