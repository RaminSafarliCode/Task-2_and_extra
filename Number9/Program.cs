using System;

namespace Number9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9) 3 dene 6 reqemli eded verilib.Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10 % tap.

            Console.Write("Input a 6-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value3 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);

            bool IsSucceed = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double percentageSum = a * 0.1 + b * 0.1 + c * 0.1;

            Console.WriteLine($"The sum of 10 percent of numbers: {percentageSum}");

            double result = percentageSum * 0.1;
            Console.WriteLine($"The final result: {result}");
        }
    }
}
