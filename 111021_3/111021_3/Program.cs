using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111021_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x:");
            var x = bool.Parse(Console.ReadLine());

            Console.WriteLine("Введите y:");
            var y = bool.Parse(Console.ReadLine());

            Console.WriteLine($"!x = {!x}, !y = {!y}");
            Console.WriteLine($"x & y = {x & y}, x | y = {x | y}, x ^ y = {x ^ y}");

            Console.ReadKey();
        }
    }
}
