using System;
using System.Collections.Generic;
using LOG330.Classe;
using NUnit.Framework;


namespace test
{
    [TestFixture]
    public class CorrelationTest
    {
        //test correlation avec 3 données dans chaque liste
        [Test]
        public void CorrelationLowerBundary()
        {
            List<double> listTestX = new List<double>();
            List<double> listTestY = new List<double>();

            listTestX.Add(1);
            listTestX.Add(2);
            listTestX.Add(3);
            listTestY.Add(2);
            listTestY.Add(4);
            listTestY.Add(3);

            double correlation = Calcul.CalculerCorrelation(listTestX, listTestY, 3);
            
            Assert.AreEqual(Math.Round(correlation , 3), 0.5);
        }
        //test correlation avec 10 données dans chaque liste
        [Test]
        public void CorrelationUpperBundary()
        {
            List<double> listTestX = new List<double>();
            List<double> listTestY = new List<double>();

            listTestX.Add(186);
            listTestX.Add(699);
            listTestX.Add(132);
            listTestX.Add(272);
            listTestX.Add(291);
            listTestX.Add(331);
            listTestX.Add(199);
            listTestX.Add(1890);
            listTestX.Add(788);
            listTestX.Add(1601);
            listTestY.Add(15);
            listTestY.Add(69.9);
            listTestY.Add(6.5);
            listTestY.Add(22.4);
            listTestY.Add(28.4);
            listTestY.Add(65.9);
            listTestY.Add(19.4);
            listTestY.Add(189.7);
            listTestY.Add(38.8);
            listTestY.Add(138.2);

            double variance = Calcul.CalculerCorrelation(listTestX,listTestY, 10);
            
            Assert.AreEqual(Math.Round(variance,8), 0.95592053);
        }
        //test correlation devrais retourner 0 si list x n'a pas la même taille que list y
        [Test]
        public void CorrelationInvalid()
        {
            List<double> listTestX = new List<double>();
            List<double> listTestY = new List<double>();

            listTestX.Add(186);
            listTestX.Add(699);
            listTestY.Add(186);
            listTestY.Add(699);
            listTestY.Add(186);
            
            double correlation = Calcul.CalculerCorrelation(listTestX, listTestY, 3);
            
            Assert.AreEqual(correlation, 0);
        }
    }
}