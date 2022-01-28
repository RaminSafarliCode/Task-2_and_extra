using System;

namespace Number12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) 4 dene 6 reqemli eded verilib.Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
            //      Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.

            Console.Write("Input a 6-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value3 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value4 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);
            int d = Convert.ToInt32(value4);

            bool IsSucceed = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double t = a * 0.1;
            Console.WriteLine($"10 percent of first number: {t}");

            double x = b * 0.1;
            Console.WriteLine($"10 percent of second number: {x}");

            double y = c * 0.1;
            Console.WriteLine($"10 percent of third number: {y}");

            double z = d * 0.1;
            Console.WriteLine($"10 percent of fourth number: {z}"); 

            double sum = t + x + y + z;
            Console.WriteLine($"Sum of 10 percents of numbers: {sum}");

            
            double tt = a * 0.15;
            Console.WriteLine($"15 percent of first number: {tt}");

            double xx = b * 0.15;
            Console.WriteLine($"15 percent of second number: {xx}");

            double yy = c * 0.15;
            Console.WriteLine($"15 percent of third number: {yy}");

            double zz = d * 0.15;
            Console.WriteLine($"15 percent of fourth number: {zz}");

            double sum2 = t + x + y + z;
            Console.WriteLine($"Sum of 15 percents of numbers: {sum2}");

            double multiplication = sum * sum2;
            Console.WriteLine($"Multiplication of sums: {multiplication}");

            double percentNumber = multiplication * 0.1;
            Console.WriteLine($"10 percent of result: {percentNumber}");

            double result = percentNumber * 0.11;
            Console.WriteLine($"Final result: {result}");
        }
    }
}
