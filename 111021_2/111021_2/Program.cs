using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _111021_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1");
            Console.WriteLine("Введите строки и получите её вторую половину (пробелы будут предварительно удалены)!!!");
            var text = Console.ReadLine();
            Console.WriteLine(TextWithoutSpacesSecondHalf(text));
            Console.WriteLine(new string ('=', 32));

            Console.WriteLine("Задача №2");
            Console.WriteLine("Введите температуру по Цельсию и получите разультат по Фаренгейту!!!");
            double celsium = Double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Round(celsium, 1)} °C = {Math.Round(CelsiumToFarenheit(celsium), 1)} °F");
            Console.WriteLine(new string('=', 32));

            Console.WriteLine("Задача №3");
            Console.WriteLine("Введите адрес электронной почты и узнайте интересный факт о ней!!!");
            var email = Console.ReadLine();
            var index = email.IndexOf("@");
            Console.WriteLine($"Ваш почтовый ящик {email.Substring(0, index)} находится на почтовом сервисе {email.Substring(index + 1)}");
            Console.WriteLine(new string('=', 32));

            Console.WriteLine("Задача №4");
            Console.WriteLine("Введите символ и узнайте его код в шестнадцатиричной системе счисления и следующий символ!!!");
            var symbol = Char.Parse(Console.ReadLine());
            Console.WriteLine($"Код символа \'{symbol}\' - 0x{Convert.ToString((int)symbol, 16).ToUpper()}");
            Console.WriteLine($"Следующий символ - \'{(char)((int)symbol + 1)}\'");
            Console.WriteLine(new string('=', 32));

            Console.ReadKey();
        }

        static string TextWithoutSpacesSecondHalf(string text)
        {
            var s = text.Replace(" ", "");
            return s.Substring(s.Length / 2);
        }

        static double CelsiumToFarenheit(double degrees)
        {
            return degrees * 1.8 + 32;
        }
    }
}
