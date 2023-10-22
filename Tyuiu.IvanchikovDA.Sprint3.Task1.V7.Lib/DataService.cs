﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanchikovDA.Sprint3.Task1.V7.Lib
{
    public class DataService : ISprint3Task1V7
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double P = 1;
            while (startValue <= stopValue)
            {
                P = P * ((Math.Pow(value, startValue) + 1) * Math.Sin(5));
                startValue++;
            }
            return Math.Round(P, 3);
        }
    }
}
