using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGSB
{
    class Region
    {
        private string numRegion;
        private string nomRegion;

        public Region(string numRegion, string nomRegion)
        {
            this.numRegion = numRegion;
            this.nomRegion = nomRegion;
        }

        public string NumRegion { get => numRegion; set => numRegion = value; }
        public string NomRegion { get => nomRegion; set => nomRegion = value; }
    }
}
