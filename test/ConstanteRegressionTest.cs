using System;
using System.Collections.Generic;
using LOG330.Classe;
using NUnit.Framework;

namespace test
{
        [TestFixture]
        public class ConstanteRegressionTest
        {
            //test constante regression avec 3 donnée dans la liste
            [Test]
            public void ConstanteRegressionLowerBundary()
            {
                List<double> listTestX = new List<double>();
                List<double> listTestY = new List<double>();

                listTestX.Add(1);
                listTestX.Add(2);
                listTestX.Add(3);
                listTestY.Add(2);
                listTestY.Add(4);
                listTestY.Add(3);

                double constante = Calcul.CalculerConstanteRegression(listTestX, listTestY, 0.5);
            
                Assert.AreEqual(constante, 2);
            }
            
            
            //test correlation avec 10 données dans chaque liste
            [Test]
            public void ConstanteRegressionUpperBundary()
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

                double constante = Calcul.CalculerConstanteRegression(listTestX,listTestY,  1.72793243);
            
                Assert.AreEqual(Math.Round(constante,4), -22.5525);
            }
        
        
            //test constante regression devrait retourner 0 si listx ou listy est vide
            [Test]
            public void ConstanteRegressionInvalid()
            {
                List<double> listTestX = new List<double>();
                List<double> listTestY = new List<double>();

                
                double penteRegression = Calcul.CalculerPenteRegression(listTestX, listTestY, 3);
            
                Assert.AreEqual(penteRegression, 0);
            }
            

        }
}