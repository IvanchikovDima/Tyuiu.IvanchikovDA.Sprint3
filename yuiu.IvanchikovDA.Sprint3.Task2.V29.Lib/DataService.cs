using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanchikovDA.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double S = 0;
            do
            {
                S = S + ((Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(S, 3);
        }
    }
}
