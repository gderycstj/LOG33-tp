using System.Collections.Generic;

namespace LOG330.Classe
{
    public class Util
    {
        public static double AnalyseVariable(List<double> listSommeTemps, List<double> listNote, double nbDonnee)
        {
            double pente = Calcul.CalculerPenteRegression(listSommeTemps, listNote, nbDonnee);
            double constante = Calcul.CalculerConstanteRegression(listSommeTemps, listNote, pente);
            
            List<double> listRegNote = new List<double>();

            for (int i = 0; i < nbDonnee; i++)
            {
                listRegNote.Add(pente * listNote[i] + constante);
            }

            double corelation = Calcul.CalculerCorrelation(listSommeTemps, listRegNote, nbDonnee);
            
            return corelation;
        }
    }
}