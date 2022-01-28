using System;

namespace Number3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 5 reqemli eded verilib.Bu ededin evvel 18 % sonra ise 3 % tap.

            Console.Write("Input a 5-digits number: ");
            var value = Console.ReadLine();

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 10000 && a < 100000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double b = a * 0.18;
            Console.WriteLine($"18 percent of the number: {b}");

            double c = a * 0.03;
            Console.WriteLine($"3 percent of the numver: {c}");
        }
    }
}
