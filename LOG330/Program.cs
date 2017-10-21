using System;
using System.Collections.Generic;
using LOG330.Classe;

namespace LOG330
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("tappez le chemin du fichier csv à lire où Q pour quitter. Enfin appuyer sur la touche entrée pour confirmer votre choix ");
                string nomFichier = Console.ReadLine();
                Console.Clear();
                
                if(nomFichier == "Q")
                    break;
             
                try {
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
                        } else
                        {
                            listeX.Add(Convert.ToDouble(valeur[0]));
                            listeY.Add(Convert.ToDouble(valeur[1]));
                        }
                    }

                  double correlation = Calcul.CalculerCorrelation(listeX, listeY, nbDonnee);

                    Console.WriteLine("Corrélation: " + correlation);

                    if(correlation >= 0 && correlation <= 0.2){
                        Console.WriteLine("Corrélation Nulle à faible");
                    } else if(correlation >= 0.2 && correlation <= 0.4){
                        Console.WriteLine("Corrélation Faible à moyenne");
                    } else if (correlation >= 0.4 && correlation <= 0.7){
                        Console.WriteLine("Corrélation Moyenne à forte");
                    } else if (correlation >= 0.7 && correlation <= 0.9){
                        Console.WriteLine("Corrélation Forte à très forte");
                    } else if (correlation >= 0.9 && correlation <= 1){
                        Console.WriteLine("Corrélation Très forte à parfaite");
                    }
                    Console.ReadLine();
                    valid = true;
                }
                catch (Exception e) {
                    Console.WriteLine("Le chemin du fichier fourni est invalide. appuyer sur la touche entrée pour réassayer");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
        }
    }
}
