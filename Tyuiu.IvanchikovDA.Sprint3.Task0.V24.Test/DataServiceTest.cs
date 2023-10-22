using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint3.Task0.V24.Lib;

namespace Tyuiu.IvanchikovDA.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesValid()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 7;
            double P = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.125;
            Assert.AreEqual(P, wait);
        }
    }
}
