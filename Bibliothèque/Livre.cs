﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque
{
    class Livre : Ouvrage
    {
        private String auteur;
        private String titre;
        private String editeur;

        public Livre(string auteur, string titre, string editeur, DateTime dateEmprunt) : base(dateEmprunt)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
        }
        public String getAuteur()
        {
            return auteur;
        }
        public String getTitre()
        {
            return titre;
        }
        public String getEditeur()
        {
            return editeur;
        }
        public void setAuteur(String auteur)
        {
            this.auteur = auteur;
        }
        public void setTitre(String titre)
        {
            this.titre = titre;
        }
        public void setEditeur(String editeur)
        {
            this.editeur = editeur;
        }
        public override string ToString()
        {
            return "Type : Livre - Auteur : " + auteur + " - Titre : " + titre + " - Editeur : " + editeur + " - " + base.ToString() + "\n";
        }
    }
}
