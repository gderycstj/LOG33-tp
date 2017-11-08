using System;
using System.Collections.Generic;
using LOG330.Classe;
using NUnit.Framework;

namespace test
{
        [TestFixture]
        public class PenteRegressionTest
        {
            //test pente regression avec 3 donnée dans chaque liste
            [Test]
            public void PenteRegressionLowerBundary()
            {
                List<double> listTestX = new List<double>();
                List<double> listTestY = new List<double>();

                listTestX.Add(1);
                listTestX.Add(2);
                listTestX.Add(3);
                listTestY.Add(2);
                listTestY.Add(4);
                listTestY.Add(3);

                double pente = Calcul.CalculerPenteRegression(listTestX, listTestY, 3);
            
                Assert.AreEqual(pente,0.5);
            }
            
            
            //test pente regression avec 10 données dans chaque liste
            [Test]
            public void PenteRegressionUpperBundary()
            {
                List<double> listTestX = new List<double>();
                List<double> listTestY = new List<double>();

                listTestX.Add(130);
                listTestX.Add(650);
                listTestX.Add(99);
                listTestX.Add(150);
                listTestX.Add(128);
                listTestX.Add(302);
                listTestX.Add(95);
                listTestX.Add(945);
                listTestX.Add(368);
                listTestX.Add(961);
                
                listTestY.Add(186);
                listTestY.Add(699);
                listTestY.Add(132);
                listTestY.Add(272);
                listTestY.Add(291);
                listTestY.Add(331);
                listTestY.Add(199);
                listTestY.Add(1890);
                listTestY.Add(788);
                listTestY.Add(1601);

                double pente = Calcul.CalculerPenteRegression(listTestX,listTestY, 10);
            
                Assert.AreEqual(Math.Round(pente,8), 1.72793243);
            }
        
        
            //test pente regression devrait retourner 0 si list x n'a pas la même taille que list y
            [Test]
            public void PenteRegressionInvalid()
            {
                List<double> listTestX = new List<double>();
                List<double> listTestY = new List<double>();

                listTestX.Add(186);
                listTestX.Add(699);
                listTestY.Add(186);
                listTestY.Add(699);
                listTestY.Add(186);
            
                double penteRegression = Calcul.CalculerPenteRegression(listTestX, listTestY, 3);
            
                Assert.AreEqual(penteRegression, 0);
            }
            

        }
}