using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque
{
    class CD : Ouvrage
    {
        private String titre;
        private String auteur;

        public CD(string titre, string auteur, DateTime dateEmprunt) : base(dateEmprunt)
        {
            this.titre = titre;
            this.auteur = auteur;
        }
        public String getAuteur()
        {
            return auteur;
        }
        public String getTitre()
        {
            return titre;
        }
        public void setAuteur(String auteur)
        {
            this.auteur = auteur;
        }
        public void setTitre(String titre)
        {
            this.titre = titre;
        }
        public override string ToString()
        {
            return "Type : CD - Auteur : " + auteur + " - Titre : " + titre + " - " + base.ToString() + "\n";
        }
    }
}
