using System;
using System.Collections.Generic;

namespace LOG330.Classe
{
    public static class Calcul
    {
        public static double CalculerMoyenne(List<double> listeNombres, double nbNombre)
        {
            double somme = 0;

            for (int i = 0; i < listeNombres.Count; i++)
            {
                somme += listeNombres[i];
            }

            return somme / nbNombre;
        }

        public static double CalculerVariance(List<double> listeNombres, double nbNombre)
        {
            double moyenne = CalculerMoyenne(listeNombres, nbNombre);
            double sommeDistance = 0;
    
            for (int i = 0; i < listeNombres.Count; i++)
            {
                sommeDistance += ((listeNombres[i] - moyenne) * (listeNombres[i] - moyenne));
            }

            return ((1 / (nbNombre - 1)) * sommeDistance);
        }

        public static double CalculerEcartType(List<double> listeNombres, double nbNombre)
        {
            double variance = CalculerVariance(listeNombres, nbNombre);

           return Math.Sqrt(variance);
        }

        public static double CalculerSomme(List<double> listeNombres)
        {
            double somme = 0;

            for (int i = 0; i < listeNombres.Count; i++)
            {
                somme += listeNombres[i]; 
            }

            return somme;
        }

        public static double CalculerCorrelation(List<double> listeX, List<double> listeY, double nbNombre)
        {
            List<double> listeXX = new List<double>();
            List<double> listeYY = new List<double>();
            List<double> listeXY = new List<double>();

            for (int i = 0; i < nbNombre; i++)
            {
                listeXX.Add(listeX[i] * listeX[i]);
                listeYY.Add(listeY[i] * listeY[i]);
                listeXY.Add(listeY[i] * listeX[i]);
            }

            double sommeX = CalculerSomme(listeX);
            double sommeY = CalculerSomme(listeY);
            double sommeXX = CalculerSomme(listeXX);
            double sommeYY = CalculerSomme(listeYY);
            double sommeXY = CalculerSomme(listeXY);

            return (((nbNombre * sommeXY) - (sommeX * sommeY)) / (Math.Sqrt(((nbNombre * sommeXX) - (sommeX * sommeX)) * ((nbNombre * sommeYY) - (sommeY * sommeY))))); 
        }

    }
}