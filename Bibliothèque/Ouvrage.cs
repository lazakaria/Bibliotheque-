using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque
{
    class Ouvrage
    {
        protected DateTime dateEmprunt;
        protected int cote;
        private static int nbOuvrage = 0;
        public Ouvrage(DateTime dateEmprunt)
        {
            nbOuvrage++;
            cote = nbOuvrage;
            this.dateEmprunt = dateEmprunt;
        }
        public int getCote()
        {
            return cote;
        }
        public override string ToString()
        {
            return "Date d'enprunt : " + dateEmprunt;
        }
    }
}
