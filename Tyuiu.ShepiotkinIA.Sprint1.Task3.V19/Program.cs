using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShepiotkinIA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты первого поля:");
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второго поля:");
            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool canMove = Math.Abs(x1 - x2) == Math.Abs(y1 - y2);

            Console.WriteLine("Может ли слон перейти на другое поле за один ход: " + ds.ElephCanMove(x1, x2, y1, y2));

            Console.ReadKey();
        }
    }
}
