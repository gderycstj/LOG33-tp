using System;
using System.Collections.Generic;
using System.Diagnostics;
using LOG330.Classe;
using NUnit.Framework;


namespace test
{
    [TestFixture]
    public class MoyenneTest
    {
        //test moyenne avec une donnée dans la liste
        [Test]
        public void MoyenneLowerBundary()
        {
            List<double> listTest = new List<double>();

            listTest.Add(1);

            double moyenne = Calcul.CalculerMoyenne(listTest);
            
            Assert.AreEqual(moyenne, 1);
        }
        
        //test moyenne avec 20 données dans la liste
        [Test]
        public void MoyenneUpperBundary()
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

            double moyenne = Calcul.CalculerMoyenne(listTest);
            
            Assert.AreEqual(moyenne, 10.5);
        }
        
        //test moyenne avec liste vide. Devrais rien calculer et retourner 0
        [Test]
        public void MoyenneInvalid()
        {
            List<double> listTest = new List<double>();
            double moyenne = Calcul.CalculerMoyenne(listTest);
            
            Assert.AreEqual(moyenne, 0);

        }
    }
}