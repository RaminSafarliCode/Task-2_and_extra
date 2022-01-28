using System;

namespace Number8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) 2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
            //   I ededin 4 % -ni tap.
            //   Sonra II ededin 9 % ni tap.
            //   Sonra Cavalari toplayib 10 % ni tap.
            
            Console.Write("Input a 4-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 7-digits number: ");
            var value2 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);

            bool IsSucceed = a >= 1000 && a < 10000 && b >= 1000000 && b < 10000000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double firstpercentage = a * 0.04;
            double secondpercentage = b * 0.09;

            Console.WriteLine($"4 percent of first number: {firstpercentage}");
            Console.WriteLine($"9 percent of second number: {secondpercentage}");

            double result = (firstpercentage + secondpercentage) * 0.1;
            Console.WriteLine($"Final result: {result}");

        }
    }
}
