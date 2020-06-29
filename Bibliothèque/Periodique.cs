using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliothèque
{
    class Periodique : Ouvrage
    {
        private String nom;
        private int numero;
        private String periodicite;

        public Periodique(string nom, int numero, string periodicite, DateTime dateEmprunt) : base(dateEmprunt)
        {
            this.nom = nom;
            this.numero = numero;
            this.periodicite = periodicite;
        }

        public String getNom()
        {
            return nom;
        }
        public int getNumero()
        {
            return numero;
        }
        public String getPeriodicite()
        {
            return periodicite;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public void setPeriodicite(String periodicite)
        {
            this.periodicite = periodicite;
        }
        public override string ToString()
        {
            return "Type : Perdiodique - Nom : "+ nom + " - Numero : " + numero + " - Periodicite : " + periodicite + " - " +base.ToString()+ "\n";
        }
    }
}
