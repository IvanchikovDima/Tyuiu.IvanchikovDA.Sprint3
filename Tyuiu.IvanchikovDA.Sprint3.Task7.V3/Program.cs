using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint3.Task7.V3.Lib;

namespace Tyuiu.IvanchikovDA.Sprint3.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#3 |Выполнил: Иванчиков Д.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            Console.WriteLine("Начало отрезка = " + startValue);

            int stopValue = 5;
            Console.WriteLine("Конец отрезка = " + stopValue);


            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     X     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,7:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
            Console.ReadKey();
        }
    }
}
