using System;
using System.Collections.Generic;
using LOG330.Classe;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class EcartTypeTest
    {
        //test ecart type avec 2 donnée.
        [Test]
        public void EcartTypeLowerBundary()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);
            listTest.Add(2);

            double ecartType = Calcul.CalculerEcartType(listTest, 2);
            
            Assert.AreEqual(Math.Round(ecartType, 1), 0.7);
        }
        
        //test écart type avec 20 données
        [Test]
        public void EcartTypeUpperBundary()
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

            double ecartType = Calcul.CalculerEcartType(listTest, 20);
            
            Assert.AreEqual(Math.Round(ecartType,1), 5.9);
        }
        
        //test si la taille de la liste est différente de celle fourni dans nbnombre devrait retourner 0
        [Test]
        public void EcartTypeInvalid()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);
            listTest.Add(2);
            
            double ecartType = Calcul.CalculerEcartType(listTest, 1);
            
            Assert.AreEqual(ecartType, 0);
        }
    }
}