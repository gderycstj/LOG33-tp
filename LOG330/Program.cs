using System;
using System.Collections.Generic;
using LOG330.Classe;

namespace LOG330
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const double estimation = 900;
            const double student90 = 1.860;
            const double student70 = 1.108;
            
            while (true)
            {
                Console.Write("tappez le chemin du fichier csv à lire ou Q pour quitter. Enfin, appuyer sur la " +
                                  " touche entrée pour confirmer votre choix ");
                string nomFichier = Console.ReadLine();
                Console.Clear();
                
                if(nomFichier == "Q")
                   return;
             
                try 
                {
                    string[] lignesFichier = Fichier.Lire(nomFichier);
                    List<double> listeX = new List<double>();
                    List<double> listeY = new List<double>();

                    double nbDonnee = 0;

                    for (int i = 0; i < lignesFichier.Length; i++)
                    {
                        string[] valeur = lignesFichier[i].Split(';');

                        if (valeur.Length < 2)
                            throw new Exception("doit avoir 2 listes de données");

                        if(i == 0)
                        {
                            nbDonnee = Convert.ToDouble(valeur[0]);
                        } 
                        
                        else
                        {
                            listeX.Add(Convert.ToDouble(valeur[0]));
                            listeY.Add(Convert.ToDouble(valeur[1]));
                        }
                    }

                   double ecartType =  Calcul.CalculerEcartTypeListe(listeX, listeY, nbDonnee);
                   double intervalle70 =
                        Calcul.CalculerIntervalleConfiance(ecartType, estimation, student70, listeX, nbDonnee);
                   double intervalle90 = 
                       Calcul.CalculerIntervalleConfiance(ecartType, estimation, student90, listeX, nbDonnee);

                    intervalle70 = Math.Round(intervalle70, 0);
                    intervalle90 = Math.Round(intervalle90, 0);
                    
                    Console.WriteLine("Nb de ligne de code estimé: " + estimation);
                    Console.WriteLine();
                    Console.WriteLine("Intervalle 90%: " + intervalle90);
                    Console.WriteLine();
                    Console.WriteLine("Il y a 90% de chances que la taille du projet soit entre " 
                                      + (estimation - intervalle90)
                                      + " et "
                                      + (estimation + intervalle90));
                    Console.WriteLine();
                    Console.WriteLine("Intervalle 70%: " + intervalle70);
                    Console.WriteLine();
                    Console.WriteLine("Il y a 70% de chances que la taille du projet soit entre " 
                                      + (estimation - intervalle70)
                                      + " et "
                                      + (estimation + intervalle70));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch 
                {
                    Console.WriteLine("Le chemin du fichier fourni est invalide. appuyer sur la touche entrée " +
                                      "pour réassayer");                                      
                    Console.ReadLine();
                    Console.Clear();
                }
            }         
        }

        public static void AfficherCorrelation(double correlation)
        {
            Console.WriteLine("Corrélation: " + correlation);
            
            if(correlation >= 0 && correlation <= 0.2)
            {
                Console.WriteLine("Corrélation Nulle à faible");
            } 
            else if(correlation >= 0.2 && correlation <= 0.4)
            {
                Console.WriteLine("Corrélation Faible à moyenne");
            } 
            else if (correlation >= 0.4 && correlation <= 0.7)
            {
                Console.WriteLine("Corrélation Moyenne à forte");
            } 
            else if (correlation >= 0.7 && correlation <= 0.9)
            {
                Console.WriteLine("Corrélation Forte à très forte");
            } 
            else if (correlation >= 0.9 && correlation <= 1)
            {
                Console.WriteLine("Corrélation Très forte à parfaite");
            }
            Console.ReadLine();
        } 
    }
}
