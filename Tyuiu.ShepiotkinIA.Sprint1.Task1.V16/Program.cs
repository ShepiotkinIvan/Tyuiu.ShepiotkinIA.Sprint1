﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint1.Task1.V16.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Щепёткин И. А. | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода и вывода в консольных приложениях               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Щепёткин Иван Андреевич | ИИПб-23-2                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* результат по формуле x * 5 * y + 2 * a и печатает его на экране.        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a, x, y;

            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, x, y));

            Console.ReadLine();
        }
    }
}
