using System;

namespace Number6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) 4 reqemli eded verilib.Bu ededin evvel 20 % -ni , sonra ise cavabin 10 % tap.Alinan cavabin kvadratini tap.

            Console.Write("Input the 4-digits number: ");
            var value = Console.ReadLine();

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 1000 && a < 10000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double b = a * 0.2;
            Console.WriteLine($"20 percent of the number: {b}");

            double c = b * 0.1;
            Console.WriteLine($"10 percent of the result: {c}");

            double result = Math.Pow(c, 2);
            Console.WriteLine($"The square of the result: {result}");
        }
    }
}
