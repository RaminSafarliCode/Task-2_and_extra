using System;

namespace Number10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) 3 dene 4 reqemli eded verilib.I ededin 1 % -ni, II ededin 2 % , III ededin 3 % tap.
            //    Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel

            Console.Write("Input a 4-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 4-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 4-digits number: ");
            var value3 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);

            bool IsSucceed = a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double d = a * 0.01;
            Console.WriteLine($"1 percent of first number: {d}");

            double e = b * 0.02;
            Console.WriteLine($"2 percent of second number: {e}");

            double f = c * 0.03;
            Console.WriteLine($"3 percent of third number: {f}");

            double substraction = d - e - f;
            Console.WriteLine($"Substraction of results: {substraction}");

            double result = substraction + c * 0.07;
            Console.WriteLine($"The final result: {result}");
        }
    }
}
