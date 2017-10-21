using System;
using System.Collections.Generic;
using LOG330.Classe;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class VarianceTet
    {
        //test variance avec au minimum 2 données.
        [Test]
        public void VarianceLowerBundary()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);
            listTest.Add(2);

            double variance = Calcul.CalculerVariance(listTest, 2);
            
            Assert.AreEqual(variance, 0.5);
        }
        //test variance avec 20 données
        [Test]
        public void VarianceUpperBundary()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);
            listTest.Add(2);
            listTest.Add(3);
            listTest.Add(4);
            listTest.Add(5);
            listTest.Add(6);
            listTest.Add(7);
            listTest.Add(8);
            listTest.Add(9);
            listTest.Add(10);
            listTest.Add(11);
            listTest.Add(12);
            listTest.Add(13);
            listTest.Add(14);
            listTest.Add(15);
            listTest.Add(16);
            listTest.Add(17);
            listTest.Add(18);
            listTest.Add(19);
            listTest.Add(20);

            double variance = Calcul.CalculerVariance(listTest, 20);
            
            Assert.AreEqual(Math.Round(variance,1), 35);
        }
        
        //test si la taille de la liste est différente de celle fourni dans nbnombre devrait retourner 0
        [Test]
        public void VarianceInvalid()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);
            listTest.Add(2);
            
            double variance = Calcul.CalculerVariance(listTest, 1);
            
            Assert.AreEqual(variance, 0);
        }
    }
}