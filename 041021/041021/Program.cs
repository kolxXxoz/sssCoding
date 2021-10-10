using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите величину угла в градусах и получите значения его синуса и косинуса!");
            Console.WriteLine();
            Console.WriteLine("Пример работы программы:");
            WriteSinCos(15);
            WriteSinCos(37);
            WriteSinCos(113);
            Console.WriteLine();

            double angleDegrees = Double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ответ:");
            WriteSinCos(angleDegrees);

            Console.ReadKey();
        }

        private static void WriteSinCos(double x)
        {
            Console.WriteLine("sin(" + x + "°) = " + GetRound3Sin(x) + ", cos(" + x + "°) = " + GetRound3Cos(x));
        }

        private static double GetRound3Cos(double x)
        {
            return Math.Round(Math.Cos(DegreesToRadians(x)), 3);
        }

        private static double DegreesToRadians(double x)
        {
            return x * Math.PI / 180;
        }

        private static double GetRound3Sin(double x)
        {
            return Math.Round(Math.Sin(DegreesToRadians(x)), 3);
        }
    }
}
