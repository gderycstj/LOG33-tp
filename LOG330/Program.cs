using System;
using System.Collections.Generic;
using LOG330.Classe;

namespace LOG330
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("tappez le chemin du fichier csv à lire où Q pour quitter. Enfin appuyer sur la touche entrée pour confirmer votre choix ");
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
                        } else
                        {
                            listeX.Add(Convert.ToDouble(valeur[0]));
                            listeY.Add(Convert.ToDouble(valeur[1]));
                        }
                    }

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("===========Menu================");
                        Console.WriteLine("1. Entrer valeur de x et calculer le y");
                        Console.WriteLine("2. Entrer valeur de y et calculer le x");
                        Console.WriteLine("3. Quitter l'application");
                        Console.WriteLine("===============================");
                        string choix = Console.ReadLine();
                        
                        if(choix == "3")
                            return;
                        
                        Console.WriteLine("Veuillez rentrer la valeur demandé: ");
                        string valeur = Console.ReadLine();
                        
                        Console.Clear();

                        double pente = Calcul.CalculerPenteRegression(listeX, listeY, nbDonnee);
                        double constante = Calcul.CalculerConstanteRegression(listeX, listeY, pente);
                        
                       Console.WriteLine( "Pente: " + pente);
                       Console.WriteLine("Constante: " + constante);
                       Console.Clear();
                       switch (choix)
                        {
                                case "1":
                                    double valeurY = (pente * Convert.ToDouble(valeur)) + constante;
                                    Console.WriteLine("Valeur Y = " + valeurY);
                                break;
                                case "2":
                                    double valeurX = ( Convert.ToDouble(valeur) - constante)/ pente;
                                    Console.WriteLine("Valeur X = " + valeurX);
                                break;
                                default:
                                    Console.WriteLine("La valeur doit être entre 1 et 3. Veuillez refaire votre choix");
                                    Console.ReadLine();
                                break;
                        }   
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Le chemin du fichier fourni est invalide. appuyer sur la touche entrée pour réassayer");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
        }
    }
    
    
    
}
