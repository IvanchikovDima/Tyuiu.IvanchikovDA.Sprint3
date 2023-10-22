using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint3.Task1.V7.Lib;

namespace Tyuiu.IvanchikovDA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 9;
            double P = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = -0.93;
            Assert.AreEqual(P, wait);
        }
    }
}
