using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanchikovDA.Sprint3.Task2.V29.Lib;

namespace Tyuiu.IvanchikovDA.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesValid()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;
            double S = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.186;
            Assert.AreEqual(S, wait);
        }
    }
}
