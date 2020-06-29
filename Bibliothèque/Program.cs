using System;
using System.Collections.Generic;
namespace Bibliothèque
{
    class Program
    {

        static void Main(string[] args)
        {
            void ligne(Char c)
            {
                for (int i = 0; i < 120; i++)
                    Console.Write(c);
                Console.WriteLine();
            }
            void type()
            {
                
                
            }
            //Bibliotheque b = new BiblioTab(new List<Ouvrage>());
            Bibliotheque b = new BiblioTab(new Dictionary<string, Ouvrage>());
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                ligne('=');
                Console.WriteLine("\t\t\t\t\t\t\tMenu");
                ligne('=');
                Console.WriteLine("1 . Afficher la liste d'ouvrages");
                Console.WriteLine("2 . Ajouter un ouvrage");
                Console.WriteLine("3 . Supprimer un ouvrage");
                Console.WriteLine("4 . Sortir");
                Console.Write("Choix : ");
                int choix = 0;
                while(choix < 1 || choix > 5)
                    choix = Convert.ToInt16(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        ligne('=');
                        Console.WriteLine("\t\t\t\t\t\t\tListe des ouvrages");
                        ligne('=');
                        Console.WriteLine(b);
                        Console.WriteLine("Appuyez sur entrer pour continuer ...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        int t = 0;
                        ligne('=');
                        Console.WriteLine("\t\t\t\t\t\t\tAjout Ouvrage");
                        ligne('=');
                        Console.WriteLine("1 . CD");
                        Console.WriteLine("2 . Livre");
                        Console.WriteLine("3 . Périodique");
                        Console.WriteLine("4 . Menu precedent");
                        Console.Write("Type : ");
                        while (t < 1 || t > 4)
                            t = Convert.ToInt16(Console.ReadLine());
                        switch (t)
                        {
                            case 1:
                                CD cd = new CD("", "", new DateTime());
                                Console.Write("Titre : ");
                                cd.setTitre(Console.ReadLine());
                                Console.Write("Auteur : ");
                                cd.setAuteur(Console.ReadLine());
                                b.addOuvrage(cd);
                                break;
                            case 2:
                                Livre l = new Livre("","", "", new DateTime());
                                Console.Write("Titre : ");
                                l.setTitre(Console.ReadLine());
                                Console.Write("Auteur : ");
                                l.setAuteur(Console.ReadLine());
                                Console.Write("Editeur : ");
                                l.setEditeur(Console.ReadLine());
                                b.addOuvrage(l);
                                break;
                            case 3:
                                Periodique p = new Periodique("", 0, "", new DateTime());
                                Console.Write("Nom : ");
                                p.setNom(Console.ReadLine());
                                Console.Write("Numero : ");
                                p.setNumero(Convert.ToInt32(Console.ReadLine()));
                                Console.Write("Periodicité : ");
                                p.setPeriodicite(Console.ReadLine());
                                b.addOuvrage(p);
                                break;
                            case 4:

                                break;
                        }
                        Console.WriteLine("Appuyez sur enter pour continuer ...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        ligne('=');
                        Console.WriteLine("\t\t\t\t\t\t\tSupprimer Ouvrage");
                        ligne('=');
                        Console.WriteLine(b);
                        int o = -1;
                        while (o < 0 || o > b.getOuvrageList().Count -1)
                        {
                            Console.Write("Numero d'ouvrge (-1 pour revenir annuler) : ");
                            o = Convert.ToInt32(Console.ReadLine());
                            if (o == -1)
                                break;
                        }
                        if (o != -1)
                            b.delOuvrage(b.getOuvrageList()[o]);
                        Console.WriteLine("Appuyez sur entrer pour continuer ...");
                        Console.ReadLine();
                        break;
                    case 4:
                        flag = false;
                        break;
                }

            }
        }
        
    }
}
