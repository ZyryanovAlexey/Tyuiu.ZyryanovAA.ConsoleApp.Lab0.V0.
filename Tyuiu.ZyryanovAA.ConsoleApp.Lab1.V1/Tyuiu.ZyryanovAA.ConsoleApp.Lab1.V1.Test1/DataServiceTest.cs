using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Lib;

namespace Tyuiu.ZyryanovAA.ConsoleApp.Lab1.V1.Test1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExspressionV_1_1()
        {
            double x = 5;
            double y = 6;
            double a = 9;
            DataService ds = new DataService();

            double res = ds.SolveExpressV_1_1(x,y,a);
            
            res  = Math.Round(res, 3);
            double wait = 534.387;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExspressionV_1_2()
        {
                double x = 4;
                double y = -3;
                double a = 7;
                DataService ds = new DataService();

                double res = ds.SolveExpressV_1_2(x, y, a);

                res = Math.Round(res, 3);
                double wait = 19.795;
            
            Assert.AreEqual(wait, res);
         }
    }
}
